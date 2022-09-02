using AndreyMatveewDZ01.Model;
using EmailsEF.Context;
using EmailsEF.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;

namespace AndreyMatveewDZ01.ViewModel
{
    /// <summary>
    ///  View Model редактирования емейла
    /// </summary>
    public class EmailRedactorViewModel : ViewModelBase
    {
        public EmailRedactorViewModel()
        {
            Messenger.Default.Register<Email>(this, SetEmailFields);

            UpdateEmailCommand = new RelayCommand(OnUpdateEmailCommand, CanUpdateEmailCommand);
        }
        public void SetEmailFields(Email obj)
        {
            Email = obj;
            Address = obj.Address;
            Name = obj.Name;
        }

        public void OpenRedactorEmailWindow(NotificationMessage msg)
        {
            var window = new OpenWindowService<EmailRedactorViewModel>();
            if (msg.Notification == "Open Editor Window" && window.WindowStatus == false)
                window.Show();
            MessengerInstance.Unregister(this);
        }
        private Email email;
        private string address;
        private string name;
        private string password;
        private ObservableCollection<string> smtps;
        private string selectedSmtp;
        public RelayCommand UpdateEmailCommand { get; private set; }
        private bool CanUpdateEmailCommand() => true;
        private void OnUpdateEmailCommand()
        {
            using(EmailContext db = new EmailContext())
            {
                Email.Address = Address;
                Email.Name = Name;
                if (Password == "") Password = null;
                Email.Password = Password;
                if (Password != null) Email.Password = BCrypt.Net.BCrypt.HashPassword(Password);

                db.Entry(Email).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            Email.Password = Password;
            MessengerInstance.Send<NotificationMessage, MainViewModel>(new NotificationMessage("Refresh Fields"));
            MessengerInstance.Send<Email, MainViewModel>(Email);
            Address = null;
            Name = null;
            Password = null;
        }
        public Email Email
        {
            get => email;
            set => Set(ref email, value);
        }
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
        public string SelectedSmtp
        {
            get => selectedSmtp;
            set => Set(ref selectedSmtp, value);
        }
    }
}
