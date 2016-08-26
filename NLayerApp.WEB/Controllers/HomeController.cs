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
    public class HomeController : Controller
    {
        IOrderService orderService;
        public HomeController(IOrderService serv)
        {
            orderService = serv;
        }
        public HomeController()
        {
           
        }
        public ActionResult Index()
        {
            Mapper.CreateMap<NumberDTO, NumberViewModel>();
            var numbers = Mapper.Map<IEnumerable<NumberDTO>, List<NumberViewModel>>(orderService.GetNumbers());
            return View(numbers);
        }

        public ActionResult MakeOrder(int? id)
        {
            try
            {
                Mapper.CreateMap<NumberDTO, OrderViewModel>()
                    .ForMember("NumberId", opt => opt.MapFrom(src => src.NumberId));
                var order = Mapper.Map<NumberDTO, OrderViewModel>(orderService.GetNumber(id));
                return View(order);
            }
            catch(ValidationException ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult MakeOrder(OrderViewModel order)
        {
            try
            {
                Mapper.CreateMap<OrderViewModel,OrderDTO>();
                var orderDto = Mapper.Map<OrderViewModel, OrderDTO>(order);
                orderService.MakeOrder(orderDto);
                //RedirectToAction("Index", "Home");
                return Content("<h2>Ваш заказ успешно оформлен</h2>");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }
           
            //return View(order);
            return RedirectToAction("Index", "Home");
        }
        protected override void Dispose(bool disposing)
        {
            orderService.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult About() 
        {
            return View("About");
        }
        public ActionResult Contact()
        {
            return View("Contact");
        }
    }
}