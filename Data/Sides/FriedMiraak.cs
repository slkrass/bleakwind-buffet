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
    /// <remarks>
    /// This class keeps track of the price, calories, size, 
    /// and special instructions for a Fried Miraak.
    /// </remarks>
    public class FriedMiraak
    {
        /* Private variable declaration for the Fried Miraak */
        private double price = 1.78;    // The price of Fried Miraak
        private uint calories = 151;    // The calories of the Fried Miraak
        private Size size = Size.Small; // The size of Fried Miraak

        /// <value>
        /// Gets the price of Fried Miraak
        /// </value>
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

        /// <value>
        /// Gets the calories of Fried Miraak
        /// </value>
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

        /// <value>
        /// Gets and sets the size of Fried Miraak
        /// </value>
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

        /// <value>
        /// Gets the special instructions for Fried Miraak
        /// </value>
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
        /// <returns>
        /// The string representation of Fried Miraak
        /// </returns>
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
