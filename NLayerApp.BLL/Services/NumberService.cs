using System;
using NLayerApp.BLL.DTO;
using NLayerApp.DAL.Repositories;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Interfaces;
using NLayerApp.BLL.Infrastructure;
using NLayerApp.BLL.Interfaces;
using System.Collections.Generic;
using AutoMapper;

namespace NLayerApp.BLL.Services
{   
    class NumberService:INumberService
    {
          IUnitOfWork Database { get; set; }
         public NumberService(IUnitOfWork uow)
        {
            Database = uow;
        }
      
         public IEnumerable<NumberDTO> GetNumbers()
         {
             // применяем автомаппер для проекции одной коллекции на другую
             Mapper.CreateMap<Number, NumberDTO>();
             return Mapper.Map<IEnumerable<Number>, List<NumberDTO>>(Database.Numbers.GetAll());
         }
         public NumberDTO GetNumber(int? id)
         {
             if (id == null)
                 throw new ValidationException("Не установлено id номера", "");
             var number = Database.Numbers.Get(id.Value);
             if (number == null)
                 throw new ValidationException("Номер не найден", "");
             // применяем автомаппер для проекции Phone на PhoneDTO
             Mapper.CreateMap<Number, NumberDTO>();
             return Mapper.Map<Number, NumberDTO>(number);
         }
         public void Dispose()
         {
             Database.Dispose();
         }
    }
}
