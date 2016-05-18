using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class Country
    {

        public int CountryID { get; set; }

        public string CountryName { get; set; }


        public virtual ICollection<City> Citys { get; set; }

        
    }
}