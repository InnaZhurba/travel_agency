using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TourTypeId { get; set; }
        public int InfoId { get; set; }

        public virtual ListOfCountry ListOfCountry { get; set; }
        public virtual ICollection<TourType> TourTypes { get; set; }
        public virtual ICollection<TourInfo> TourInfos { get; set; }
    }
}
