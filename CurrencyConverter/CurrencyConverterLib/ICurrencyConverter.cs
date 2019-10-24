using System.Collections.Generic;

namespace CurrencyConverterLib
{
    public interface ICurrencyConverter {
        public decimal CalculatePrice(string product, string targetCurrency, IEnumerable<Product> products, IEnumerable<Parity> parities);
    }
}