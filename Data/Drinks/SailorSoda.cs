/*
 * Author: Stephanie Krass
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor's Soda
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Sailor's Soda
    /// </summary>
    public class SailorSoda
    {
        /// <summary>
        /// The price of Sailor's soda
        /// </summary>
        private double price = 1.42;

        /// <summary>
        /// Gets the price of Sailor's Soda
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) price = 1.42;
                if (size == Size.Medium) price = 1.74;
                if (size == Size.Large) price = 2.07;
                return price;
            }
        }

        /// <summary>
        /// The calories of the Sailor's Soda
        /// </summary>
        private uint calories = 117;

        /// <summary>
        /// Gets the calories of Sailor's Soda
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 117;
                if (size == Size.Medium) calories = 153;
                if (size == Size.Large) calories = 205;
                return calories;
            }
        }

        /// <summary>
        /// The size of Sailor's Soda
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of Sailor's Soda
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
        /// If there is ice in Sailor's Soda
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// Gets and sets if there is ice in Sailor's Soda
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
        /// The flavor of the soda
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }

            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Gets the special instructions for Sailor's Soda
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>The string representation of Sailor's Soda</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            if (flavor == SodaFlavor.Blackberry) sb.Append("Blackberry ");
            if (flavor == SodaFlavor.Cherry) sb.Append("Cherry ");
            if (flavor == SodaFlavor.Grapefruit) sb.Append("Grapefruit ");
            if (flavor == SodaFlavor.Lemon) sb.Append("Lemon ");
            if (flavor == SodaFlavor.Peach) sb.Append("Peach ");
            if (flavor == SodaFlavor.Watermelon) sb.Append("Watermelon ");

            sb.Append("Sailor Soda");
            return sb.ToString();
        }
    }
}
