using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SaglıkOcagıRandevuSistemi.Classes
{
    public class User : BaseU
    {
        // User sınıfına özgü ek özellikler
        public string Role { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Doctor UsersDoctor { get; set; }

        public User() {}
        // User sınıfı için constructor
        public User(int id, string name, string lastName, string identificationNumber, string uniqueID, bool isVerify, MailAddress mailAddress, DateTime birthDate, bool gender, string number, string role, DateTime registrationDate)
        {
            // Base sınıfın (BaseU) özelliklerini constructor içinde atıyoruz
            this.ID = id;
            this.Name = name;
            this.LastName = lastName;
            this.IdentifyidentificationNumber = identificationNumber;
            this.UniqueID = uniqueID;
            this.IsVerify = isVerify;
            this.MailAddress = mailAddress;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Number = number;

            // User sınıfına ait özellikler
            this.Role = role;
            this.RegistrationDate = registrationDate;
        }
    }
}
