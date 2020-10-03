/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(grits);
        }

        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(grits);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.Equal(Size.Small, grits.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = Size.Large;
            Assert.Equal(Size.Large, grits.Size);
            grits.Size = Size.Medium;
            Assert.Equal(Size.Medium, grits.Size);
            grits.Size = Size.Small;
            Assert.Equal(Size.Small, grits.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.Empty(grits.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = size;
            Assert.Equal(price, grits.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = size;
            Assert.Equal(calories, grits.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = size;
            Assert.Equal(name, grits.ToString());
        }
        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(grits);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.PropertyChanged(grits, "Size", () => grits.Size = size);
        }
    }
}