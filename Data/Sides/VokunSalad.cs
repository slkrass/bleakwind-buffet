/*
 * Author: Stephanie Krass
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing Vokun Salad
    /// </summary>
    public class VokunSalad
    {
        /// <summary>
        /// The price of Vokun Salad
        /// </summary>
        private double price = 0.93;

        /// <summary>
        /// Gets the price of Vokun Salad
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) price = 0.93;
                if (size == Size.Medium) price = 1.28;
                if (size == Size.Large) price = 1.82;
                return price;
            }
        }

        /// <summary>
        /// The calories of the Vokun Salad
        /// </summary>
        private uint calories = 41;

        /// <summary>
        /// Gets the calories of Vokun Salad
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 41;
                if (size == Size.Medium) calories = 52;
                if (size == Size.Large) calories = 73;
                return calories;
            }
        }

        /// <summary>
        /// The size of Vokun Salad
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of Vokun Salad
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
        /// Gets the special instructions for Vokun Salad
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
        /// <returns>The string representation of Vokun Salad</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Vokun Salad");
            return sb.ToString();
        }
    }
}
