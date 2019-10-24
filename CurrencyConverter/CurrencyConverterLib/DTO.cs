namespace CurrencyConverterLib
{
    public class Product {
        string description { get; }
        string currency { get; }
        decimal price { get; }

        public Product(string description, string currency, decimal price)
        {
            this.description = description;
            this.currency = currency;
            this.price = price;
        }
    }

    public class Parity {
        string currency { get; }
        decimal value { get; }

        public Parity(string currency, decimal value)
        {
            this.currency = currency;
            this.value = value;
        }
    }
}
