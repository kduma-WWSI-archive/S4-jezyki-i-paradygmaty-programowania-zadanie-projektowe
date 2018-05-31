using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieProjektowe.Models
{
    public partial class InvoicesPosition
    {
        public string ProductStr => Product.Name;
        public string Barcode => Product.Barcode;
        public decimal Sum => Quanity * Price;
    }
}
