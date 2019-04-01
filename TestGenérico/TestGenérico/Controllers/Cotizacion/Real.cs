using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace TestGenérico.Controllers.Cotizacion
{
    public class Real :IMoneda
    {
        public decimal GetCotizacion()
        {
            return 0;             
        }
    }
}