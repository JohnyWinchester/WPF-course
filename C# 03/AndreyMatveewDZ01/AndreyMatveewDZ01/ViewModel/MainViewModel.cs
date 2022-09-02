using AndreyMatveewDZ01.Model;
using EmailsEF.Context;
using EmailsEF.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace AndreyMatveewDZ01.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        #region ViewModels
        public EmailSaveViewModel EmailSaveVM {get; set;}
        public EmailRedactorViewModel EmailRedactorVM { get; set; }
        public SmtpSaveViewModel SmtpSaveVM { get; set; }
        public SmtpRedactorViewModel SmtpRedactorVM { get; set; }
        #endregion
        public MainViewModel()
        {
            EmailSaveVM = new EmailSaveViewModel();
            EmailRedactorVM = new EmailRedactorViewModel();
            SmtpSaveVM = new SmtpSaveViewModel();
            SmtpRedactorVM = new SmtpRedactorViewModel();
            Emails = new ObservableCollection<Email>();
            RefreshFields();

            CloseApplocationCommand = new RelayCommand(() => Application.Current.Shutdown());
            OpenEmailSaveWindowCommand = new RelayCommand(OnOpenEmailSaveWindowCommand,CanOpenOpenEmailSaveWindowCommand);
            OpenEmailRedactorWindowCommand = new RelayCommand<object>(OnOpenEmailRedactorWindowCommand, CanOpenEmailRedactorWindowCommand);
            DeleteEmailCommand = new RelayCommand<object>(OnOpenDeleteEmailCommand,CanDeleteEmailCommand);
            DeleteSmtpCommand = new RelayCommand<object>(OnDeleteSmtpCommand, CanDeleteSmtpCommand);
            OpenSmtpSaveWindowCommand = new RelayCommand(OnOpenSmtpSaveWindowCommand,CanOpenSmtpSaveWindowCommand);
            OpenSmtpRedactorWindowCommand = new RelayCommand<object>(OnOpenSmtpRedactorWindowCommand, CanOpenSmtpRedactorWindowCommand);
            SendEmailCommand = new RelayCommand(OnSendEmailCommand,CanSendEmailCommand);

            MessengerInstance.Register<Email>(this, AddNewEmail);
            MessengerInstance.Register<NotificationMessage>(this, RefreshFieldsMessage);
        }

        private void AddNewEmail(Email obj)
        {
            if (Emails.Count == 0)
            {
                Emails.Add(obj);
                return;
            }

            for(int i = 0;i < Emails.Count; i++)
            {
                if (Emails[i].SmtpId == obj.SmtpId)
                {
                    Emails[i] = obj;
                    return;
                }
                Emails.Add(obj);
            }
        }
        private void RefreshFieldsMessage(NotificationMessage obj)
        {
            if(obj.Notification == "Refresh Fields")
            {
                RefreshFields();
            }
        }
        private void RefreshFields()
        {
            using (EmailContext db = new EmailContext())
            {
                AddressesSending = new ObservableCollection<string>(db.Emails.Where(x => x.Password != null).Select(x => x.Address));
                AddressesReceive = new ObservableCollection<string>(db.Emails.Select(x => x.Address));
                Smtps = new ObservableCollection<string>(db.Smtps.Select(x => x.SmtpName));
            }
        }

        private ObservableCollection<Email> emails;
        public ObservableCollection<Email> Emails 
        { 
            get => emails;
            set => Set(ref emails, value); 
        }

        #region Команды

        #region OpenEmailSaveWindowCmd - Добавление емейла
        public RelayCommand OpenEmailSaveWindowCommand { get; private set; }
        private bool CanOpenOpenEmailSaveWindowCommand() => true;
        private void OnOpenEmailSaveWindowCommand()
        {
            MessengerInstance.Send<NotificationMessage, EmailSaveViewModel>(new NotificationMessage("Open Save Window"));
            MessengerInstance.Register<NotificationMessage>(EmailSaveVM, EmailSaveVM.OpenSaveEmailWindow);
        }
        #endregion

        #region OpenEmailRedactorWindowCmd - Редактирование емейла
        public RelayCommand<object> OpenEmailRedactorWindowCommand { get; private set; }
        private bool CanOpenEmailRedactorWindowCommand(object p) => true;
        private void OnOpenEmailRedactorWindowCommand(object p)
        {
            Email email = new Email();
            using (EmailContext db = new EmailContext())
            {
                email = db.Emails.Where(x => (string)p == x.Address).Single();
            }

            Messenger.Default.Send<NotificationMessage, EmailRedactorViewModel>(new NotificationMessage("Open Editor Window"));
            Messenger.Default.Send<Email, EmailRedactorViewModel>(email);
            MessengerInstance.Register<NotificationMessage>(EmailRedactorVM, EmailRedactorVM.OpenRedactorEmailWindow);
        }
        #endregion

        #region DeleteEmailCommand - Удаление емейла
        public RelayCommand<object> DeleteEmailCommand { get; private set; }
        private bool CanDeleteEmailCommand(object p) => true;
        private void OnOpenDeleteEmailCommand(object p)
        {
            Email email = new Email();
            using (EmailContext db = new EmailContext())
            {
                email = db.Emails.Where(x => (string)p == x.Address).FirstOrDefault();
                db.Emails.Remove(email);
                db.SaveChanges();
            }

            for(int i = 0;i < Emails.Count; i++)
            {
                if (Emails[i].Address == email.Address)
                    Emails.Remove(Emails[i]);
            }

            RefreshFields();
        }
        #endregion

        #region OpenSmtpSaveWindowCommand - Добавление SMTP
        public RelayCommand OpenSmtpSaveWindowCommand { get; private set; }
        private bool CanOpenSmtpSaveWindowCommand() => true;
        private void OnOpenSmtpSaveWindowCommand()
        {
            MessengerInstance.Send<NotificationMessage, SmtpSaveViewModel>(new NotificationMessage("Open Save Smtp Window"));
            MessengerInstance.Register<NotificationMessage>(SmtpSaveVM, SmtpSaveVM.OpenSaveSmtpWindow);
        }
        #endregion

        #region OpenSmtpRedactorWindowCommand - Редактирование SMTP
        public RelayCommand<object> OpenSmtpRedactorWindowCommand { get; private set; }
        private bool CanOpenSmtpRedactorWindowCommand(object p) => true;
        private void OnOpenSmtpRedactorWindowCommand(object p)
        {
            Smtp smtp = new Smtp();
            using (EmailContext db = new EmailContext())
            {
                smtp = db.Smtps.Where(x => (string)p == x.SmtpName).Single();
            }

            Messenger.Default.Send<NotificationMessage, SmtpRedactorViewModel>(new NotificationMessage("Open Smtp Editor Window"));
            Messenger.Default.Send<Smtp, SmtpRedactorViewModel>(smtp);
            MessengerInstance.Register<NotificationMessage>(SmtpRedactorVM, SmtpRedactorVM.OpenRedactorSmtpWindow);
        }
        #endregion

        #region DeleteSmtpCommand - Удаление SMTP
        public RelayCommand<object> DeleteSmtpCommand { get; private set; }
        private bool CanDeleteSmtpCommand(object p) => true;
        private void OnDeleteSmtpCommand(object p)
        {
            Smtp smtp = new Smtp();
            using (EmailContext db = new EmailContext())
            {
                smtp = db.Smtps.Where(x => (string)p == x.SmtpName).Single();
                var emails = db.Emails.Where(x => x.SmtpId == smtp.SmtpId);
                foreach(var el in emails)
                {
                    el.SmtpId = null;
                }

                db.Smtps.Remove(smtp);
                db.SaveChanges();
            }
            RefreshFields();
        }
        #endregion

        #region SendEmailCommand - Отправка письма
        public RelayCommand SendEmailCommand { get; private set; }
        private bool CanSendEmailCommand() => true;
        private void OnSendEmailCommand()
        {
            string password = Emails.Where(x => x.Address == SelectedAddressesSend).Single().Password;
            MailSender mailSender = new MailSender(SelectedAddressesSend, SelectedAddressesReceiver,SelectedSmtp,SubjectMessage,BodyMessage, password);

            MailInformation.Add(mailSender.MailInformation);
        }
        #endregion
        public RelayCommand CloseApplocationCommand { get; private set; }

        #endregion
        private ObservableCollection<MailInformation> mailInformation;
        public ObservableCollection<MailInformation> MailInformation
        {
            get => mailInformation;
            set => Set(ref mailInformation, value);
        }
        private ObservableCollection<string> addressesSending;
        private ObservableCollection<string> addressesReceive;
        private ObservableCollection<string> smtps;

        public ObservableCollection<string> AddressesSending
        {
            get => addressesSending;
            set => Set(ref addressesSending, value);
        }
        public ObservableCollection<string> AddressesReceive
        {
            get => addressesReceive;
            set => Set(ref addressesReceive, value);
        }
        public ObservableCollection<string> Smtps
        {
            get => smtps;
            set => Set(ref smtps, value);
        }

        #region Формирование данных к письму
        private string selectedAddressesSend;
        private string selectedAddressesReceiver;
        private string selectedSmtp;
        private string subjectMessage;
        private string bodyMessage;
        public string SelectedAddressesSend
        {
            get => selectedAddressesSend;
            set => Set(ref selectedAddressesSend, value);
        }
        public string SelectedAddressesReceiver
        {
            get => selectedAddressesReceiver;
            set => Set(ref selectedAddressesReceiver, value);
        }
        public string SelectedSmtp
        {
            get => selectedSmtp;
            set => Set(ref selectedSmtp, value);
        }
        public string SubjectMessage
        {
            get => subjectMessage;
            set => Set(ref subjectMessage, value);
        }
        public string BodyMessage
        {
            get => bodyMessage;
            set => Set(ref bodyMessage, value);
        }
        #endregion
    }
}   