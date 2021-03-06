﻿/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(burger);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(burger);
            Assert.Equal("Entree", burger.ItemType);
            Assert.Equal("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", burger.Description);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Bun);
            Assert.False(burger.HoldBun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Ketchup);
            Assert.False(burger.HoldKetchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Mustard);
            Assert.False(burger.HoldMustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Pickle);
            Assert.False(burger.HoldPickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Cheese);
            Assert.False(burger.HoldCheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Tomato);
            Assert.False(burger.HoldTomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Lettuce);
            Assert.False(burger.HoldLettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Mayo);
            Assert.False(burger.HoldMayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Bacon);
            Assert.False(burger.HoldBacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Egg);
            Assert.False(burger.HoldEgg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Bun = false;
            Assert.False(burger.Bun);
            burger.Bun = true;
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
            Assert.True(burger.HoldKetchup);
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);
            Assert.False(burger.HoldKetchup);


        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
            burger.Mustard = true;
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Pickle = false;
            Assert.False(burger.Pickle);
            burger.Pickle = true;
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Cheese = false;
            Assert.False(burger.Cheese);
            burger.Cheese = true;
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Tomato = false;
            Assert.False(burger.Tomato);
            burger.Tomato = true;
            Assert.True(burger.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Lettuce = false;
            Assert.False(burger.Lettuce);
            burger.Lettuce = true;
            Assert.True(burger.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Mayo = false;
            Assert.False(burger.Mayo);
            burger.Mayo = true;
            Assert.True(burger.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Bacon = false;
            Assert.False(burger.Bacon);
            burger.Bacon = true;
            Assert.True(burger.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Egg = false;
            Assert.False(burger.Egg);
            burger.Egg = true;
            Assert.True(burger.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.Equal(8.32, burger.Price);
            Assert.Equal("$8.32", burger.StringPrice);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 943;
            ThalmorTriple burger = new ThalmorTriple();
            Assert.Equal(cal, burger.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Bun = includeBun;
            burger.Ketchup = includeKetchup;
            burger.Mustard = includeMustard;
            burger.Pickle = includePickle;
            burger.Cheese = includeCheese;
            burger.Tomato = includeTomato;
            burger.Lettuce = includeLettuce;
            burger.Mayo = includeMayo;
            burger.Bacon = includeBacon;
            burger.Egg = includeEgg;

            if (!includeBun && !includeKetchup && !includeMustard && !includePickle && !includeCheese && !includeTomato && !includeLettuce && !includeMayo && !includeBacon && !includeEgg)
            {
                Assert.Contains("Hold bun", burger.SpecialInstructions);
                Assert.Contains("Hold ketchup", burger.SpecialInstructions);
                Assert.Contains("Hold mustard", burger.SpecialInstructions);
                Assert.Contains("Hold pickle", burger.SpecialInstructions);
                Assert.Contains("Hold cheese", burger.SpecialInstructions);
                Assert.Contains("Hold tomato", burger.SpecialInstructions);
                Assert.Contains("Hold lettuce", burger.SpecialInstructions);
                Assert.Contains("Hold mayo", burger.SpecialInstructions);
                Assert.Contains("Hold bacon", burger.SpecialInstructions);
                Assert.Contains("Hold egg", burger.SpecialInstructions);
            }
            else
            {
                Assert.Empty(burger.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", burger.ToString());
            Assert.Equal("Thalmor Triple", burger.Name);
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingBunNotifiesBunANDSpecialInstructionsProperty(bool bun)
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.PropertyChanged(burger, "Bun", () => burger.Bun = bun);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Bun = bun);
            Assert.PropertyChanged(burger, "HoldBun", () => burger.HoldBun = !bun);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingKetchupNotifiesKetchupANDSpecialInstructionsProperty(bool ketchup)
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.PropertyChanged(burger, "Ketchup", () => burger.Ketchup = ketchup);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Ketchup = ketchup);
            Assert.PropertyChanged(burger, "HoldKetchup", () => burger.HoldKetchup = !ketchup);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingMustardNotifiesMustardANDSpecialInstructionsProperty(bool mustard)
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.PropertyChanged(burger, "Mustard", () => burger.Mustard = mustard);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Mustard = mustard);
            Assert.PropertyChanged(burger, "HoldMustard", () => burger.HoldMustard = !mustard);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingPickleNotifiesPickleANDSpecialInstructionsProperty(bool pickle)
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.PropertyChanged(burger, "Pickle", () => burger.Pickle = pickle);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Pickle = pickle);
            Assert.PropertyChanged(burger, "HoldPickle", () => burger.HoldPickle = !pickle);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingCheeseNotifiesCheeseANDSpecialInstructionsProperty(bool cheese)
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.PropertyChanged(burger, "Cheese", () => burger.Cheese = cheese);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Cheese = cheese);
            Assert.PropertyChanged(burger, "HoldCheese", () => burger.HoldCheese = !cheese);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingTomatoNotifiesTomatoANDSpecialInstructionsProperty(bool tomato)
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.PropertyChanged(burger, "Tomato", () => burger.Tomato = tomato);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Tomato = tomato);
            Assert.PropertyChanged(burger, "HoldTomato", () => burger.HoldTomato = !tomato);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingLettuceNotifiesLettuceANDSpecialInstructionsProperty(bool lettuce)
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.PropertyChanged(burger, "Lettuce", () => burger.Lettuce = lettuce);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Lettuce = lettuce);
            Assert.PropertyChanged(burger, "HoldLettuce", () => burger.HoldLettuce = !lettuce);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingMayoNotifiesMayoANDSpecialInstructionsProperty(bool mayo)
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.PropertyChanged(burger, "Mayo", () => burger.Mayo = mayo);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Mayo = mayo);
            Assert.PropertyChanged(burger, "HoldMayo", () => burger.HoldMayo = !mayo);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingEggNotifiesEggANDSpecialInstructionsProperty(bool egg)
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.PropertyChanged(burger, "Egg", () => burger.Egg = egg);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Egg = egg);
            Assert.PropertyChanged(burger, "HoldEgg", () => burger.HoldEgg = !egg);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingBaconNotifiesBaconANDSpecialInstructionsProperty(bool bacon)
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.PropertyChanged(burger, "Bacon", () => burger.Bacon = bacon);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Bacon = bacon);
            Assert.PropertyChanged(burger, "HoldBacon", () => burger.HoldBacon = !bacon);
        }
    }
}