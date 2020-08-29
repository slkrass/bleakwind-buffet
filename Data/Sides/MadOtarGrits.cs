/*
 * Author: Stephanie Krass
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// The price of Mad Otar Grits
        /// </summary>
        private double price = 1.22;

        /// <summary>
        /// Gets the price of Mad Otar Grits
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) price = 1.22;
                if (size == Size.Medium) price = 1.58;
                if (size == Size.Large) price = 1.93;
                return price;
            }
        }

        /// <summary>
        /// The calories of the Mad Otar Grits
        /// </summary>
        private uint calories = 105;

        /// <summary>
        /// Gets the calories of Mad Otar Grits
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 105;
                if (size == Size.Medium) calories = 142;
                if (size == Size.Large) calories = 179;
                return calories;
            }
        }

        /// <summary>
        /// The size of Mad Otar Grits
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of Mad Otar Grits
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
        /// Gets the special instructions for Mad Otar Grits
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
        /// <returns>The string representation of Mad Otar Grits</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Mad Otar Grits");
            return sb.ToString();
        }
    }
}
