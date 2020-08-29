/*
 * Author: Stephanie Krass
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// The price of Dragonborn Waffle Fries
        /// </summary>
        private double price = 0.42;

        /// <summary>
        /// Gets the price of Dragonborn Waffle Fries
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) price = 0.42;
                if (size == Size.Medium) price = 0.76;
                if (size == Size.Large) price = 0.96;
                return price;
            }
        }

        /// <summary>
        /// The calories of the Dragonborn Waffle Fries
        /// </summary>
        private uint calories = 77;

        /// <summary>
        /// Gets the calories of Dragonborn Waffle Fries
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 77;
                if (size == Size.Medium) calories = 89;
                if (size == Size.Large) calories = 100;
                return calories;
            }
        }

        /// <summary>
        /// The size of Dragonborn Waffle Fries
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of Dragonborn Waffle Fries
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }


        /// <summary>
        /// Gets the special instructions for Dragonborn Waffle Fries
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>The string representation of Dragonborn Waffle Fries</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Dragonborn Waffle Fries");
            return sb.ToString();
        }
    }
}
