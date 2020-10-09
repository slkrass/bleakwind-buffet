/*
 * Author: Stephanie Krass
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 */
using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void ShouldBeAnObservableCollection()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<ObservableCollection<IOrderItem>>(order);
        }

        [Fact]
        public void ShouldBeAnICollection()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(order);
        }

        [Fact]
        public void ShouldBeAnINofityCollectionChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
        }


    }
}
