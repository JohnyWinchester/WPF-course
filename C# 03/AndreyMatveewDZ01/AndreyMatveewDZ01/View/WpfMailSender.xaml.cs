using AndreyMatveewDZ01.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using AndreyMatveewDZ01.View;
using AndreyMatveewDZ01.ViewModel;
using EmailsEF.Model;
using EmailsEF.Context;

namespace AndreyMatveewDZ01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //using (EmailContext db2 = new EmailContext())
            //{
            //    db2.Database.Delete();
            //    db2.Database.Create();

            //    var huy = new Smtp() { SmtpName = "HUY", SmtpAddress = 2222 };
            //    db2.Smtps.Add(huy);
            //    db2.Emails.Add(new Email { Smtp = huy, Address = "yyyyyyyyy", Name = "wd33333333"});

            //    db2.Smtps.Add(new Smtp { SmtpName = "pizda", SmtpAddress = 8999999 });
            //    db2.Emails.Add(new Email { Password = "1", Name = "2", Address = "3" });
            //    db2.SaveChanges();
            //}
            //using (EmailRepository db2 = new EmailRepository())
            //{
            //    db2.Add(new Email { Address = "awdd", Name = "wwwww", Password = "21122",Smtp = new Smtp { SmtpName = "HUY"} });
            //    cbSenderSelect.ItemsSource = db2.GetEmailsList.Select(x => x.Name).ToList();
            //}
            //using (EmailContext context = new EmailContext())
            //{
            //    cbSenderSelect.ItemsSource = context.Emails.Select(x => x.Name).ToList();
            //}

        }
        //private void btnSendAtOnce_Click(object sender, RoutedEventArgs e)
        //{
        //    string strLogin = cbSenderSelect.Text;
        //    string strPassword = cbSenderSelect.SelectedValue.ToString();
        //    string srtSmtp = cbSmtpSelect.Text;
        //    int smtpPort = (int)cbSmtpSelect.SelectedValue;

        //    if(subjectBox.Text == null ||
        //       new TextRange(letterBox.Document.ContentStart, letterBox.Document.ContentEnd).Text.Length < 3)
        //    {
        //        var erorr = new ErorrWindow("Заполните текст письма и его заголовок");
        //        erorr.Show();
        //        tababControl.SelectedIndex = 2;
        //    }
        //    if (string.IsNullOrEmpty(strLogin))
        //    {
        //        MessageBox.Show("Выберите отправителя");
        //        return;
        //    }
        //    if (string.IsNullOrEmpty(strPassword))
        //    {
        //        MessageBox.Show("Укажите пароль отправителя");
        //        return;
        //    }
        //    if (string.IsNullOrEmpty(srtSmtp))
        //    {
        //        MessageBox.Show("Укажите пароль отправителя");
        //        return;
        //    }
        //    if (smtpPort == 0)
        //    {
        //        MessageBox.Show("Укажите пароль отправителя");
        //        return;
        //    }

        //    EmailSendServiceClass emailSender = new EmailSendServiceClass(strLogin, strPassword, srtSmtp, smtpPort);
        //    var locator = (ViewModelLocator)FindResource("Locator");
        //    emailSender.SendMails(locator.Main.Emails);
        //}
        //private void btnSend_Click(object sender, RoutedEventArgs e)
        //{
        //    if (subjectBox.Text == null ||
        //        new TextRange(letterBox.Document.ContentStart, letterBox.Document.ContentEnd).Text.Length < 3)
        //    {
        //        var erorr = new ErorrWindow("Заполните текст письма и его заголовок");
        //        erorr.Show();
        //        tababControl.SelectedIndex = 2;
        //    }
        //    SchedulerClass sc = new SchedulerClass();
        //    TimeSpan tsSendTime = sc.GetSendTime(tbTimePicker.Text);
        //    if (tsSendTime == new TimeSpan())
        //    {
        //        MessageBox.Show("Некорректный формат даты");
        //        return;
        //    }
        //    DateTime dtSendDateTime = (cldSchedulDateTimes.SelectedDate ?? DateTime.Today).Add(tsSendTime);
        //    if (dtSendDateTime < DateTime.Now)
        //    {
        //        MessageBox.Show("Дата и время отправки писем не могут быть раньше, чем настоящее время");
        //        return;
        //    }
        //    EmailSendServiceClass emailSender = new EmailSendServiceClass(cbSenderSelect.Text, cbSenderSelect.SelectedValue.ToString(),
        //                                                                  cbSmtpSelect.Text,(int)cbSmtpSelect.SelectedValue);
        //    var locator = (ViewModelLocator)FindResource("Locator");
        //    sc.SendEmails(dtSendDateTime, emailSender, locator.Main.Emails);
        //}
    }
}
