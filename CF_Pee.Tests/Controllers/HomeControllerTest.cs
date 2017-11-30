using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CF_Pee;
using CF_Pee.Controllers;

namespace CF_Pee.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disponer
            HomeController controller = new HomeController();

            // Actuar
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
