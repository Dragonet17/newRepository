using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public string Description { get; set; }

        public bool withOffice { get; set; }

        public int HotelID { get; set; }

        

        public virtual Hotel Hotel { get; set; }

        
    }
}