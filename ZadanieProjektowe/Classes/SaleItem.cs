namespace ZadanieProjektowe.Classes
{
    public class SaleItem
    {
        public SaleItem(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Quanity = 1;
        }

        public SaleItem(string name, double price, int quanity)
        {
            Name = name;
            Price = price;
            Quanity = quanity;
        }

        public string Name { get; set; }
        public int Quanity { get; set; }
        public double Price { get; set; }
        public double Sum => Quanity*Price;
    }
}