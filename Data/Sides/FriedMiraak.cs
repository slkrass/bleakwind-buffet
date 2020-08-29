/*
 * Author: Stephanie Krass
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing Fried Miraak
    /// </summary>
    public class FriedMiraak
    {
        /// <summary>
        /// The price of Fried Miraak
        /// </summary>
        private double price = 1.78;

        /// <summary>
        /// Gets the price of Fried Miraak
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) price = 1.78;
                if (size == Size.Medium) price = 2.01;
                if (size == Size.Large) price = 2.88;
                return price;
            }
        }

        /// <summary>
        /// The calories of the Fried Miraak
        /// </summary>
        private uint calories = 151;

        /// <summary>
        /// Gets the calories of Fried Miraak
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 151;
                if (size == Size.Medium) calories = 236;
                if (size == Size.Large) calories = 306;
                return calories;
            }
        }

        /// <summary>
        /// The size of Fried Miraak
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of Fried Miraak
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
        /// Gets the special instructions for Fried Miraak
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
        /// <returns>The string representation of Fried Miraak</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Fried Miraak");
            return sb.ToString();
        }
    }
}
