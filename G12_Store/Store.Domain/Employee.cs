using System;

namespace Store.Domain
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string CurrentAddress { get; set; }
        public string LegalAddress { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string IdNumber { get; set; }
        public string IdCardNumber { get; set; }
        public DateTime DateRegister { get; set; }
        public bool IsDeleted { get; set; }
    }
}
