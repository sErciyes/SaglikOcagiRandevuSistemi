using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SaglıkOcagıRandevuSistemi.Classes
{
    public class BaseU
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentifyidentificationNumber { get; set; }
        public string UniqueID { get; set; }
        public bool IsVerify { get; set; }
        public MailAddress MailAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string Number { get; set; }
        public string PasswordHash { get; set; }
    }
}
