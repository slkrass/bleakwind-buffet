/*
 * Author: Stephanie Krass
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Aretino Apple Juice.
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, size, ice, 
    /// and special instructions for an Aretino Apple Juice.
    /// </remarks>
    public class AretinoAppleJuice : Drink
    {

        /* Private variable declaration for the Aretino Apple Juice */
        private double price = 0.62;    // The price of Aretino Apple Juice
        private uint calories = 44;     // The calories of the Aretino Apple Juice
        private Size size = Size.Small; // The size of Aretino Apple Juice
        private bool ice = false;       // If there is ice in Aretino Apple Juice

        /// <value>
        /// Gets the price of Aretino Apple Juice
        /// </value>
        public override double Price
        {
            get
            {
                if (size == Size.Small) price = 0.62;
                if (size == Size.Medium) price = 0.87;
                if (size == Size.Large) price = 1.01;
                return price;
            }
        }

        /// <value>
        /// Gets the calories of Aretino Apple Juice
        /// </value>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 44;
                if (size == Size.Medium) calories = 88;
                if (size == Size.Large) calories = 132;
                return calories;
            }
        }

        /// <value>
        /// Gets and sets the size of Aretino Apple Juice
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
            }
        }

        /// <value>
        /// Gets and sets if there is ice in Aretino Apple Juice
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

                OnPropertyChanged(new PropertyChangedEventArgs("Ice"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets the special instructions for Aretino Apple Juice
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <returns>
        /// The string representation of Aretino Apple Juice
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Aretino Apple Juice");
            return sb.ToString();
        }
    }
}
