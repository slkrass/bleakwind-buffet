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
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Roll);
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
            }
            else Assert.Empty(philly.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal("Philly Poacher", philly.ToString());
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
        public void ChangingSirloinNotifiesSirloinProperty(bool sir)
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.PropertyChanged(philly, "Sirloin", () => philly.Sirloin = sir);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingOnionsNotifiesOnionsProperty(bool onion)
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.PropertyChanged(philly, "Onion", () => philly.Onion = onion);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingRollNotifiesRollProperty(bool roll)
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.PropertyChanged(philly, "Roll", () => philly.Roll = roll);
        }
    }
}