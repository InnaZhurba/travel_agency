using System;
using System.Collections.Generic;
using System.Text;

namespace UI_Tour.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TourTypeId { get; set; }
        public int ListOfCountryId { get; set; }
        public int InfoId { get; set; }
    }
}
