/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tBone);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tBone);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.Equal(6.44, tBone.Price);
            Assert.Equal("$6.44", tBone.StringPrice);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 982;
            ThugsTBone tBone = new ThugsTBone();
            Assert.Equal(cal, tBone.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.Empty(tBone.SpecialInstructions);
            Assert.Empty(tBone.StringSpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tBone.ToString());
            Assert.Equal("Thugs T-Bone", tBone.Name);
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tBone);
        }

    }
}