using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ListOfCountry
    {
        //[Key]
        public int Id { get; set; }
        public int TourId { get; set; }
        public int CountryId { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<Tour> Tours { get; set; }

    }
}
