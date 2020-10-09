/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(skeleton);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(skeleton);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.SausageLink);
            Assert.False(skeleton.HoldSausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.Egg);
            Assert.False(skeleton.HoldEgg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.HashBrowns);
            Assert.False(skeleton.HoldHashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.Pancake);
            Assert.False(skeleton.HoldPancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            skeleton.SausageLink = false;
            Assert.False(skeleton.SausageLink);
            skeleton.SausageLink = true;
            Assert.True(skeleton.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            skeleton.Egg = false;
            Assert.False(skeleton.Egg);
            skeleton.Egg = true;
            Assert.True(skeleton.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            skeleton.HashBrowns = false;
            Assert.False(skeleton.HashBrowns);
            skeleton.HashBrowns = true;
            Assert.True(skeleton.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            skeleton.Pancake = false;
            Assert.False(skeleton.Pancake);
            skeleton.Pancake = true;
            Assert.True(skeleton.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.Equal(5.62, skeleton.Price);
            Assert.Equal("$5.62", skeleton.StringPrice);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint cal = 602;
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.Equal(cal, skeleton.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            skeleton.SausageLink = includeSausage;
            skeleton.Egg = includeEgg;
            skeleton.HashBrowns = includeHashbrowns;
            skeleton.Pancake = includePancake;

            if (!includeSausage && !includeEgg && !includeHashbrowns && !includePancake)
            {
                Assert.Contains("Hold sausage", skeleton.SpecialInstructions);
                Assert.Contains("Hold eggs", skeleton.SpecialInstructions);
                Assert.Contains("Hold hash browns", skeleton.SpecialInstructions);
                Assert.Contains("Hold pancakes", skeleton.SpecialInstructions);

                Assert.Contains("Hold sausage", skeleton.StringSpecialInstructions);
                Assert.Contains("Hold eggs", skeleton.StringSpecialInstructions);
                Assert.Contains("Hold hash browns", skeleton.StringSpecialInstructions);
                Assert.Contains("Hold pancakes", skeleton.StringSpecialInstructions);
            }
            else
            {
                Assert.Empty(skeleton.SpecialInstructions);
                Assert.Empty(skeleton.StringSpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", skeleton.ToString());
            Assert.Equal("Smokehouse Skeleton", skeleton.Name);
        }

        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(skeleton);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingSausageNotifiesSausageANDSpecialInstructionsProperty(bool sausage)
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.PropertyChanged(skeleton, "SausageLink", () => skeleton.SausageLink = sausage);
            Assert.PropertyChanged(skeleton, "SpecialInstructions", () => skeleton.SausageLink = sausage);
            Assert.PropertyChanged(skeleton, "HoldSausageLink", () => skeleton.HoldSausageLink = !sausage);
            Assert.PropertyChanged(skeleton, "StringSpecialInstructions", () => skeleton.SausageLink = sausage);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingEggNotifiesEggANDSpecialInstructionsProperty(bool egg)
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.PropertyChanged(skeleton, "Egg", () => skeleton.Egg = egg);
            Assert.PropertyChanged(skeleton, "SpecialInstructions", () => skeleton.Egg = egg);
            Assert.PropertyChanged(skeleton, "HoldEgg", () => skeleton.HoldEgg = !egg);
            Assert.PropertyChanged(skeleton, "StringSpecialInstructions", () => skeleton.Egg = egg);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingHashBrownsNotifiesHashBrownsANDSpecialInstructionsProperty(bool hash)
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.PropertyChanged(skeleton, "HashBrowns", () => skeleton.HashBrowns = hash);
            Assert.PropertyChanged(skeleton, "SpecialInstructions", () => skeleton.HashBrowns = hash);
            Assert.PropertyChanged(skeleton, "HoldHashBrowns", () => skeleton.HoldHashBrowns = !hash);
            Assert.PropertyChanged(skeleton, "StringSpecialInstructions", () => skeleton.HashBrowns = hash);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingPancakeNotifiesPancakeANDSpecialInstructionsProperty(bool pancake)
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.PropertyChanged(skeleton, "Pancake", () => skeleton.Pancake = pancake);
            Assert.PropertyChanged(skeleton, "SpecialInstructions", () => skeleton.Pancake = pancake);
            Assert.PropertyChanged(skeleton, "HoldPancake", () => skeleton.HoldPancake = !pancake);
            Assert.PropertyChanged(skeleton, "StringSpecialInstructions", () => skeleton.Pancake = pancake);
        }

    }
}