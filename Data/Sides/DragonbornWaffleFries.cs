/*
 * Author: Stephanie Krass
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing Dragonborn Waffle Fries
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, size, 
    /// and special instructions for a Dragonborn Waffle Fries.
    /// </remarks>
    public class DragonbornWaffleFries : Side
    {

        /* Private variable declaration for the Dragonborn Waffle Fries */
        private double price = 0.42;        // The price of Dragonborn Waffle Fries
        private uint calories = 77;         // The calories of the Dragonborn Waffle Fries
        private Size size = Size.Small;     // The size of Dragonborn Waffle Fries

        /// <summary>
        /// Gets the name of the fries
        /// </summary>
        public string Name
        {
            get => this.ToString();
        }

        /// <summary>
        /// Gets the string representation of Price
        /// </summary>
        public string StringPrice
        {
            get
            {
                return "$" + string.Format("{0:0.00}", Price);
            }
        }

        /// <summary>
        /// Gets a string representation of the SpecialInstructions
        /// </summary>
        public string StringSpecialInstructions
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                return sb.ToString();
            }
        }

        /// <value>
        /// Gets the price of Dragonborn Waffle Fries
        /// </value>
        public override double Price
        {
            get
            {
                if (size == Size.Small) price = 0.42;
                if (size == Size.Medium) price = 0.76;
                if (size == Size.Large) price = 0.96;
                return price;
            }
        }

        /// <value>
        /// Gets the calories of Dragonborn Waffle Fries
        /// </value>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 77;
                if (size == Size.Medium) calories = 89;
                if (size == Size.Large) calories = 100;
                return calories;
            }
        }

        /// <value>
        /// Gets and sets the size of Dragonborn Waffle Fries
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
                OnPropertyChanged(new PropertyChangedEventArgs("Size"));
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringPrice"));
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        /// <value>
        /// Gets the special instructions for Dragonborn Waffle Fries
        /// </value>
        public override List<string> SpecialInstructions
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
        /// The string representation of Dragonborn Waffle Fries
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Dragonborn Waffle Fries");
            return sb.ToString();
        }
    }
}
