/*
 * Author: Stephanie Krass
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            WarriorWater water = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(water);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater water = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(water);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            WarriorWater water = new WarriorWater();
            water.Ice = false;
            Assert.False(water.Ice);
            Assert.True(water.HoldIce);
            water.Ice = true;
            Assert.True(water.Ice);
            Assert.False(water.HoldIce);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater water = new WarriorWater();
            water.Size = Size.Large;
            Assert.Equal(Size.Large, water.Size);
            water.Size = Size.Medium;
            Assert.Equal(Size.Medium, water.Size);
            water.Size = Size.Small;
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldByAbleToSetLemon()
        {
            WarriorWater water = new WarriorWater();
            water.Lemon = true;
            Assert.True(water.Lemon);
            water.Lemon= false;
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(0, water.Price);
            Assert.Equal("$0.00", water.StringPrice);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(Convert.ToUInt32(0), water.Calories);
        }


        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater water = new WarriorWater();
            water.Ice = includeIce;
            water.Lemon= includeLemon;

            if (!includeIce && includeLemon)
            {
                Assert.Contains("Hold ice", water.SpecialInstructions);
                Assert.Contains("Add lemon", water.SpecialInstructions);
                Assert.Contains("Hold ice", water.StringSpecialInstructions);
                Assert.Contains("Add lemon", water.StringSpecialInstructions);
            }
            else if (!includeIce)
            {
                Assert.Contains("Hold ice", water.SpecialInstructions);
                Assert.Contains("Hold ice", water.StringSpecialInstructions);
            }
            else if (includeLemon)
            {
                Assert.Contains("Add lemon", water.SpecialInstructions);
                Assert.Contains("Add lemon", water.StringSpecialInstructions);
            }
            else
            {
                Assert.Empty(water.SpecialInstructions);
                Assert.Empty(water.StringSpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater water = new WarriorWater();
            water.Size = size;
            Assert.Equal(name, water.ToString());
            Assert.Equal(name, water.Name);
        }


        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            WarriorWater water = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeCaloriesANDPriceProperty(Size size)
        {
            WarriorWater water = new WarriorWater();
            Assert.PropertyChanged(water, "Size", () => water.Size = size);
            Assert.PropertyChanged(water, "Calories", () => water.Size = size);
            Assert.PropertyChanged(water, "Price", () => water.Size = size);
            Assert.PropertyChanged(water, "Name", () => water.Size = size);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingIceNotifiesIceANDSpecialInstructionsProperty(bool ice)
        {
            WarriorWater water = new WarriorWater();
            Assert.PropertyChanged(water, "Ice", () => water.Ice = ice);
            Assert.PropertyChanged(water, "SpecialInstructions", () => water.Ice = ice);
            Assert.PropertyChanged(water, "HoldIce", () => water.HoldIce = !ice);
            Assert.PropertyChanged(water, "StringSpecialInstructions", () => water.Ice = ice);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingLemonNotifiesLemonANDSpecialInstructionsProperty(bool lemon)
        {
            WarriorWater water = new WarriorWater();
            Assert.PropertyChanged(water, "Lemon", () => water.Lemon = lemon);
            Assert.PropertyChanged(water, "SpecialInstructions", () => water.Lemon = lemon);
            Assert.PropertyChanged(water, "StringSpecialInstructions", () => water.Lemon = lemon);
        }
    }
}
