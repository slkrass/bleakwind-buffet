/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(philly);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(philly);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Sirloin);
            Assert.False(philly.HoldSirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Onion);
            Assert.False(philly.HoldOnion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Roll);
            Assert.False(philly.HoldRoll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Sirloin = false;
            Assert.False(philly.Sirloin);
            philly.Sirloin = true;
            Assert.True(philly.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Onion = false;
            Assert.False(philly.Onion);
            philly.Onion = true;
            Assert.True(philly.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Roll = false;
            Assert.False(philly.Roll);
            philly.Roll = true;
            Assert.True(philly.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal(7.23, philly.Price);
            Assert.Equal("$7.23", philly.StringPrice);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher philly = new PhillyPoacher();
            uint cal = 784;
            Assert.Equal(cal, philly.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Sirloin = includeSirloin;
            philly.Onion = includeOnion;
            philly.Roll = includeRoll;

            if (!includeSirloin && !includeOnion && !includeRoll)
            {
                Assert.Contains("Hold sirloin", philly.SpecialInstructions);
                Assert.Contains("Hold onions", philly.SpecialInstructions);
                Assert.Contains("Hold roll", philly.SpecialInstructions);

                Assert.Contains("Hold sirloin", philly.StringSpecialInstructions);
                Assert.Contains("Hold onions", philly.StringSpecialInstructions);
                Assert.Contains("Hold roll", philly.StringSpecialInstructions);
            }
            else
            {
                Assert.Empty(philly.SpecialInstructions);
                Assert.Empty(philly.StringSpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal("Philly Poacher", philly.ToString());
            Assert.Equal("Philly Poacher", philly.Name);
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(philly);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingSirloinNotifiesSirloinANDSpecialInstructionsProperty(bool sir)
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.PropertyChanged(philly, "Sirloin", () => philly.Sirloin = sir);
            Assert.PropertyChanged(philly, "SpecialInstructions", () => philly.Sirloin = sir);
            Assert.PropertyChanged(philly, "HoldSirloin", () => philly.HoldSirloin = !sir);
            Assert.PropertyChanged(philly, "StringSpecialInstructions", () => philly.Sirloin = sir);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingOnionsNotifiesOnionsANDSpecialInstructionsProperty(bool onion)
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.PropertyChanged(philly, "Onion", () => philly.Onion = onion);
            Assert.PropertyChanged(philly, "SpecialInstructions", () => philly.Onion = onion);
            Assert.PropertyChanged(philly, "HoldOnion", () => philly.HoldOnion = !onion);
            Assert.PropertyChanged(philly, "StringSpecialInstructions", () => philly.Onion = onion);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingRollNotifiesRollANDSpecialInstructionsProperty(bool roll)
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.PropertyChanged(philly, "Roll", () => philly.Roll = roll);
            Assert.PropertyChanged(philly, "SpecialInstructions", () => philly.Roll = roll);
            Assert.PropertyChanged(philly, "HoldRoll", () => philly.HoldRoll = !roll);
            Assert.PropertyChanged(philly, "StringSpecialInstructions", () => philly.Roll = roll);
        }
    }
}