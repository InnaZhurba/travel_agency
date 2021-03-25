using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITourService
    {
        void MakeTour(TourDTO tourDTO);
        void EditTour(TourDTO tourDTO);
        IEnumerable<TourDTO> GetTours();
        TourDTO GetTour(int? id);
        void Dispose();
    }
}
