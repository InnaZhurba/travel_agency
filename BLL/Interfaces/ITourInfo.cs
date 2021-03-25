using System;
using BLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
   public interface ITourInfoService
    {
        void MakeInfo(TourInfoDTO data);//(TourInfoDTO tourInfoDTO);
        IEnumerable<TourInfoDTO> GetTourInfos();
        TourInfoDTO GetTourInfo(int? id);
        void Dispose();
    }
}
