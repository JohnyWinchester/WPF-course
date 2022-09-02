using EmailsEF.Context;
using EmailsEF.Model;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace AndreyMatveewDZ01.Model
{
    /// <summary>
    /// Класс MailSender 
    /// отвечает за формирование и отправку письма
    /// </summary>
    public class MailSender
    {
        public MailSender(string from,string to,string smtp,string mailSubject,string mailBody,string password)
        {
            Smtp smtpPort = new Smtp();
            AddressesSend = new MailAddress(from);
            AddressesReceiver = new MailAddress(to);

            string name = "";
            using(EmailContext db = new EmailContext())
            {
                smtpPort = db.Smtps.Where(x => x.SmtpName == smtp).First();
                name = db.Emails.Where(x => x.Address == to).First().Name;
            }
            //MailInformation.Email = to;
            //MailInformation.Status = "Отправлено";
            //MailInformation.Date = DateTime.Today.ToString();
            MailInformation = new MailInformation(to, "Отправлено", DateTime.Today.ToString(), name);
            SendMail(smtpPort, mailSubject, mailBody,password);
        }
        private MailAddress addressesSend;
        private MailAddress addressesReceiver;
        private MailInformation mailInformation;
        public MailInformation MailInformation
        {
            get => mailInformation;
            set => mailInformation = value;
        }
        public MailAddress AddressesSend
        {
            get => addressesSend;
            set => addressesSend = value;
        }
        public MailAddress AddressesReceiver
        {
            get => addressesReceiver;
            set => addressesReceiver = value;
        }
        private void SendMail(Smtp smtp,string mailSubject,string mailBody,string password)
        {
            try
            {
                //var fromAddress = new MailAddress("geekbrains2021@gmail.com", "Tester");
                //var toAddress = new MailAddress("geekbrains2021@gmail.com", "Tester");
                //Преобазование из Windows-1251 в UTF-8
                //string subject = message.Subject;// tbSubject.Text;
                //string fio = "from me";
                //rtbBody.SelectAll();
                //string password = password;//  tbPassword.Password;
                //string body = message.Body;// tbBody.Text; //rtbBody.Selection.Text; // dataTasks.Value + "\r\n" + dataResult.Value;// win1251.GetString(win1251Bytes3)+"\r\n"+ win1251.GetString(win1251Bytes2);                
                var client = new SmtpClient()
                {
                    Host = smtp.SmtpName,
                    Port = smtp.SmtpAddress,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(AddressesSend.Address, password)
                };
                client.Send(AddressesSend.Address, AddressesReceiver.Address, mailSubject, mailBody);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



            //using(var client = new SmtpClient(smtp.SmtpName, smtp.SmtpAddress) { Credentials = new NetworkCredential(AddressesSend.Address,password),EnableSsl = true}) // Credentials  SSL
            //{
            //    client.Send(AddressesSend.Address, AddressesReceiver.Address, mailSubject, mailBody);
            //}
        }
    }
}
