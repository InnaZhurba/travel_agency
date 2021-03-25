using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
    }
}
