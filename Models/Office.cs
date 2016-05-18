using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class Office
    {

        public int OfficeID { get; set; }

        public string OfficeName { get; set; }

        public string Email { get; set; }

        public string PostCode { get; set; }

        public int CityID { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }
                
        public string ContactNumber { get; set; }

        

        public virtual City City { get; set; }

      
    }
}