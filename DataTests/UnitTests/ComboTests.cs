/*
 * Author: Stephanie Krass
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using Xunit;
using System.ComponentModel;
using System.Collections;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
        }

    }

}
