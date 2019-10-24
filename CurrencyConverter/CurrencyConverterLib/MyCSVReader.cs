using CurrencyConverterLib;
using System;
using System.Collections.Generic;

namespace CurrencyConverterLib
{
    public class MyCSVReader : IMyCSVReader {

        public IEnumerable<Parity> ParseParities(string data) {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ParseProducts(string data) {
            throw new NotImplementedException();
        }
    }
}
