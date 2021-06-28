using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.Model
{
    public class Userreq
    {
        [Key]
        public int RequestID { get; set; }
        [Required]
        [Display(Name = "Date and Time of Pickup")]
        public DateTime DTofPickup { get; set; }
        [Required]
        [Display(Name = "Weight Of Package")]
        [Range(1, 10, ErrorMessage = "*Weight Below 1kg and Above 10kg are not Acceptable")]
        public double WeightOfPackage { get; set; }
        [MaxLength(length: 30, ErrorMessage = "*Only 30 characters allowed")]
        public string Address { get; set; }
        public int CityID { get; set; }
        [ForeignKey("Executive"), Column(Order = 0)]
        public int? ExecutiveID { get; set; }
        public Executive Executive { get; set; }
        [ForeignKey("Customer"), Column(Order = 1)]
        public int? CustomerID { get; set; }
        public Customer Customer{ get; set; }

    }
}
