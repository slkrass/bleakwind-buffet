/*
 * Author: Stephanie Krass
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class MenuTests
    {
        [Fact]
        public void ReturnsAllEntrees()
        {
            Assert.Contains(Menu.Entrees(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThugsTBone; });

            Assert.Contains(Menu.FullMenu(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is ThugsTBone; });

        }

        [Theory]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Medium Dragonborn Waffle Fries")]
        [InlineData("Large Dragonborn Waffle Fries")]
        [InlineData("Small Fried Miraak")]
        [InlineData("Medium Fried Miraak")]
        [InlineData("Large Fried Miraak")]
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Medium Mad Otar Grits")]
        [InlineData("Large Mad Otar Grits")]
        [InlineData("Small Vokun Salad")]
        [InlineData("Medium Vokun Salad")]
        [InlineData("Large Vokun Salad")]
        public void ReturnsAllSides(string name)
        {
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals(name); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData("Small Aretino Apple Juice")]
        [InlineData("Medium Aretino Apple Juice")]
        [InlineData("Large Aretino Apple Juice")]

        [InlineData("Small Decaf Candlehearth Coffee")]
        [InlineData("Medium Decaf Candlehearth Coffee")]
        [InlineData("Large Decaf Candlehearth Coffee")]

        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Medium Candlehearth Coffee")]
        [InlineData("Large Candlehearth Coffee")]

        [InlineData("Small Markarth Milk")]
        [InlineData("Medium Markarth Milk")]
        [InlineData("Large Markarth Milk")]

        [InlineData("Small Cherry Sailor Soda")]
        [InlineData("Medium Cherry Sailor Soda")]
        [InlineData("Large Cherry Sailor Soda")]

        [InlineData("Small Blackberry Sailor Soda")]
        [InlineData("Medium Blackberry Sailor Soda")]
        [InlineData("Large Blackberry Sailor Soda")]

        [InlineData("Small Grapefruit Sailor Soda")]
        [InlineData("Medium Grapefruit Sailor Soda")]
        [InlineData("Large Grapefruit Sailor Soda")]

        [InlineData("Small Lemon Sailor Soda")]
        [InlineData("Medium Lemon Sailor Soda")]
        [InlineData("Large Lemon Sailor Soda")]

        [InlineData("Small Peach Sailor Soda")]
        [InlineData("Medium Peach Sailor Soda")]
        [InlineData("Large Peach Sailor Soda")]

        [InlineData("Small Watermelon Sailor Soda")]
        [InlineData("Medium Watermelon Sailor Soda")]
        [InlineData("Large Watermelon Sailor Soda")]

        [InlineData("Small Warrior Water")]
        [InlineData("Medium Warrior Water")]
        [InlineData("Large Warrior Water")]
        public void ReturnsAllDrinks(string name)
        {
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals(name); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals(name); });
        }

    }
}
