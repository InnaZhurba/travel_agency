using BLL_Order.DTO;

namespace BLL_Order.Interfaces
{
    public interface IOrderService
    {
        void MakeOrder(OrderDTO orderDTO);
        OrderDTO GetOrder(int? id);//RegionDTO GetRegion(int? id);//регион по id
        string[] GetOrders();//IEnumerable<RegionDTO> GetRegions();//все регионы
        void Dispose();
    }
}
