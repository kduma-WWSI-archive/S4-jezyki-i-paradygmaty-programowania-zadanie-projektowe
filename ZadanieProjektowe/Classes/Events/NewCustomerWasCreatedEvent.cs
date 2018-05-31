using ZadanieProjektowe.Models;

namespace ZadanieProjektowe.Classes.Events
{
    public class NewCustomerWasCreatedEvent
    {
        public Customer Customer;

        public NewCustomerWasCreatedEvent(Customer customer)
        {
            Customer = customer;
        }
    }
}