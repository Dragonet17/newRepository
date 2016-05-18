using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class OrderForFirm
    {
        public int OrderForFirmID { get; set; }

        public int FirmID { get; set; }



        public virtual Firm Firm { get; set; }

        public virtual ICollection<Order> Orders {get;set;}
     }
}