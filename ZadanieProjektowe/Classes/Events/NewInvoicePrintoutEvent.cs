using System.Collections.Generic;
using ZadanieProjektowe.Models;

namespace ZadanieProjektowe.Classes.Events
{ 
    public class NewInvoicePrintoutEvent : NewPrintoutEvent
    {
        private readonly Invoice _invoice;

        public NewInvoicePrintoutEvent(Invoice invoice) => _invoice = invoice;

        public override List<byte> GetPrintout()
        {
            _appendBytes(0x1B, 64); //ESC "@"
            _appendBytes(0x1B, 51, 18); //ESC "3" 18
            _appendBytes(0x1B, 97, 1); //ESC "a" 1
            _appendBytes(0x1d, 33, 0x11); // GS "!" 0x11
            _appendBytes(0xC9, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xBB, 0x0a);
            _appendBytes(0xBA, 0x20, 0x20, 0x20);
            _appendString("SKLEP");
            _appendBytes(0x20, 0x20, 0x20, 0xBA, 0x0a);
            _appendBytes(0xBA, 0x20, 0x20, 0x20);
            _appendBytes(0x1d, 33, 0x00);
            _appendString(" Faktura! ");
            _appendBytes(0x1d, 33, 0x11);
            _appendBytes(0x20, 0x20, 0x20, 0xBA, 0x0a);
            _appendBytes(0xC8, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xBC, 0x0a);


            _appendBytes(0x1B, 50); // ESC "2"
            _appendBytes(0x1d, 33, 0x00); // GS "!" 0x00


            _appendBytes(0x1B, 74, 4); // ESC "J" 4
            _appendString(_invoice.Date.ToString() + "\n Numer: " + _invoice.Id);
            _appendBytes(0x1B, 100, 3); // ESC "d" 3


            _appendBytes(0x1B, 97, 0); //ESC "a" 0
            _appendBytes(0x1d, 33, 0x01); // GS "!" 0x01
            _appendString("Nabywca: " + _invoice.Customer.Name + "\n");
            _appendBytes(0x1d, 33, 0x00); // GS "!" 0x00
            _appendString("VAT-ID: " + _invoice.Customer.VatID + "\n");
            _appendString(_invoice.Customer.Address + "\n");

            _appendBytes(0x1B, 100, 3); // ESC "d" 3
            foreach (var position in _invoice.InvoicesPositions)
            {
                _appendString(position.Product.Name + "\n");
                _appendString(position.Quanity + " * " + position.Price + " PLN = " + (position.Quanity * position.Price) + " PLN\n\n");
            }


            _appendBytes(0x1d, 33, 0x01); // GS "!" 0x01
            _appendString("Suma: "+_invoice.Amount + " PLN\n");
            _appendBytes(0x1d, 33, 0x00); // GS "!" 0x00


            _appendBytes(0x0a);
            _appendBytes(0x1d, 86, 66, 5);

            return base.GetPrintout();
        }
    }
}