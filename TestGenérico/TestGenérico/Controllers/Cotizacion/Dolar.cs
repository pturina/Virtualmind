using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace TestGenérico.Controllers.Cotizacion
{
    public class Dolar : IMoneda
    {
        public decimal GetCotizacion()
        {
            var x = RequestService();
            return x; // 45.23;
        }


        
        private decimal RequestService()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                var response = httpClient.GetStringAsync(new Uri("http://www.bancoprovincia.com.ar/Principal/Dolar")).Result;
                var respuesta = Newtonsoft.Json.Linq.JArray.Parse(response);
                return decimal.Parse(respuesta[0].ToString());
            }
        }

    }

}