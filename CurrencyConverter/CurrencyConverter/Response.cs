using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Response
    {
        public decimal Price;

        public Response(decimal price)
        {
            Price = price;
        }
    }
}