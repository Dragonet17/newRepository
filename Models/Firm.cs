using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class Firm
    {
        public int FirmID { get; set; }

        public string FirmName { get; set; }

        public string Email { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public string NIP { get; set; }

        public string ContactNumber { get; set; }

        

    }
}