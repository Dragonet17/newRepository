using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class City
    {

        public int CityID { get; set; }

        
        public int CountryID { get; set; }


        public string CityName { get; set; }

        
        public virtual Country Country { get; set; }
    }
}