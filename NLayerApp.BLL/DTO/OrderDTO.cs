using System;
using NLayerApp.DAL.Entities;

namespace NLayerApp.BLL.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int NumberId { get; set; }
        public DateTime? Date { get; set; }
    }
}
