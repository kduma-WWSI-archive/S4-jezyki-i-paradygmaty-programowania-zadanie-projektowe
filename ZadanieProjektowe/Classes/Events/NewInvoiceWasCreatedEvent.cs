namespace ZadanieProjektowe.Classes.Events
{
    public class NewInvoiceWasCreatedEvent
    {
        public Invoice Invoice;

        public NewInvoiceWasCreatedEvent(Invoice invoice)
        {
            Invoice = invoice;
        }
    }
}