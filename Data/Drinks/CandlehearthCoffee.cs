/*
 * Author: Stephanie Krass
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing the Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee
    {
        /// <summary>
        /// The price of Candlehearth Coffee
        /// </summary>
        private double price = 0.75;

        /// <summary>
        /// Gets the price of Candlehearth Coffee
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) price = 0.75;
                if (size == Size.Medium) price = 1.25;
                if (size == Size.Large) price = 1.75;
                return price;
            }
        }

        /// <summary>
        /// The calories of the Candlehearth Coffee
        /// </summary>
        private uint calories = 7;

        /// <summary>
        /// Gets the calories of Candlehearth Coffee
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 7;
                if (size == Size.Medium) calories = 10;
                if (size == Size.Large) calories = 20;
                return calories;
            }
        }

        /// <summary>
        /// The size of Candlehearth Coffee
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of Candlehearth Coffee
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
        /// If there is ice in Candlehearth Coffee
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// Gets and sets if there is ice in Candlehearth Coffee
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
        /// If there is room for cream in Candlehearth Coffee
        /// </summary>
        private bool roomForCream = false;

        /// <summary>
        /// Gets and sets if there is room for cream in Candlehearth Coffee
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }

            set
            {
                roomForCream = value;
            }
        }

        /// <summary>
        /// If the coffee is decaf Candlehearth Coffee
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// Gets and sets if the coffee is decaf Candlehearth Coffee
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }

            set
            {
                decaf = value;
            }
        }

        /// <summary>
        /// Gets the special instructions for Candlehearth Coffee
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (ice) instructions.Add("Add ice");
                if (roomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>The string representation of Candlehearth Coffee</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            if (decaf) sb.Append("Decaf ");
            
            sb.Append("Candlehearth Coffee");
            return sb.ToString();
        }
    }
}
