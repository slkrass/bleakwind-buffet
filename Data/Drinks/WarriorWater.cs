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
    /// A class representing Warrior Water.
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, size, ice, lemon, 
    /// and special instructions for a Warrior Water.
    /// </remarks>
    public class WarriorWater : Drink
    {
        /* Private variable declaration for the  Warrior Water */
        private double price = 0;       // The price of Warrior Water
        private uint calories = 0;      // The calories of the Warrior Water
        private Size size = Size.Small; // The size of Warrior Water
        private bool ice = true;        // If there is ice in Warrior Water
        private bool lemon = false;     // If there is lemon in Warrior Water

        /// <value>
        /// Gets the price of Warrior Water
        /// </value>
        public override double Price
        {
            get
            {
                return price;
            }
        }

        /// <value>
        /// Gets the calories of Warrior Water
        /// </value>
        public override uint Calories
        {
            get
            {
                return calories;
            }
        }

        /// <value>
        /// Gets and sets the size of Warrior Water
        /// </value>
        public override Size Size
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
        /// Gets and sets if there is ice in Warrior Water
        /// </value>
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

        /// <value>
        /// Gets and sets if there is lemon in Warrior Water
        /// </value>
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

        /// <value>
        /// Gets the special instructions for Warrior Water
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <returns>
        /// The string representation of Warrior Water
        /// </returns>
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
