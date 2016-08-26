using NLayerApp.BLL.DTO;
using System.Collections.Generic;

namespace NLayerApp.BLL.Interfaces
{
    public interface INumberService
    {

        //NumberDTO GetAll();
       
        NumberDTO GetNumber(int? id);
        IEnumerable<NumberDTO> GetNumbers();
        void Dispose();
    }
}
