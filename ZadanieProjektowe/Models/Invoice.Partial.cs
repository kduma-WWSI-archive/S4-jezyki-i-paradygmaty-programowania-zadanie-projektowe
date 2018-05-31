// ReSharper disable once CheckNamespace

namespace ZadanieProjektowe.Models
{
    public partial class Invoice
    {
        public string CustomerName => Customer.Name;
    }
}