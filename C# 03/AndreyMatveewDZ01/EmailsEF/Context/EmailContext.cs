using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailsEF.Model;

namespace EmailsEF.Context
{
    public class EmailContext: DbContext
    {
        public EmailContext(): base("Emails")
        {

        }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Smtp> Smtps { get; set; }
    }
}
