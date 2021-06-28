using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.Model
{
    public class Customer
    {

        [Key]
        public int CustomerID { get; set; }
        [MaxLength(length: 20, ErrorMessage = "Only 20 characters allowed.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [MaxLength(length: 20, ErrorMessage = "*Only 20 characters allowed")]
        public string Name { get; set; }
        [StringLength(15,  MinimumLength = 8)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public int Age { get; set; }
        [MaxLength(length: 10, ErrorMessage = "*Only 10 numbers allowed")]
        [MinLength(length: 10, ErrorMessage = "*Must have 10 numbers")]
        public string Phone { get; set; }
        [MaxLength(length: 20, ErrorMessage = "*Only 20 characters allowed")]
        public string Address { get; set; }
        [MaxLength(length: 20, ErrorMessage = "*Only 20 characters allowed")]
        public string City { get; set; }
        public bool IsVerified { get; set; }
        public string Type { get; set; }

        public Customer ()
        {

        }
        public Customer(int id,string username,string name,string password,int age,string phone,string address,string city,bool isverified,string type)
        {
            CustomerID = id;
            UserName = username;
            Name = name;
           Password =password;
            Phone= Phone;
            Address = address;
            City = city;
            IsVerified = isverified;
            Type = type;
        }

    }
    
}
