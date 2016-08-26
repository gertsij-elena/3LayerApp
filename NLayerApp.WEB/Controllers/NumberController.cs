using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLayerApp.BLL.Interfaces;
using NLayerApp.BLL.DTO;
using NLayerApp.WEB.Models;
using AutoMapper;
using NLayerApp.BLL.Infrastructure;

namespace NLayerApp.WEB.Controllers
{
    public class NumberController : Controller
    {
        INumberService numberservice;
         public NumberController(INumberService  serv)
        {
            numberservice = serv;
        }

        public ActionResult GetNumber()
        {
            Mapper.CreateMap<NumberDTO, NumberViewModel>();
            var numbers = Mapper.Map<IEnumerable<NumberDTO>, List<NumberViewModel>>(numberservice.GetNumbers());
            return View(numbers);
        }
    }
}