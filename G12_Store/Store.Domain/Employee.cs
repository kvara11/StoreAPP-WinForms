using System;
using System.ComponentModel.DataAnnotations;

namespace Store.Domain
{    
    public class Employee
    {
        public int ID { get; set; }

        [MaxLength(15, ErrorMessage = "Max length for First Name: 15 ")]
        [Required]
        [RegularExpression("[A-Za-z]*", ErrorMessage = "FirstName: Only chars allowed")]
        public string FirstName { get; set; }

        [MaxLength(15, ErrorMessage = "Max length for Last Name: 15 ")]
        [Required]
        [RegularExpression("[A-Za-z]*", ErrorMessage = "LastName: Only chars allowed")]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Max lenght for phone: 10")]
        [RegularExpression("[0-9]*", ErrorMessage = "Phone: only numbers allowed")]
        public string Phone { get; set; }

        [MaxLength(10, ErrorMessage ="Max lenght for phone: 10")]
        [RegularExpression("[0-9]*", ErrorMessage = "Phone2: Only numbers allowed")]
        public string Phone2 { get; set; }

        [MaxLength(50, ErrorMessage = "Max lenght for address: 50")]
        [Required]
        public string CurrentAddress { get; set; }

        [MaxLength(50, ErrorMessage = "Max lenght for address: 50")]
        public string LegalAddress { get; set; }

        [MaxLength(6, ErrorMessage ="Max length for postal code: 6")]
        [RegularExpression("[0-9]*", ErrorMessage = "PostalCode: only numbers allowed")]
        public string PostalCode { get; set; }

        [MaxLength(25, ErrorMessage ="Max Length for email: 25")] 
        [EmailAddress(ErrorMessage ="Incorrect email format")]
        public string Email { get; set; }

        [MaxLength(11, ErrorMessage = "Max Length for IdNumber: 11")]
        [Required]
        [RegularExpression("[0-9]*", ErrorMessage = "IdNumber: Only numbers allowed")]
        public string IdNumber { get; set; }

        [MaxLength(11, ErrorMessage = "Max Length for IdCardNumber: 11")]
        [Required]
        public string IdCardNumber { get; set; }

        public DateTime DateRegister { get; set; }

        public bool IsDeleted { get; set; }

    }
}
