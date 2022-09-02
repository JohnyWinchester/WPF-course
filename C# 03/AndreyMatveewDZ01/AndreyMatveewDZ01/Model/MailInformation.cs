using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyMatveewDZ01.Model
{
    public class MailInformation
    {
        private string emailName;
        private string email;
        private string date;
        private string status;
        public string EmailName
        {
            get => emailName;
            set => emailName = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Date
        {
            get => date;
            set => date = value;
        }
        public string Status
        {
            get => status;
            set => status = value;
        }
        public MailInformation(string name,string emailReceiver,string dateSending,string statusSending)
        {
            EmailName = name;
            Email = emailReceiver;
            Date = dateSending;
            Status = statusSending;
        }

    }
}
