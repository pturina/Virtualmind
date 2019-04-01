using System;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestGenérico.Controllers;
using TestGenérico.Controllers.Cotizacion;

namespace TestGenérico.Tests.Controllers
{
    [TestClass]
    public class CotizacionControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Disponer
            CotizacionController controller = new CotizacionController();

            // Actuar
            IHttpActionResult result = controller.Get("dolar");

            // Declarar
            Assert.IsNotNull(result);
           
        }
    }
}
