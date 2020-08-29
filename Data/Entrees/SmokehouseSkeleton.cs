/*
 * Author: Stephanie Krass
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the breakfast combo
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the calories of the breakfast combo
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Holds whether or not the breakfast combo has sausage links
        /// </summary>
        private bool sausageLink = true;

        /// <summary>
        /// Gets and sets whether the breakfast combo has sausage links
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }

            set
            {
                sausageLink = value;
            }
        }

        /// <summary>
        /// Holds whether or not the breakfast combo has eggs
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// Gets and sets whether or not the breakfast combo has eggs
        public bool Egg
        {
            get
            {
                return egg;
            }

            set
            {
                egg = value;
            }
        }

        /// <summary>
        /// Holds whether or not the breakfast combo has hash browns
        /// </summary>
        private bool hashBrowns = true;

        /// <summary>
        /// Gets and sets whether or not the breakfast combo has hash browns
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }

            set
            {
                hashBrowns = value;
            }
        }

        /// <summary>
        /// Holds whether or not the breakfast combo has pancakes
        /// </summary>
        private bool pancake = true;

        /// <summary>
        /// Gets and sets whether or not the breakfast combo has pancakes
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }

            set
            {
                pancake = value;
            }
        }


        /// <summary>
        /// Gets the special instructions for the the breakfast combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!sausageLink) instructions.Add("Hold sausage");
                if (!egg) instructions.Add("Hold eggs");
                if (!hashBrowns) instructions.Add("Hold hash browns");
                if (!pancake) instructions.Add("Hold pankcakes");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>The string representation of Smokehouse Skeleton</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

    }
}
