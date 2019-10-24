using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CurrencyConverterLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CurrencyConverter.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class CurrencyConverterControler : ControllerBase {

        private readonly HttpClient client;
        private readonly IMyCSVReader reader;
        private readonly ICurrencyConverter converter;

        public CurrencyConverterControler(IHttpClientFactory factory, IMyCSVReader reader, ICurrencyConverter converter) {

            this.client = factory.CreateClient("CurrencyDataAPI");
            this.reader = reader;
            this.converter = converter;
        }

        [HttpGet]
        [Route("{product}/price")]
        public async Task<IActionResult> Get(string product, [FromQuery]string targetCurrency) {

            HttpResponseMessage responseProducts = await client.GetAsync("Prices.csv");
            responseProducts.EnsureSuccessStatusCode();

            HttpResponseMessage responseParities = await client.GetAsync("ExchangeRates.csv");
            responseParities.EnsureSuccessStatusCode();

            string productsString = await responseProducts.Content.ReadAsStringAsync();
            string paritiesString = await responseParities.Content.ReadAsStringAsync();

            IEnumerable<Product> products = reader.ParseProducts(productsString);
            IEnumerable<Parity> parities = reader.ParseParities(paritiesString);

            decimal price = converter.CalculatePrice(product, targetCurrency, products, parities);

            return Ok(new Response(price));
        }
    }
}
