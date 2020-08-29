/*
 * Author: Stephanie Krass
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class used to represent the Arentino Apple Juice
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Arentino Apple Juice
    /// </summary>
    public class AretinoAppleJuice
    {
        /// <summary>
        /// The price of Arentino Apple Juice
        /// </summary>
        private double price = 0.62;

        /// <summary>
        /// Gets the price of Arentino Apple Juice
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) price = 0.62;
                if (size == Size.Medium) price = 0.87;
                if (size == Size.Large) price = 1.01;
                return price;
            }
        }

        /// <summary>
        /// The calories of the Arentino Apple Juice
        /// </summary>
        private uint calories = 44;

        /// <summary>
        /// Gets the calories of Arentino Apple Juice
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 44;
                if (size == Size.Medium) calories = 88;
                if (size == Size.Large) calories = 132;
                return calories;
            }
        }

        /// <summary>
        /// The size of Arentino Apple Juice
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of Arentino Apple Juice
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
        /// If there is ice in Arentino Apple Juice
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// Gets and sets if there is ice in Arentino Apple Juice
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
        /// Gets the special instructions for Arentino Apple Juice
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
        /// <returns>The string representation of Arentino Apple Juice</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Arentino Apple Juice");
            return sb.ToString();
        }
    }
}
