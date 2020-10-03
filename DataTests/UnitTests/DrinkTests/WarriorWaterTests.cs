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
            water.Ice = true;
            Assert.True(water.Ice);
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
            }
            else if (!includeIce)
            {
                Assert.Contains("Hold ice", water.SpecialInstructions);
            }
            else if (includeLemon)
            {
                Assert.Contains("Add lemon", water.SpecialInstructions);
            }
            else
            {
                Assert.Empty(water.SpecialInstructions);
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
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            WarriorWater water = new WarriorWater();
            Assert.PropertyChanged(water, "Size", () => water.Size = size);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingIceNotifiesIceProperty(bool ice)
        {
            WarriorWater water = new WarriorWater();
            Assert.PropertyChanged(water, "Ice", () => water.Ice = ice);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingLemonNotifiesLemonProperty(bool lemon)
        {
            WarriorWater water = new WarriorWater();
            Assert.PropertyChanged(water, "Lemon", () => water.Lemon = lemon);
        }
    }
}
