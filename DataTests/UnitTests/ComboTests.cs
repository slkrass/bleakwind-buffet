/*
 * Author: Stephanie Krass
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using Xunit;
using System.ComponentModel;
using System.Collections;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
        }

        [Fact]
        public void Price_Should_Be_The_Price_Of_The_Items_Minus_One()
        {
            Combo combo = new Combo();
            WarriorWater ww = new WarriorWater();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            double price = ww.Price + bb.Price + vs.Price - 1;
            Assert.Equal(price, combo.Price);
        }

        [Fact]
        public void Calories_Should_Be_The_Total_Calories_Of_All_The_Items()
        {
            Combo combo = new Combo();
            WarriorWater ww = new WarriorWater();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            uint cal = ww.Calories + bb.Calories + vs.Calories;
            Assert.Equal(cal, combo.Calories);
        }

        [Fact]
        public void Changing_ComboDrink_Should_Notify_Price_Calories_SpecialInstructions()
        {
            Combo combo = new Combo();

            Assert.PropertyChanged(combo, "SpecialInstructions", () => combo.ComboDrink = new AretinoAppleJuice());
            Assert.PropertyChanged(combo, "Price", () => combo.ComboDrink = new AretinoAppleJuice());
            Assert.PropertyChanged(combo, "Calories", () => combo.ComboDrink = new AretinoAppleJuice());

        }

        [Fact]
        public void Changing_ComboDrink_Size_Should_Notify_Price_Calories_SpecialInstructions()
        {
            Combo combo = new Combo();

            Assert.PropertyChanged(combo, "SpecialInstructions", () => combo.ComboDrink.Size = Size.Medium);
            Assert.PropertyChanged(combo, "Price", () => combo.ComboDrink.Size = Size.Medium);
            Assert.PropertyChanged(combo, "Calories", () => combo.ComboDrink.Size = Size.Medium);

        }

        [Fact]
        public void Changing_ComboSide_Should_Notify_Price_Calories_SpecialInstructions()
        {
            Combo combo = new Combo();

            Assert.PropertyChanged(combo, "SpecialInstructions", () => combo.ComboSide = new DragonbornWaffleFries());
            Assert.PropertyChanged(combo, "Price", () => combo.ComboSide = new DragonbornWaffleFries());
            Assert.PropertyChanged(combo, "Calories", () => combo.ComboSide = new DragonbornWaffleFries());
        }

        [Fact]
        public void Changing_ComboSide_Size_Should_Notify_Price_Calories_SpecialInstructions()
        {
            Combo combo = new Combo();

            Assert.PropertyChanged(combo, "SpecialInstructions", () => combo.ComboSide.Size = Size.Medium);
            Assert.PropertyChanged(combo, "Price", () => combo.ComboSide.Size = Size.Medium);
            Assert.PropertyChanged(combo, "Calories", () => combo.ComboSide.Size = Size.Medium);
        }

        [Fact]
        public void Changing_ComboEntree_Should_Notify_Price_Calories_SpecialInstructions()
        {
            Combo combo = new Combo();

            Assert.PropertyChanged(combo, "SpecialInstructions", () => combo.ComboEntree = new BriarheartBurger());
            Assert.PropertyChanged(combo, "Price", () => combo.ComboEntree = new BriarheartBurger());
            Assert.PropertyChanged(combo, "Calories", () => combo.ComboEntree = new BriarheartBurger());
        }


        [Fact]
        public void Changing_Flavor_Should_Notify_SpecialInstructions()
        {
            Combo combo = new Combo();
            SailorSoda soda = new SailorSoda();
            combo.ComboDrink = soda;
            Assert.PropertyChanged(combo, "SpecialInstructions", () => ((SailorSoda)combo.ComboDrink).Flavor = SodaFlavor.Blackberry);
        }

        [Fact]
        public void Changing_SpecialInstructions_Should_Notify_SpecialInstructions()
        {
            Combo combo = new Combo();
            SailorSoda soda = new SailorSoda();
            combo.ComboDrink = soda;
            combo.ComboEntree = new BriarheartBurger();
            Assert.PropertyChanged(combo, "SpecialInstructions", () => ((SailorSoda)combo.ComboDrink).Ice = false);
            Assert.PropertyChanged(combo, "SpecialInstructions", () => ((BriarheartBurger)combo.ComboEntree).Ketchup = false);
        }

        [Fact]
        public void SpecialInstructions_Should_Include_Entree_Drink_And_Side_SpecialInstructions()
        {
            Combo combo = new Combo();
            combo.ComboDrink = new SailorSoda();
            combo.ComboEntree = new BriarheartBurger();
            combo.ComboSide = new MadOtarGrits();
            ((SailorSoda)combo.ComboDrink).Ice = false;
            ((BriarheartBurger)combo.ComboEntree).Ketchup = false;

            Assert.Contains(((SailorSoda)combo.ComboDrink).Name, combo.SpecialInstructions);
            Assert.Contains(((BriarheartBurger)combo.ComboEntree).Name, combo.SpecialInstructions);
            Assert.Contains(((MadOtarGrits)combo.ComboSide).Name, combo.SpecialInstructions);

            foreach(string instruct in ((SailorSoda)combo.ComboDrink).SpecialInstructions)
                Assert.Contains(instruct, combo.SpecialInstructions);

            foreach (string instruct in ((BriarheartBurger)combo.ComboEntree).SpecialInstructions)
                Assert.Contains(instruct, combo.SpecialInstructions);
        }

    }

}
