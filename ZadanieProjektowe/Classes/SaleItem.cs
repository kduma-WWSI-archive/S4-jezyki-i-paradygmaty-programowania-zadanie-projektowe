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
        public decimal Sum => Quanity*Price;
    }
}