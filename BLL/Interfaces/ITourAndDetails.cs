using BLL.DTO;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface ITourAndDetailsService
    {
        IEnumerable<TourAndDetailsDTO> Get();
        TourAndDetailsDTO GetId(int? id);
    }
}
