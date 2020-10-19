/*
 * Author: Stephanie Krass
 * Class: CashDrawerViewModelTests.cs
 * Purpose: Test the CashDrawerViewModel.cs class in the Point of Sale library
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using Xunit;
using System.ComponentModel;
using System.Collections;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class CashDrawerViewModelTests
    {
        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }
    }
}
