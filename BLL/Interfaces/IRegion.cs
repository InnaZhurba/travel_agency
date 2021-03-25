using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IRegionService
    {
        IEnumerable<RegionDTO> GetRegions();
        RegionDTO GetRegion(int? id);
        void Dispose();
    }
}
