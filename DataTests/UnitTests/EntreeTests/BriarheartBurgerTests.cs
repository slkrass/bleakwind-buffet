/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(burger);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(burger);
            Assert.Equal("Entree", burger.ItemType);
            Assert.Equal("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.", burger.Description);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Bun);
            Assert.False(burger.HoldBun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Ketchup);
            Assert.False(burger.HoldKetchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Mustard);
            Assert.False(burger.HoldMustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Pickle);
            Assert.False(burger.HoldPickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Cheese);
            Assert.False(burger.HoldCheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Bun = false;
            Assert.False(burger.Bun);
            burger.Bun = true;
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
            burger.Mustard = true;
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Pickle = false;
            Assert.False(burger.Pickle);
            burger.Pickle = true;
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Cheese = false;
            Assert.False(burger.Cheese);
            burger.Cheese = true;
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal(6.32, burger.Price);
            Assert.Equal("$6.32", burger.StringPrice);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 743;
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal(cal, burger.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Bun = includeBun;
            burger.Ketchup = includeKetchup;
            burger.Mustard = includeMustard;
            burger.Pickle = includePickle;
            burger.Cheese = includeCheese;

            if (!includeBun && !includeKetchup && !includeMustard && !includePickle && !includeCheese)
            {
                Assert.Contains("Hold bun", burger.SpecialInstructions);
                Assert.Contains("Hold ketchup", burger.SpecialInstructions);
                Assert.Contains("Hold mustard", burger.SpecialInstructions);
                Assert.Contains("Hold pickle", burger.SpecialInstructions);
                Assert.Contains("Hold cheese", burger.SpecialInstructions);
            }
            else
            {
                Assert.Empty(burger.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", burger.ToString());
            Assert.Equal("Briarheart Burger", burger.Name);
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingBunNotifiesBunANDSpecialInstructionsProperty(bool bun)
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Bun", () => burger.Bun = bun);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Bun = bun);
            Assert.PropertyChanged(burger, "HoldBun", () => burger.HoldBun = !bun);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingKetchupNotifiesKetchupANDSpecialInstructionsProperty(bool ketchup)
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Ketchup", () => burger.Ketchup = ketchup);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Ketchup = ketchup);
            Assert.PropertyChanged(burger, "HoldKetchup", () => burger.HoldKetchup = !ketchup);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingMustardNotifiesMustardANDSpecialInstructionsProperty(bool mustard)
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Mustard", () => burger.Mustard = mustard);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Mustard = mustard);
            Assert.PropertyChanged(burger, "HoldMustard", () => burger.HoldMustard = !mustard);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingPickleNotifiesPickleANDSpecialInstructionsProperty(bool pickle)
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Pickle", () => burger.Pickle = pickle);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Pickle = pickle);
            Assert.PropertyChanged(burger, "HoldPickle", () => burger.HoldPickle = !pickle);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingCheeseNotifiesCheeseANDSpecialInstructionsProperty(bool cheese)
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Cheese", () => burger.Cheese = cheese);
            Assert.PropertyChanged(burger, "SpecialInstructions", () => burger.Cheese = cheese);
            Assert.PropertyChanged(burger, "HoldCheese", () => burger.HoldCheese = !cheese);
        }
    }
}