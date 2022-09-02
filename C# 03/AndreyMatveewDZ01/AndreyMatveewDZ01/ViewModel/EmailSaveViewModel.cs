using AndreyMatveewDZ01.Model;
using EmailsEF.Context;
using EmailsEF.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.Linq;

namespace AndreyMatveewDZ01.ViewModel
{
    /// <summary>
    ///  View Model добавления нового емейла
    /// </summary>
    public class EmailSaveViewModel: ViewModelBase
    {
        private ObservableCollection<string> smtps;
        private string address;
        private string name;
        private string password;
        public string Address
        {
            get => address;
            set => Set(ref address, value);
        }
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }
        public string Password
        {
            get => password;
            set => Set(ref password, value);
        }
        public ObservableCollection<string> Smtps
        {
            get => smtps;
            set => Set(ref smtps, value);
        }
        public EmailSaveViewModel()
        {
            using(EmailContext db = new EmailContext())
            {
                Smtps = new ObservableCollection<string>(db.Smtps.Select(x => x.SmtpName));
            }
            SaveEmailCommand = new RelayCommand<object>(OnSaveEmailCommand,CanSaveEmailCommand);
        }
        public void OpenSaveEmailWindow(NotificationMessage msg)
        {
            var window = new OpenWindowService<EmailSaveViewModel>();
            if (msg.Notification == "Open Save Window" && window.WindowStatus == false)
                window.Show();
            MessengerInstance.Unregister(this);
        }
        public RelayCommand<object> SaveEmailCommand { get; private set; }
        private bool CanSaveEmailCommand(object p) => true;
        private void OnSaveEmailCommand(object p)
        {
            Smtp smtp = new Smtp();
            Email email = new Email();
            using (EmailContext db = new EmailContext())
            {
                smtp = db.Smtps.Where(x => x.SmtpName == (string)p).First();
                email.Address = Address;
                email.Name = Name;
                if(Password != null) email.Password = BCrypt.Net.BCrypt.HashPassword(Password);
                email.Smtp = smtp;
                db.Emails.Add(email);
                db.SaveChanges();
            }

            email.Password = Password;

            MessengerInstance.Send<NotificationMessage, MainViewModel>(new NotificationMessage("Refresh Fields"));
            MessengerInstance.Send<Email, MainViewModel>(email);

            Address = null;
            Name = null;
            Password = null;
        }
    }
}
