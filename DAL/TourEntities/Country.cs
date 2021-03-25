using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ListOfCountry ListOfCountry { get; set; }
    }
}
