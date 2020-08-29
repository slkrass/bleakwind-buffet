/*
 * Author: Stephanie Krass
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Warrior Water
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// The price of Warrior Water
        /// </summary>
        private double price = 0;

        /// <summary>
        /// Gets the price of Warrior Water
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }
        }

        /// <summary>
        /// The calories of the Warrior Water
        /// </summary>
        private uint calories = 0;

        /// <summary>
        /// Gets the calories of Warrior Water
        /// </summary>
        public uint Calories
        {
            get
            {
                return calories;
            }
        }

        /// <summary>
        /// The size of Warrior Water
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of Warrior Water
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
        /// If there is ice in Warrior Water
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// Gets and sets if there is ice in Warrior Water
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
        /// If there is lemon in Warrior Water
        /// </summary>
        private bool lemon = false;

        /// <summary>
        /// Gets and sets if there is lemon in Warrior Water
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }

            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// Gets the special instructions for Warrior Water
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!ice) instructions.Add("Hold ice");
                if (lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>The string representation of Warrior Water</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Warrior Water");
            return sb.ToString();
        }
    }
}
