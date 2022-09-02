using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailsEF.Model
{
    /// <summary>
    ///  Создаёт экземпляр SMTP
    /// </summary>
    public class Smtp
    {
        [Required]
        public int SmtpId { get; set; }

        [Required]
        public int SmtpAddress { get; set; }

        [MaxLength(30)]
        [Required]
        public string SmtpName { get; set; }
        public List<Email> Emails { get; set; }
    }
}
