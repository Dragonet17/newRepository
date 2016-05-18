using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class Hotel
    {
        public int HotelID { get; set; }

        public string HotelName { get; set; }
                
        public string Email { get; set; }

        public string PostCode { get; set; }

        public int CityID { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public string NIP { get; set; }

        public string ContactNumber { get; set; }

        public bool isOffice { get; set; }

        public virtual City City { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime DataStart { get; set; }

        public DateTime DataEnd { get; set; }

        public string FileName { get; set; }

        public int OrderID { get; set; }
        
        public virtual Order Order { get; set; }




    }
}