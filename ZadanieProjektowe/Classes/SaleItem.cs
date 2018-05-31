using ZadanieProjektowe.Models;

namespace ZadanieProjektowe.Classes
{
    public class SaleItem
    {
        public SaleItem(Product product)
        {
            this.Product = product;
            Quanity = 1;
        }

        public Product Product { get; set; }
        public string Name => this.Product.Name;
        public decimal Price => this.Product.Price;
        public int Quanity { get; set; }

        public string DetailedQuanity
        {
            get
            {
                if (Product.Quanity <= 0)
                    return $"0 ({Quanity}R)";

                if (Product.Quanity >= Quanity)
                    return $"{Quanity}";

                var rez = Quanity - Product.Quanity;
                return $"{Product.Quanity} ({rez}R)";

            }
        }

        public decimal Sum => Quanity*Price;
    }
}