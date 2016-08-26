using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BLL.DTO
{
    class NumberOrderDTO
    {
        public int NumberId { get; set; }
        public int Count { get; set; }
        public List<OrderDTO> orderColection { get; set; }
    }
}
