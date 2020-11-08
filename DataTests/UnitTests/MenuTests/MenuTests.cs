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
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

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
            Assert.Contains(Menu.Search(null), (item) => { return item.ToString().Equals(name); });
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
            Assert.Contains(Menu.Search(null), (item) => { return item.ToString().Equals(name); });
        }
        [Theory]
        [InlineData("Entree")]
        [InlineData("Side")]
        [InlineData("Drink")]
        public void CategoriesShouldContainProperItemsByDefault(string str)
        {
            Assert.Contains(str, Menu.Categories);
        }

        [Theory]
        [InlineData("Water", "Small Warrior Water")]
        [InlineData("Water","Medium Warrior Water")]
        [InlineData("Water","Large Warrior Water")]
        [InlineData("Water", "Small Watermelon Sailor Soda")]
        [InlineData("Water", "Medium Watermelon Sailor Soda")]
        [InlineData("Water", "Large Watermelon Sailor Soda")]
        [InlineData("Burger","Briarheart Burger")]
        [InlineData("Draugr","Double Draugr")]
        [InlineData("Orc","Garden Orc Omelette")]
        [InlineData("Poach","Philly Poacher")]
        [InlineData("house","Smokehouse Skeleton")]
        [InlineData("Triple","Thalmor Triple")]
        [InlineData("Thugs","Thugs T-Bone")]
        public void SearchShouldReturnTheCorrectListWhenGivenTwoStrings(string str, string name)
        {
            Assert.Contains(Menu.Search(str), (item) => { return item.ToString().Equals(name); });
        }
        [Theory]
        [InlineData("Small Aretino Apple Juice")]
        [InlineData("Small Decaf Candlehearth Coffee")]
        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Small Markarth Milk")]
        [InlineData("Small Peach Sailor Soda")]
        [InlineData("Small Warrior Water")]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Small Fried Miraak")]
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Small Vokun Salad")]
        public void SearchShouldReturnTheCorrectListWhenSmallIsSearhed(string name)
        {
            Assert.Contains(Menu.Search("Small"), (item) => { return item.ToString().Equals(name); });
            Assert.Contains(Menu.Search("small"), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData("Small Warrior Water")]
        [InlineData("Medium Warrior Water")]
        [InlineData("Large Warrior Water")]
        [InlineData("Small Watermelon Sailor Soda")]
        [InlineData("Medium Watermelon Sailor Soda")]
        [InlineData("Large Watermelon Sailor Soda")]
        [InlineData("Briarheart Burger")]
        [InlineData("Double Draugr")]
        [InlineData("Garden Orc Omelette")]
        [InlineData("Philly Poacher")]
        [InlineData("Smokehouse Skeleton")]
        [InlineData("Thalmor Triple")]
        [InlineData("Thugs T-Bone")]
        [InlineData("Small Aretino Apple Juice")]
        [InlineData("Small Decaf Candlehearth Coffee")]
        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Small Markarth Milk")]
        [InlineData("Small Peach Sailor Soda")]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Small Fried Miraak")]
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Small Vokun Salad")]
        public void FilterByCategoryShouldReturnAllIfGivenNull(string name)
        {
            Assert.Contains(Menu.FilterByCategory(Menu.FullMenu(), null), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData("Briarheart Burger")]
        [InlineData("Double Draugr")]
        [InlineData("Garden Orc Omelette")]
        [InlineData("Philly Poacher")]
        [InlineData("Smokehouse Skeleton")]
        [InlineData("Thalmor Triple")]
        [InlineData("Thugs T-Bone")]
        public void FilterByCategoryShouldReturnAllEntreesIfGivenEntree(string name)
        {
            var list = new List<string>();
            list.Add("Entree");
            Assert.Contains(Menu.FilterByCategory(Menu.FullMenu(), list), (item) => { return item.ToString().Equals(name); });
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
        public void FilterByCategoryShouldReturnAllSidesIfGivenSide(string name)
        {
            var list = new List<string>();
            list.Add("Side");
            Assert.Contains(Menu.FilterByCategory(Menu.FullMenu(), list), (item) => { return item.ToString().Equals(name); });
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
        public void FilterByCategoryShouldReturnAllDrinksIfGivenDrink(string name)
        {
            var list = new List<string>();
            list.Add("Drink");
            Assert.Contains(Menu.FilterByCategory(Menu.FullMenu(), list), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Large Fried Miraak")]
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Large Vokun Salad")]
        [InlineData("Small Aretino Apple Juice")]
        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Medium Markarth Milk")]
        [InlineData("Medium Watermelon Sailor Soda")]
        [InlineData("Medium Warrior Water")]
        public void FilterByCategoryShouldReturnAllSidesAndDrinksIfGivenSidesAndDrink(string name)
        {
            var list = new List<string>();
            list.Add("Drink");
            list.Add("Side");
            Assert.Contains(Menu.FilterByCategory(Menu.FullMenu(), list), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData("Briarheart Burger")]
        [InlineData("Double Draugr")]
        [InlineData("Garden Orc Omelette")]
        [InlineData("Philly Poacher")]
        [InlineData("Smokehouse Skeleton")]
        [InlineData("Thalmor Triple")]
        [InlineData("Thugs T-Bone")]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Large Fried Miraak")]
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Large Vokun Salad")]
        [InlineData("Small Aretino Apple Juice")]
        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Medium Markarth Milk")]
        [InlineData("Medium Watermelon Sailor Soda")]
        [InlineData("Medium Warrior Water")]
        public void FilterByCaloriesAndFilterByPriceByDefaultShouldReturnTheFullMenu(string name)
        {

            Assert.Contains(Menu.FilterByPrice(Menu.FullMenu(), null, null), (item) => { return item.ToString().Equals(name); });
            Assert.Contains(Menu.FilterByCalories(Menu.FullMenu(), null, null), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData((uint) 192)]
        [InlineData((uint) 100)]
        [InlineData((uint) 50)]
        [InlineData((uint) 150)]
        [InlineData((uint) 200)]
        [InlineData((uint) 300)]
        [InlineData((uint) 400)]
        [InlineData((uint) 500)]
        [InlineData((uint) 600)]
        [InlineData((uint) 700)]
        [InlineData((uint) 800)]
        [InlineData((uint) 900)]
        [InlineData((uint) 1000)]
        public void FilterByCaloriesShouldFilterIfOnlyMaxIsSet(uint maxCals)
        {
            var list = new List<string>();

            foreach(Side side in Menu.Sides())
            {
                if (side.Calories <= maxCals) list.Add(side.Name);
            }
            foreach (Drink drink in Menu.Drinks())
            {
                if (drink.Calories <= maxCals) list.Add(drink.Name);
            }
            foreach (Entree entree in Menu.Entrees())
            {
                if (entree.Calories <= maxCals) list.Add(entree.Name);
            }

            foreach (string name in list)
                Assert.Contains(Menu.FilterByCalories(Menu.FullMenu(), null, maxCals), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData((uint)192)]
        [InlineData((uint)100)]
        [InlineData((uint)50)]
        [InlineData((uint)150)]
        [InlineData((uint)200)]
        [InlineData((uint)300)]
        [InlineData((uint)400)]
        [InlineData((uint)500)]
        [InlineData((uint)600)]
        [InlineData((uint)700)]
        [InlineData((uint)800)]
        [InlineData((uint)900)]
        [InlineData((uint)1000)]
        public void FilterByCaloriesShouldFilterIfOnlyMinIsSet(uint minCals)
        {
            var list = new List<string>();

            foreach (Side side in Menu.Sides())
            {
                if (side.Calories >= minCals) list.Add(side.Name);
            }
            foreach (Drink drink in Menu.Drinks())
            {
                if (drink.Calories >= minCals) list.Add(drink.Name);
            }
            foreach (Entree entree in Menu.Entrees())
            {
                if (entree.Calories >= minCals) list.Add(entree.Name);
            }

            foreach (string name in list)
                Assert.Contains(Menu.FilterByCalories(Menu.FullMenu(), minCals, null), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData((uint)0, (uint) 1000)]
        [InlineData((uint)10, (uint) 600)]
        [InlineData((uint)200, (uint) 500)]
        public void FilterByCaloriesShouldFilterIfMinAndMaxIsSet(uint minCals, uint maxCals)
        {
            var list = new List<string>();

            foreach (Side side in Menu.Sides())
            {
                if (side.Calories >= minCals && side.Calories <= maxCals) list.Add(side.Name);
            }
            foreach (Drink drink in Menu.Drinks())
            {
                if (drink.Calories >= minCals && drink.Calories <= maxCals) list.Add(drink.Name);
            }
            foreach (Entree entree in Menu.Entrees())
            {
                if (entree.Calories >= minCals && entree.Calories <= maxCals) list.Add(entree.Name);
            }

            foreach (string name in list)
                Assert.Contains(
                    Menu.FilterByCalories(
                        Menu.FullMenu(), minCals, maxCals), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(1.50)]
        [InlineData(3.50)]
        [InlineData(5.25)]
        [InlineData(0.50)]
        public void FilterByPriceShouldFilterIfOnlyMaxIsSet(double maxPrice)
        {
            var list = new List<string>();

            foreach (Side side in Menu.Sides())
            {
                if (side.Price <= maxPrice) list.Add(side.Name);
            }
            foreach (Drink drink in Menu.Drinks())
            {
                if (drink.Price <= maxPrice) list.Add(drink.Name);
            }
            foreach (Entree entree in Menu.Entrees())
            {
                if (entree.Price <=maxPrice) list.Add(entree.Name);
            }

            foreach (string name in list)
                Assert.Contains(Menu.FilterByPrice(Menu.FullMenu(), null, maxPrice), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(1.50)]
        [InlineData(3.50)]
        [InlineData(5.25)]
        [InlineData(0.50)]
        public void FilterByPriceShouldFilterIfOnlyMinIsSet(double minPrice)
        {
            var list = new List<string>();

            foreach (Side side in Menu.Sides())
            {
                if (side.Price >= minPrice) list.Add(side.Name);
            }
            foreach (Drink drink in Menu.Drinks())
            {
                if (drink.Price >= minPrice) list.Add(drink.Name);
            }
            foreach (Entree entree in Menu.Entrees())
            {
                if (entree.Price >= minPrice) list.Add(entree.Name);
            }

            foreach (string name in list)
                Assert.Contains(Menu.FilterByPrice(Menu.FullMenu(), minPrice, null), (item) => { return item.ToString().Equals(name); });
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(0.15,2.00)]
        [InlineData(1.50,6.5)]
        public void FilterByPriceShouldFilterIfMinAndMaxIsSet(double minPrice, double maxPrice)
        {
            var list = new List<string>();

            foreach (Side side in Menu.Sides())
            {
                if (side.Price >= minPrice && side.Price <= maxPrice) list.Add(side.Name);
            }
            foreach (Drink drink in Menu.Drinks())
            {
                if (drink.Price >= minPrice && drink.Price <= maxPrice) list.Add(drink.Name);
            }
            foreach (Entree entree in Menu.Entrees())
            {
                if (entree.Price >= minPrice && entree.Price <= maxPrice) list.Add(entree.Name);
            }

            foreach (string name in list) 
                Assert.Contains(Menu.FilterByPrice(Menu.FullMenu(), minPrice, maxPrice), (item) => { return item.ToString().Equals(name); });
        }
    }
}
