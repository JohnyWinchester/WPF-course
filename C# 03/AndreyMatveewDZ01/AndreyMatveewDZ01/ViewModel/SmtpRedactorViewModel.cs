using AndreyMatveewDZ01.Model;
using EmailsEF.Context;
using EmailsEF.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace AndreyMatveewDZ01.ViewModel
{
    /// <summary>
    ///  View Model окна с редактированием SMTP сервера
    /// </summary>
    public class SmtpRedactorViewModel : ViewModelBase
    {
        public SmtpRedactorViewModel()
        {
            Messenger.Default.Register<Smtp>(this, SetEmailFields);
            UpdateSmtpCommand = new RelayCommand(OnUpdateSmtpCommand, CanUpdateSmtpCommand);
        }
        public void SetEmailFields(Smtp obj)
        {
            Smtp = obj;
            Address = obj.SmtpAddress;
            Name = obj.SmtpName;
        }
        public void OpenRedactorSmtpWindow(NotificationMessage msg)
        {
            var window = new OpenWindowService<SmtpRedactorViewModel>();
            if (msg.Notification == "Open Smtp Editor Window" && window.WindowStatus == false)
                window.Show();
            MessengerInstance.Unregister<NotificationMessage>(this);
        }

        private Smtp smtp;
        private int address;
        private string name;
        public Smtp Smtp
        {
            get => smtp;
            set => Set(ref smtp, value);
        }
        public int Address
        {
            get => address;
            set => Set(ref address, value);
        }
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }
        public RelayCommand UpdateSmtpCommand { get; private set; }
        private bool CanUpdateSmtpCommand() => true;
        private void OnUpdateSmtpCommand()
        {
            using (EmailContext db = new EmailContext())
            {
                Smtp.SmtpAddress = Address;
                Smtp.SmtpName = Name;

                db.Entry(Smtp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            MessengerInstance.Send<NotificationMessage, MainViewModel>(new NotificationMessage("Refresh Fields"));
        }
    }
}
