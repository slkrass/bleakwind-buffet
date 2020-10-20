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
using BleakwindBuffet.PointOfSale;
using Xunit.Sdk;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class CashDrawerViewModelTests
    {
        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        { 
            CashDrawerViewModel cashDrawer = new CashDrawerViewModel();
            cashDrawer.ResetDrawer();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cashDrawer);
        }

        [Fact]
        public void Defaults_Should_Be_Zero_For_Cost_PaidCurrency_And_ChangeCurrency()
        {
            CashDrawerViewModel cashDrawer = new CashDrawerViewModel();
            cashDrawer.ResetDrawer();
            Assert.Equal(0, cashDrawer.CurrentPayment);
            Assert.Equal(0, cashDrawer.CurrentChangeDue);
            Assert.Equal(0, cashDrawer.AmountDue);
            Assert.Equal(0, cashDrawer.PaidPennies);
            Assert.Equal(0, cashDrawer.PaidNickels);
            Assert.Equal(0, cashDrawer.PaidDimes);
            Assert.Equal(0, cashDrawer.PaidQuarters);
            Assert.Equal(0, cashDrawer.PaidHalfDollars);
            Assert.Equal(0, cashDrawer.PaidDollars);
            Assert.Equal(0, cashDrawer.PaidOnes);
            Assert.Equal(0, cashDrawer.PaidTwos);
            Assert.Equal(0, cashDrawer.PaidFives);
            Assert.Equal(0, cashDrawer.PaidTens);
            Assert.Equal(0, cashDrawer.PaidTwenties);
            Assert.Equal(0, cashDrawer.PaidFifties);
            Assert.Equal(0, cashDrawer.PaidHundreds);
            Assert.Equal(0, cashDrawer.ChangePennies);
            Assert.Equal(0, cashDrawer.ChangeNickels);
            Assert.Equal(0, cashDrawer.ChangeDimes);
            Assert.Equal(0, cashDrawer.ChangeQuarters);
            Assert.Equal(0, cashDrawer.ChangeHalfDollars);
            Assert.Equal(0, cashDrawer.ChangeDollars);
            Assert.Equal(0, cashDrawer.ChangeOnes);
            Assert.Equal(0, cashDrawer.ChangeTwos);
            Assert.Equal(0, cashDrawer.ChangeFives);
            Assert.Equal(0, cashDrawer.ChangeTens);
            Assert.Equal(0, cashDrawer.ChangeTwenties);
            Assert.Equal(0, cashDrawer.ChangeFifties);
            Assert.Equal(0, cashDrawer.ChangeHundreds);
            Assert.Equal(474, cashDrawer.Total);
        }

        [Fact]
        public void Defaults_Should_Be_Zero_or_True_For_OrderCost_and_SufficientPayment()
        {
            CashDrawerViewModel cashDrawer = new CashDrawerViewModel();
            cashDrawer.ResetDrawer();
            Assert.Equal(0, cashDrawer.OrderCost);
            Assert.True(cashDrawer.SufficientPayment);
            cashDrawer.OrderCost = 1;
            Assert.Equal(1, cashDrawer.OrderCost);
            Assert.False(cashDrawer.SufficientPayment);
        }

        [Fact]
        public void CashDrawerShouldCalculateChange_WithSufficientPayment()
        {
            CashDrawerViewModel cashDrawer = new CashDrawerViewModel();
            cashDrawer.ResetDrawer();
            cashDrawer.OpenDrawer();
            cashDrawer.PaidHundreds = 1;
            cashDrawer.OrderCost = 75.23;
            cashDrawer.CalculateChange();
            Assert.Equal(1, cashDrawer.ChangeTwenties);
            Assert.Equal(2, cashDrawer.ChangeTwos);
            Assert.Equal(1, cashDrawer.ChangeHalfDollars);
            Assert.Equal(1, cashDrawer.ChangeQuarters);
            Assert.Equal(2, cashDrawer.ChangePennies);
            Assert.Equal((75.23 -100), cashDrawer.AmountDue);
            Assert.Equal(Math.Round((100 - 75.23),2), cashDrawer.CurrentChangeDue);
            cashDrawer.CurrentChangeDue = 2;
            Assert.Equal(Math.Round(2.00, 2), cashDrawer.CurrentChangeDue);
        }

        [Fact]
        public void CashDrawerShouldCalculateChange_WithoutSufficientPayment()
        {
            CashDrawerViewModel cashDrawer = new CashDrawerViewModel();
            cashDrawer.ResetDrawer();
            cashDrawer.OpenDrawer();
            cashDrawer.PaidFifties = 1;
            cashDrawer.PaidTwenties = 1;
            cashDrawer.PaidTens = 3;
            cashDrawer.PaidFives = 1;
            cashDrawer.PaidTwos = 1;
            cashDrawer.PaidOnes = 1;
            cashDrawer.PaidDollars = 1;
            cashDrawer.PaidHalfDollars = 1;
            cashDrawer.PaidQuarters = 1;
            cashDrawer.PaidDimes = 1;
            cashDrawer.PaidNickels = 1;
            cashDrawer.PaidPennies = 1;
            cashDrawer.OrderCost = 175.23;
            cashDrawer.CalculateChange();
            Assert.Equal(0, cashDrawer.CurrentChangeDue);
            Assert.Equal(3, cashDrawer.PaidTens);
            Assert.Equal(0, cashDrawer.ChangePennies);
            Assert.Equal(0, cashDrawer.ChangeNickels);
            Assert.Equal(0, cashDrawer.ChangeDimes);
            Assert.Equal(0, cashDrawer.ChangeQuarters);
            Assert.Equal(0, cashDrawer.ChangeHalfDollars);
            Assert.Equal(0, cashDrawer.ChangeDollars);
            Assert.Equal(0, cashDrawer.ChangeOnes);
            Assert.Equal(0, cashDrawer.ChangeTwos);
            Assert.Equal(0, cashDrawer.ChangeFives);
            Assert.Equal(0, cashDrawer.ChangeTens);
            Assert.Equal(0, cashDrawer.ChangeTwenties);
            Assert.Equal(0, cashDrawer.ChangeFifties);
            Assert.Equal(0, cashDrawer.ChangeHundreds);
        }
        
        [Theory]
        [InlineData("CurrentPayment")]
        [InlineData("SufficientPayment")]
        [InlineData("AmountDue")]
        public void UpdatingPaidCurrencyNotifiesCurrentPaymentSufficientPaymentANDAmountDue(string prop)
        {
            CashDrawerViewModel cashDrawer = new CashDrawerViewModel();
            cashDrawer.ResetDrawer();
            Assert.PropertyChanged(cashDrawer, "PaidPennies", () => cashDrawer.PaidPennies = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidPennies = 1);

            Assert.PropertyChanged(cashDrawer, "PaidNickels", () => cashDrawer.PaidNickels = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidNickels = 1);

            Assert.PropertyChanged(cashDrawer, "PaidDimes", () => cashDrawer.PaidDimes = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidDimes = 1);

            Assert.PropertyChanged(cashDrawer, "PaidQuarters", () => cashDrawer.PaidQuarters = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidQuarters = 1);

            Assert.PropertyChanged(cashDrawer, "PaidHalfDollars", () => cashDrawer.PaidHalfDollars = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidHalfDollars = 1);

            Assert.PropertyChanged(cashDrawer, "PaidDollars", () => cashDrawer.PaidDollars = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidDollars = 1);

            Assert.PropertyChanged(cashDrawer, "PaidOnes", () => cashDrawer.PaidOnes = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidOnes = 1);

            Assert.PropertyChanged(cashDrawer, "PaidTwos", () => cashDrawer.PaidTwos = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidTwos = 1);

            Assert.PropertyChanged(cashDrawer, "PaidFives", () => cashDrawer.PaidFives = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidPennies = 1);

            Assert.PropertyChanged(cashDrawer, "PaidTens", () => cashDrawer.PaidTens = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidTens = 1);

            Assert.PropertyChanged(cashDrawer, "PaidTwenties", () => cashDrawer.PaidTwenties = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidTwenties = 1);

            Assert.PropertyChanged(cashDrawer, "PaidFifties", () => cashDrawer.PaidFifties = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidFifties = 1);

            Assert.PropertyChanged(cashDrawer, "PaidHundreds", () => cashDrawer.PaidHundreds = 1);
            Assert.PropertyChanged(cashDrawer, prop, () => cashDrawer.PaidHundreds = 1);

        }

        [Fact]
        public void FinalizingASaleShouldUpdateQuantitiesInRegister()
        {
            CashDrawerViewModel cashDrawer = new CashDrawerViewModel();
            cashDrawer.ResetDrawer();

            cashDrawer.OrderCost = 6.50;
            cashDrawer.PaidTwenties = 1;
            cashDrawer.CalculateChange();
            Assert.Equal(1, cashDrawer.ChangeOnes);
            Assert.Equal(1, cashDrawer.ChangeTwos);
            Assert.Equal(1, cashDrawer.ChangeTens);
            Assert.Equal(1, cashDrawer.ChangeHalfDollars);

            int pennies = cashDrawer.Pennies;
            int nickels = cashDrawer.Nickels;
            int dimes = cashDrawer.Dimes;
            int quarters = cashDrawer.Quarters;
            int halfDollars = cashDrawer.HalfDollars;
            int dollars = cashDrawer.Dollars;

            int ones = cashDrawer.Ones;
            int twos = cashDrawer.Twos;
            int fives = cashDrawer.Fives;
            int tens = cashDrawer.Tens;
            int twenties = cashDrawer.Twenties;
            int fifties = cashDrawer.Fifties;
            int hundreds = cashDrawer.Hundreds;

            cashDrawer.FinializeSale();
            Assert.Equal(pennies, cashDrawer.Pennies);
            Assert.Equal(nickels, cashDrawer.Nickels);
            Assert.Equal(dimes, cashDrawer.Dimes);
            Assert.Equal(quarters, cashDrawer.Quarters);
            Assert.Equal((halfDollars - cashDrawer.ChangeHalfDollars), cashDrawer.HalfDollars);
            Assert.Equal(dollars, cashDrawer.Dollars);
            Assert.Equal(ones - cashDrawer.ChangeOnes, cashDrawer.Ones);
            Assert.Equal(twos - cashDrawer.ChangeTwos, cashDrawer.Twos);
            Assert.Equal(fives, cashDrawer.Fives);
            Assert.Equal(tens - cashDrawer.ChangeTens, cashDrawer.Tens);
            Assert.Equal(twenties + cashDrawer.PaidTwenties, cashDrawer.Twenties);
            Assert.Equal(fifties, cashDrawer.Fifties);
            Assert.Equal(hundreds, cashDrawer.Hundreds);

        }

    }
}
