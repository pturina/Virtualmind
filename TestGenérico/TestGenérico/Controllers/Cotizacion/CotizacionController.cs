using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestGenérico.Controllers.Cotizacion;

namespace TestGenérico.Controllers.Cotizacion
{
    public class CotizacionController : ApiController
    {
        // GET: api/Cotizacion
        public IEnumerable<decimal> Get()
        {
            return new decimal[] { 1, 2 };
        }

        // GET: /api/cotizacion/?value=dolar
        public IHttpActionResult Get(string value)
        {
            try
            {
                IMoneda monedaSolicitada;

                switch (value)
                {
                    case "dolar":
                        monedaSolicitada = new Dolar();
                        break;
                    case "real":
                        monedaSolicitada = new Real();
                        break;
                    case "peso":
                        monedaSolicitada = new Peso();
                        break;
                    default:
                        return NotFound();
                        
                }

                decimal result = monedaSolicitada.GetCotizacion();
                
                if(result > 0)
                {
                    return this.Ok(new { Cotizacion = result});
                }
                else
                {
                    return NotFound();
                }
                

            }
            catch (Exception)
            {
                throw;
            }
            
        }

        // POST: api/Cotizacion
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cotizacion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cotizacion/5
        public void Delete(int id)
        {
        }
    }
}
