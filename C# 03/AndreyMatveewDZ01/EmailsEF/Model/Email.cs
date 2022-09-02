using System.ComponentModel.DataAnnotations;

namespace EmailsEF.Model
{
    /// <summary>
    ///  Создаёт экземпляр Емейла
    /// </summary>
    public class Email
    {
        [Required]
        public int EmailId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(100)]
        [Required]
        public string Address { get; set; }
        public string Password { get; set; }
        public int? SmtpId { get; set; }
        public Smtp Smtp { get; set; }
    }
}
