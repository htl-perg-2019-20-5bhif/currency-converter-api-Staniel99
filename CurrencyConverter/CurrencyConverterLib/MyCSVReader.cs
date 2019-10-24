using CurrencyConverterLib;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CurrencyConverterLib
{
    public class MyCSVReader : IMyCSVReader {

        public IEnumerable<Parity> ParseParities(string data) {

            List<string[]> entries = Parse(data);
            List<Parity> parities = new List<Parity>();

            foreach (string[] entry in entries) {
                parities.Add(new Parity(entry[0], decimal.Parse(entry[1], CultureInfo.InvariantCulture)));
            }

            return parities;
        }

        public IEnumerable<Product> ParseProducts(string data) {

            List<string[]> entries = Parse(data);
            List<Product> products = new List<Product>();

            foreach(string[] entry in entries) {
                products.Add(new Product(entry[0], entry[1], decimal.Parse(entry[2], CultureInfo.InvariantCulture)));
            }

            return products;
        }

        private List<string[]> Parse(string data)
        {
            List<string[]> entries = new List<string[]>();
            string[] lines = data.Replace("\r", string.Empty).Split("\n");
            for(int i=1; i<lines.Length; i++) {
                    string[] entry = lines[i].Split(",");
                    if (entry.Length > 1)
                        entries.Add(entry);
            }
            return entries;
        }
    }
}
