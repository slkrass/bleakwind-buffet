/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(omelette);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(omelette);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Broccoli);
            Assert.False(omelette.HoldBroccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Mushrooms);
            Assert.False(omelette.HoldMushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Tomato);
            Assert.False(omelette.HoldTomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Cheddar);
            Assert.False(omelette.HoldCheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Broccoli = false;
            Assert.False(omelette.Broccoli);
            omelette.Broccoli = true;
            Assert.True(omelette.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Mushrooms = false;
            Assert.False(omelette.Mushrooms);
            omelette.Mushrooms = true;
            Assert.True(omelette.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Tomato = false;
            Assert.False(omelette.Tomato);
            omelette.Tomato = true;
            Assert.True(omelette.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Cheddar = false;
            Assert.False(omelette.Cheddar);
            omelette.Cheddar = true;
            Assert.True(omelette.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal(4.57, omelette.Price);
            Assert.Equal("$4.57", omelette.StringPrice);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 404;
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal(cal, omelette.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Broccoli = includeBroccoli;
            omelette.Mushrooms = includeMushrooms;
            omelette.Tomato = includeTomato;
            omelette.Cheddar = includeCheddar;

            if (!includeBroccoli && !includeMushrooms && !includeTomato && !includeCheddar)
            {
                Assert.Contains("Hold broccoli", omelette.SpecialInstructions);
                Assert.Contains("Hold mushrooms", omelette.SpecialInstructions);
                Assert.Contains("Hold tomato", omelette.SpecialInstructions);
                Assert.Contains("Hold cheddar", omelette.SpecialInstructions);

                Assert.Contains("Hold broccoli", omelette.StringSpecialInstructions);
                Assert.Contains("Hold mushrooms", omelette.StringSpecialInstructions);
                Assert.Contains("Hold tomato", omelette.StringSpecialInstructions);
                Assert.Contains("Hold cheddar", omelette.StringSpecialInstructions);
            }
            else
            {
                Assert.Empty(omelette.SpecialInstructions);
                Assert.Empty(omelette.StringSpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", omelette.ToString());
            Assert.Equal("Garden Orc Omelette", omelette.Name);
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(omelette);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingBroccoliNotifiesBroccoliANDSpecialInstructionsProperty(bool broc)
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.PropertyChanged(omelette, "Broccoli", () => omelette.Broccoli = broc);
            Assert.PropertyChanged(omelette, "SpecialInstructions", () => omelette.Broccoli = broc);
            Assert.PropertyChanged(omelette, "HoldBroccoli", () => omelette.HoldBroccoli = !broc);
            Assert.PropertyChanged(omelette, "StringSpecialInstructions", () => omelette.Broccoli = broc);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingMushroomsNotifiesMushroomsANDSpecialInstructionsProperty(bool mushrooms)
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.PropertyChanged(omelette, "Mushrooms", () => omelette.Mushrooms = mushrooms);
            Assert.PropertyChanged(omelette, "SpecialInstructions", () => omelette.Mushrooms = mushrooms);
            Assert.PropertyChanged(omelette, "HoldMushrooms", () => omelette.HoldMushrooms = !mushrooms);
            Assert.PropertyChanged(omelette, "StringSpecialInstructions", () => omelette.Mushrooms = mushrooms);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingTomatoNotifiesTomatoANDSpecialInstructionsProperty(bool tomato)
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.PropertyChanged(omelette, "Tomato", () => omelette.Tomato = tomato);
            Assert.PropertyChanged(omelette, "SpecialInstructions", () => omelette.Tomato = tomato);
            Assert.PropertyChanged(omelette, "HoldTomato", () => omelette.HoldTomato = !tomato);
            Assert.PropertyChanged(omelette, "StringSpecialInstructions", () => omelette.Tomato = tomato);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingCheddarNotifiesCheddarANDSpecialInstructionsProperty(bool cheddar)
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.PropertyChanged(omelette, "Cheddar", () => omelette.Cheddar = cheddar);
            Assert.PropertyChanged(omelette, "SpecialInstructions", () => omelette.Cheddar = cheddar);
            Assert.PropertyChanged(omelette, "HoldCheddar", () => omelette.HoldCheddar = !cheddar);
            Assert.PropertyChanged(omelette, "StringSpecialInstructions", () => omelette.Cheddar = cheddar);
        }
    }
}