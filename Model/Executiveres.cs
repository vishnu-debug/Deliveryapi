using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.Model
{
    public class Executiveres
    {
        [Key]
        public int ExrequestID { get; set; }
        public bool status { get; set; }
        public double Price { get; set; }
        [ForeignKey("Userreq"), Column(Order = 0)]
        public int? RequestID { get; set; }
        public Userreq Userreq { get; set; }
        public  int CustomerID { get; set; }
    }
}
