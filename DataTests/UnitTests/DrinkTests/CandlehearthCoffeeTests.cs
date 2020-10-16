/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(coffee);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(coffee);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.False(coffee.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.False(coffee.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.False(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.Equal(Size.Small, coffee.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Ice = true;
            Assert.True(coffee.Ice);
            coffee.Ice = false;
            Assert.False(coffee.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Decaf = true;
            Assert.True(coffee.Decaf);
            coffee.Decaf = false;
            Assert.False(coffee.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.RoomForCream = true;
            Assert.True(coffee.RoomForCream);
            coffee.RoomForCream = false;
            Assert.False(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Size = Size.Large;
            Assert.Equal(Size.Large, coffee.Size);
            coffee.Size = Size.Medium;
            Assert.Equal(Size.Medium, coffee.Size);
            coffee.Size = Size.Small;
            Assert.Equal(Size.Small, coffee.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75, "$0.75")]
        [InlineData(Size.Medium, 1.25, "$1.25")]
        [InlineData(Size.Large, 1.75, "$1.75")]
        public void ShouldHaveCorrectPriceForSize(Size size, double price, string strPrice)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Size = size;
            Assert.Equal(price, coffee.Price);
            Assert.Equal(strPrice, coffee.StringPrice);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Size = size;
            Assert.Equal(cal, coffee.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Ice = includeIce;
            coffee.RoomForCream = includeCream;

            if (includeIce && includeCream)
            {
                Assert.Contains("Add ice", coffee.SpecialInstructions);
                Assert.Contains("Add cream", coffee.SpecialInstructions);
            }
            else if (includeIce)
            {
                Assert.Contains("Add ice", coffee.SpecialInstructions);
            }
            else if (includeCream)
            {
                Assert.Contains("Add cream", coffee.SpecialInstructions);
            }
            else
            {
                Assert.Empty(coffee.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Decaf = decaf;
            coffee.Size = size;
            Assert.Equal(name, coffee.ToString());
            Assert.Equal(name, coffee.Name);
            
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeCaloriesANDPriceProperty(Size size)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.PropertyChanged(coffee, "Size", () => coffee.Size = size);
            Assert.PropertyChanged(coffee, "Calories", () => coffee.Size = size);
            Assert.PropertyChanged(coffee, "Price", () => coffee.Size = size);
            Assert.PropertyChanged(coffee, "Name", () => coffee.Size = size);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingIceNotifiesIceANDSpecialInstructionsProperty(bool ice)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.PropertyChanged(coffee, "Ice", () => coffee.Ice = ice);
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => coffee.Ice = ice);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingCreamNotifiesRoomForCreamANDSpecialInstructionsProperty(bool cream)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () => coffee.RoomForCream = cream);
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => coffee.RoomForCream = cream);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingDecafNotifiesDecafProperty(bool decaf)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () => coffee.Decaf = decaf);
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => coffee.Decaf = decaf);
        }
    }
}
