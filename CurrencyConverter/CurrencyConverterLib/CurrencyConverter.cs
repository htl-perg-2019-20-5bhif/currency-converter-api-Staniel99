using System;
using System.Collections.Generic;

namespace CurrencyConverterLib
{
    public class CurrencyConverter : ICurrencyConverter {
        public decimal CalculatePrice(string product, string targetCurrency, IEnumerable<Product> products, IEnumerable<Parity> parities)
        {
            throw new NotImplementedException();
        }
    }
}
