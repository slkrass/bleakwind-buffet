/*
 * Author: Zachery Brunner
 * Modified by: Stephanie Krass
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

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
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.Pancake);
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
            }
            else Assert.Empty(skeleton.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", skeleton.ToString());
        }
    }
}