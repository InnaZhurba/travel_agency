using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class TourDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TourTypeId { get; set; }
        public int InfoId { get; set; }
    }
}
