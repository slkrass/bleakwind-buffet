/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(fries);
        }

        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(fries);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, fries.Size);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = Size.Large;
            Assert.Equal(Size.Large, fries.Size);
            fries.Size = Size.Medium;
            Assert.Equal(Size.Medium, fries.Size);
            fries.Size = Size.Small;
            Assert.Equal(Size.Small, fries.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.Empty(fries.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42, "$0.42")]
        [InlineData(Size.Medium, 0.76, "$0.76")]
        [InlineData(Size.Large, 0.96, "$0.96")]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price, string p)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(price, fries.Price);
            Assert.Equal(p, fries.StringPrice);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(calories, fries.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(name, fries.ToString());
            Assert.Equal(name, fries.Name);
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeCaloriesANDPriceProperty(Size size)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.PropertyChanged(fries, "Size", () => fries.Size = size);
            Assert.PropertyChanged(fries, "Calories", () => fries.Size = size);
            Assert.PropertyChanged(fries, "Price", () => fries.Size = size);
            Assert.PropertyChanged(fries, "Name", () => fries.Size = size);
        }
    }
}