using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ZadanieProjektowe.Classes
{
    public class Transaction
    {
        private BindingList<SaleItem> _items = new BindingList<SaleItem>();
        public BindingList<SaleItem> Items => _items;
        public double Sum => _items.Sum(item => item.Sum);

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
            if (_items.Any() && _items.Last().Name == product.Name)
            {
                _items.Last().Quanity++;
                _items.ResetItem(_items.Count-1);
            }
            else
                _items.Add(new SaleItem(product));
            OnUpdate();
        }
    }
}