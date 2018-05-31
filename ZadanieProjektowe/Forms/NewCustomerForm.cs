using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PubSub;
using ZadanieProjektowe.Classes.Events;

namespace ZadanieProjektowe.Forms
{
    public partial class NewCustomerForm : Form
    {
        public event Action<Customer> Save;

        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = NameField.Text;
            var vatid = VatIDField.Text;
            var postalcode = PostalCodeField.Text;
            var city = CityField.Text;
            var street = StreetField.Text;

            if (name.Length == 0 || vatid.Length == 0 || postalcode.Length == 0 || city.Length == 0 ||
                street.Length == 0)
            {
                MessageBox.Show("Wszystkie pola sa wymagane!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var db = new Entities();
            var c = new Customer
            {
                Name = name,
                Address = $"{city}\n{postalcode}\n{street}",
                VatID = vatid
            };
            db.Customers.Add(c);
            db.SaveChanges();

            OnSave(c);

            Close();
        }

        protected virtual void OnSave(Customer obj)
        {
            Save?.Invoke(obj);
            this.Publish(new NewCustomerWasCreatedEvent(obj));
        }
    }
}
