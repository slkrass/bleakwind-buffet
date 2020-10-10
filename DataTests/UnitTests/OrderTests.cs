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
using BleakwindBuffet.Data.Enums;
using System.Collections;


namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void NumberShouldIncrementByOneForTheNextOrder()
        {
            Order order = new Order();
            Order order2 = new Order();
            Assert.Equal((order.Number + 1), order2.Number);
        }

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

        [Fact]
        public void SalesTaxRateShouldBeSetToDefault()
        {
            Order order = new Order();
            Assert.Equal(0.12, order.SalesTaxRate);
            
        }

        [Fact]
        public void SalesTaxRateShouldBeAbleToBeChanged()
        {
            Order order = new Order();
            double rate = 0.13;
            order.SalesTaxRate = rate;
            Assert.Equal(rate, order.SalesTaxRate);
            Assert.PropertyChanged(order, "SalesTaxRate", () => order.SalesTaxRate = 0.14);
            Assert.PropertyChanged(order, "Tax", () => order.SalesTaxRate = 0.14);
            Assert.PropertyChanged(order, "Total", () => order.SalesTaxRate = 0.14);
            Assert.PropertyChanged(order, "Subtotal", () => order.SalesTaxRate = 0.14);
        }

        [Fact]
        public void CaloriesSubtotalTotalAndTaxShouldBeZeroByDefault()
        {
            Order order = new Order();
            string num = "$0.00";
            uint cal = 0;
            Assert.Equal(cal, order.Calories);
            Assert.Equal(0, order.Subtotal);
            Assert.Equal(num, order.StringSubtotal);
            Assert.Equal(0, order.Total);
            Assert.Equal(num, order.StringTotal);
            Assert.Equal(0, order.Tax);
            Assert.Equal(num, order.StringTax);
        }

        [Fact]
        public void AddingItemsShouldCauseCollectionChanged()
        {
            Order order = new Order();
            VokunSalad vs = new VokunSalad();
            BriarheartBurger burger = new BriarheartBurger();
            SailorSoda soda = new SailorSoda();

            order.Add(burger);
            order.Add(soda);

            Assert.PropertyChanged(order, "Calories", () => order.Add(vs));
            Assert.PropertyChanged(order, "Subtotal", () => order.Add(vs));
            Assert.PropertyChanged(order, "Tax", () => order.Add(vs));
            Assert.PropertyChanged(order, "Total", () => order.Add(vs));
            Assert.PropertyChanged(order, "StringSubtotal", () => order.Add(vs));
            Assert.PropertyChanged(order, "StringTax", () => order.Add(vs));
            Assert.PropertyChanged(order, "StringTotal", () => order.Add(vs));
        }

        [Fact]
        public void AddingingingItemsShouldUpdate_Subtotal_Tax_Total_Calories()
        {
            Order order = new Order();
            VokunSalad vs = new VokunSalad();
            BriarheartBurger burger = new BriarheartBurger();
            SailorSoda soda = new SailorSoda();

            Assert.Equal(0, order.Subtotal);
            Assert.Equal(0, order.Total);
            Assert.Equal(0, order.Tax);
            Assert.Equal((uint) 0, order.Calories);

            order.Add(vs);
            order.Add(burger);
            order.Add(soda);

            double sub = soda.Price + burger.Price + vs.Price;
            double tax = sub * order.SalesTaxRate;
            double total = sub + tax;
            uint cal = soda.Calories + burger.Calories + vs.Calories;

            Assert.Equal(sub, order.Subtotal);
            Assert.Equal(total, order.Total); ;
            Assert.Equal(tax, order.Tax);
            Assert.Equal(cal, order.Calories);
        }

        [Fact]
        public void RemovingItemsShouldCauseCollectionChanged()
        {
            Order order = new Order();
            VokunSalad vs = new VokunSalad();
            BriarheartBurger burger = new BriarheartBurger();
            SailorSoda soda = new SailorSoda();

            order.Add(vs);
            order.Add(burger);
            order.Add(soda);

            Assert.PropertyChanged(order, "Calories", () => order.Remove(vs));
            order.Add(vs);
            Assert.PropertyChanged(order, "Subtotal", () => order.Remove(vs));
            order.Add(vs);
            Assert.PropertyChanged(order, "Tax", () => order.Remove(vs));
            order.Add(vs);
            Assert.PropertyChanged(order, "Total", () => order.Remove(vs));
            order.Add(vs);
            Assert.PropertyChanged(order, "StringSubtotal", () => order.Remove(vs));
            order.Add(vs);
            Assert.PropertyChanged(order, "StringTax", () => order.Remove(vs));
            order.Add(vs);
            Assert.PropertyChanged(order, "StringTotal", () => order.Remove(vs));

        }

        [Fact]
        public void RemovingingItemsShouldUpdate_Subtotal_Tax_Total_Calories()
        {
            Order order = new Order();
            VokunSalad vs = new VokunSalad();
            BriarheartBurger burger = new BriarheartBurger();
            SailorSoda soda = new SailorSoda();
                      
            order.Add(vs);
            order.Add(burger);
            order.Add(soda);

            double sub = soda.Price + burger.Price + vs.Price;
            double tax = sub * order.SalesTaxRate;
            double total = sub + tax;
            uint cal = soda.Calories + burger.Calories + vs.Calories;

            Assert.Equal(sub, order.Subtotal);
            Assert.Equal(total, order.Total); ;
            Assert.Equal(tax, order.Tax);
            Assert.Equal(cal, order.Calories);

            order.Remove(vs);
            order.Remove(burger);
            order.Remove(soda);

            Assert.Equal(0, order.Subtotal);
            Assert.Equal(0, order.Total);
            Assert.Equal(0, order.Tax);
            Assert.Equal((uint)0, order.Calories);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldBeAbleToChangeTheSizeOfItemsInTheOrder(Size size)
        {
            Order order = new Order();

            VokunSalad vs = new VokunSalad();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            FriedMiraak fm = new FriedMiraak();
            MadOtarGrits mog = new MadOtarGrits();

            SailorSoda soda = new SailorSoda();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            MarkarthMilk mm = new MarkarthMilk();
            WarriorWater ww = new WarriorWater();

            order.Add(vs);
            order.Add(dwf);
            order.Add(fm);
            order.Add(mog);

            order.Add(soda);
            order.Add(aj);
            order.Add(mm);
            order.Add(cc);
            order.Add(ww);

            foreach(IOrderItem item in order)
            {
                if (item is Side side)
                {
                    Assert.PropertyChanged(order, "Calories", () => side.Size = size);
                    Assert.PropertyChanged(order, "Subtotal", () => side.Size = size);
                    Assert.PropertyChanged(order, "Tax", () => side.Size = size);
                    Assert.PropertyChanged(order, "Total", () => side.Size = size);
                    Assert.PropertyChanged(order, "StringSubtotal", () => side.Size = size);
                    Assert.PropertyChanged(order, "StringTax", () => side.Size = size);
                    Assert.PropertyChanged(order, "StringTotal", () => side.Size = size);
                }
                else if(item is Drink drink)
                { 
                    Assert.PropertyChanged(order, "Calories", () => drink.Size = size);
                    Assert.PropertyChanged(order, "Subtotal", () => drink.Size = size);
                    Assert.PropertyChanged(order, "Tax", () => drink.Size = size);
                    Assert.PropertyChanged(order, "Total", () => drink.Size = size);
                    Assert.PropertyChanged(order, "StringSubtotal", () => drink.Size = size);
                    Assert.PropertyChanged(order, "StringTax", () => drink.Size = size);
                    Assert.PropertyChanged(order, "StringTotal", () => drink.Size = size);
                }

                    
            }

            order.Remove(vs);
            order.Remove(dwf);
            order.Remove(fm);
            order.Remove(mog);

            order.Remove(soda);
            order.Remove(aj);
            order.Remove(mm);
            order.Remove(cc);
            order.Remove(ww);

        }

    }
}
