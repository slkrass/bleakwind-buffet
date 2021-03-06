﻿/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SailorSoda soda = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(soda);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda soda = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(soda);
            Assert.Equal("Drink", soda.ItemType);
            Assert.Equal("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", soda.Description);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.Equal(Size.Small, soda.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda soda = new SailorSoda();
            soda.Ice = false;
            Assert.False(soda.Ice);
            Assert.True(soda.HoldIce);
            soda.Ice = true;
            Assert.True(soda.Ice);
            Assert.False(soda.HoldIce);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = Size.Large;
            Assert.Equal(Size.Large, soda.Size);
            soda.Size = Size.Medium;
            Assert.Equal(Size.Medium, soda.Size);
            soda.Size = Size.Small;
            Assert.Equal(Size.Small, soda.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda soda = new SailorSoda();
            soda.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, soda.Flavor);

            soda.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, soda.Flavor);

            soda.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, soda.Flavor);

            soda.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, soda.Flavor);

            soda.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, soda.Flavor);

            soda.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, soda.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42, "$1.42")]
        [InlineData(Size.Medium, 1.74, "$1.74")]
        [InlineData(Size.Large, 2.07, "$2.07")]
        public void ShouldHaveCorrectPriceForSize(Size size, double price, string p)
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = size;
            Assert.Equal(price, soda.Price);
            Assert.Equal(p, soda.StringPrice);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = size;
            Assert.Equal(cal, soda.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda soda = new SailorSoda();
            soda.Ice = includeIce;

            if (!includeIce)
            {
                Assert.Contains("Hold ice", soda.SpecialInstructions);
            }
            else
            {
                Assert.Empty(soda.SpecialInstructions);
            }
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda soda = new SailorSoda();
            soda.Flavor = flavor;
            soda.Size = size;
            Assert.Equal(name, soda.ToString());
            Assert.Equal(name, soda.Name);
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            SailorSoda soda = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeCaloriesANDPriceProperty(Size size)
        {
            SailorSoda soda = new SailorSoda();
            Assert.PropertyChanged(soda, "Size", () => soda.Size = size);
            Assert.PropertyChanged(soda, "Calories", () => soda.Size = size);
            Assert.PropertyChanged(soda, "Price", () => soda.Size = size);
            Assert.PropertyChanged(soda, "Name", () => soda.Size = size);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingIceNotifiesIceANDSpecialInstructionsProperty(bool ice)
        {
            SailorSoda soda = new SailorSoda();
            Assert.PropertyChanged(soda, "Ice", () => soda.Ice = ice);
            Assert.PropertyChanged(soda, "HoldIce", () => soda.HoldIce = !ice);
            Assert.PropertyChanged(soda, "SpecialInstructions", () => soda.Ice = ice);
        }

        [Theory]
        [InlineData(SodaFlavor.Blackberry)]
        [InlineData(SodaFlavor.Cherry)]
        [InlineData(SodaFlavor.Grapefruit)]
        [InlineData(SodaFlavor.Lemon)]
        [InlineData(SodaFlavor.Peach)]
        [InlineData(SodaFlavor.Watermelon)]
        public void ChangingFlavorNotifiesFlavorProperty(SodaFlavor flavor)
        {
            SailorSoda soda = new SailorSoda();
            Assert.PropertyChanged(soda, "Flavor", () => soda.Flavor = flavor);
        }

    }
}
