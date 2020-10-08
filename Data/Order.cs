using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class that represents the order
    /// </summary>
    public class Order : ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public event PropertyChangedEventHandler PropertyChanged;


        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(IOrderItem item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// 
        /// </summary>
        public double Subtotal { get;}

        /// <summary>
        /// 
        /// </summary>
        public double Tax { get => Subtotal * SalesTaxRate; }

        /// <summary>
        /// 
        /// </summary>
        public double Total { get => Tax + Subtotal;}

        /// <summary>
        /// 
        /// </summary>
        public uint Calories { get; }


        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(IOrderItem item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
