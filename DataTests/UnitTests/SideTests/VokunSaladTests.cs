/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad salad = new VokunSalad();
            Assert.Equal(Size.Small, salad.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad salad = new VokunSalad();
            salad.Size = Size.Large;
            Assert.Equal(Size.Large, salad.Size);
            salad.Size = Size.Medium;
            Assert.Equal(Size.Medium, salad.Size);
            salad.Size = Size.Small;
            Assert.Equal(Size.Small, salad.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad salad = new VokunSalad();
            Assert.Empty(salad.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad salad = new VokunSalad();
            salad.Size = size;
            Assert.Equal(price, salad.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad salad = new VokunSalad();
            salad.Size = size;
            Assert.Equal(calories, salad.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad salad = new VokunSalad();
            salad.Size = size;
            Assert.Equal(name, salad.ToString());
        }
    }
}