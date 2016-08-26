using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using NLayerApp.WEB.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Index()
        {
            HomeController homecontroller = new HomeController();
            ViewResult result = homecontroller.Index() as ViewResult;
        }
    }
}
