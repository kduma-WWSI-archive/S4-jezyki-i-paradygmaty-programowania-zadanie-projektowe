using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ZadanieProjektowe.Classes
{
    public class Transaction
    {
        public BindingList<SaleItem> Items { get; } = new BindingList<SaleItem>();
        public decimal Sum => Items.Sum(item => item.Sum);

        public event Action<Transaction> Update;

        protected virtual void OnUpdate()
        {
            Update?.Invoke(this);
        }

        public Transaction()
        {
        }

        public void AddItem(Product product)
        {
            if (Items.Any() && Items.Last().Name == product.Name)
            {
                Items.Last().Quanity++;
                Items.ResetItem(Items.Count-1);
            }
            else
                Items.Add(new SaleItem(product));
            OnUpdate();
        }
    }
}