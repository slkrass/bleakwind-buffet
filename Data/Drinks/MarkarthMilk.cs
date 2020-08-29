/*
 * Author: Stephanie Krass
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth Milk 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Markarth Milk
    /// </summary>
    public class MarkarthMilk
    {
        /// <summary>
        /// The price of Markarth Milk
        /// </summary>
        private double price = 1.05;

        /// <summary>
        /// Gets the price of Markarth Milk
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) price = 1.05;
                if (size == Size.Medium) price = 1.11;
                if (size == Size.Large) price = 1.22;
                return price;
            }
        }

        /// <summary>
        /// The calories of the Markarth Milk
        /// </summary>
        private uint calories = 56;

        /// <summary>
        /// Gets the calories of Markarth Milk
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 56;
                if (size == Size.Medium) calories = 72;
                if (size == Size.Large) calories = 93;
                return calories;
            }
        }

        /// <summary>
        /// The size of Markarth Milk
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of Markarth Milk
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
        /// If there is ice in Markarth Milk
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// Gets and sets if there is ice in Markarth Milk
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// Gets the special instructions for Markarth Milk
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>The string representation of Markarth Milk</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Markarth Milk");
            return sb.ToString();
        }
    }
}
