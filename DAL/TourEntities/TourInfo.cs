using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class TourInfo
    {
        public int Id { get; set; }
        public string Info { get; set; }
        
        public virtual Tour Tour { get; set; }
    }
}
