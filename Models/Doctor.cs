using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SaglıkOcagıRandevuSistemi.Classes
{
    public class Doctor : BaseU
    {
        // Doctor sınıfına özgü ek özellikler
        public string Department { get; set; }
        public string LicenseNumber { get; set; }

        // Doctor sınıfı için constructor
        public Doctor(int id, string name, string lastName, string identificationNumber, string uniqueID, bool isVerify, MailAddress mailAddress, DateTime birthDate, bool gender, string number, string department, string licenseNumber)
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

            // Doctor sınıfına ait özellikler
            this.Department = department;
            this.LicenseNumber = licenseNumber;
        }
    }
}
