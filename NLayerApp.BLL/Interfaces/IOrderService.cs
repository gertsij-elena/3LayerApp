using NLayerApp.BLL.DTO;
using System.Collections.Generic;
namespace NLayerApp.BLL.Interfaces
{
    public interface IOrderService
    {
        void MakeOrder(OrderDTO orderDto);
        NumberDTO GetNumber(int? id);
        IEnumerable<NumberDTO> GetNumbers();
        void Dispose();
    }
}
