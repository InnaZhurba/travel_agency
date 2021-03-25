using System;
using BLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IListOCService
    {
        void MakeList(ListOfCountryDTO listOC);
        ListOfCountryDTO GetListOC(string id);
        ListOfCountryDTO GetListOC(int? id);
        void EditListOC(ListOfCountryDTO Vary);
        IEnumerable<ListOfCountryDTO> GetListOC();
        void Dispose();
    }
}
