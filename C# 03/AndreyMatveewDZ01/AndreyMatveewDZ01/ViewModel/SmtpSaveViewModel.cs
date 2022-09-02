using AndreyMatveewDZ01.Model;
using EmailsEF.Context;
using EmailsEF.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace AndreyMatveewDZ01.ViewModel
{
    /// <summary>
    ///  View Model окна добавления адресса SMTP сервера
    /// </summary>
    public class SmtpSaveViewModel : ViewModelBase
    {
        private int address;
        private string name;
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
        public SmtpSaveViewModel()
        {
            SaveSmtpCommand = new RelayCommand(OnSaveEmailCommand,CanSaveEmailCommand);
        }
        public void OpenSaveSmtpWindow(NotificationMessage msg)
        {
            var window = new OpenWindowService<SmtpSaveViewModel>();
            if (msg.Notification == "Open Save Smtp Window" && window.WindowStatus == false)
                window.Show();
            MessengerInstance.Unregister(this);
        }
        public RelayCommand SaveSmtpCommand { get; set; }
        private bool CanSaveEmailCommand() => true;
        private void OnSaveEmailCommand()
        {
            Smtp smtp = new Smtp();
            using (EmailContext db = new EmailContext())
            {
                smtp.SmtpAddress = Address;
                smtp.SmtpName = Name;

                db.Smtps.Add(smtp);
                db.SaveChanges();
            }

            Name = null;

            MessengerInstance.Send<NotificationMessage, MainViewModel>(new NotificationMessage("Refresh Fields"));
        }
    }
}
