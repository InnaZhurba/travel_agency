using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tour.Models
{
    public class ListOfCountry
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int CountryId { get; set; }

    }
}
