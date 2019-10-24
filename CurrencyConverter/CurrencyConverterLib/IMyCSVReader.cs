using CurrencyConverterLib;
using System.Collections.Generic;

namespace CurrencyConverterLib
{
    public interface IMyCSVReader {
        public IEnumerable<Product> ParseProducts(string data);
        public IEnumerable<Parity> ParseParities(string data);
    }
}
