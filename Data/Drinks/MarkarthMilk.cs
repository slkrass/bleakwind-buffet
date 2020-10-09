/*
 * Author: Stephanie Krass
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth Milk 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Markarth Milk.
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, size, ice, 
    /// and special instructions for a Markarth Milk.
    /// </remarks>
    public class MarkarthMilk : Drink
    {

        /* Private variable declaration for the Markarth Milk */
        private double price = 1.05;        // The price of Markarth Milk
        private uint calories = 56;         // The calories of the Markarth Milk
        private Size size = Size.Small;     // The size of Markarth Milk
        private bool ice = false;           // If there is ice in Markarth Milk

        /// <summary>
        /// Gets the name of the markarth milk
        /// </summary>
        public string Name
        {
            get => this.ToString();
        }

        /// <summary>
        /// Gets a string representation of the SpecialInstructions
        /// </summary>
        public string StringSpecialInstructions
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (String s in SpecialInstructions)
                {
                    sb.Append("- " + s + "\n");
                }
                return sb.ToString();
            }
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

        /// <value>
        /// Gets the price of Markarth Milk
        /// </value>
        public override double Price
        {
            get
            {
                if (size == Size.Small) price = 1.05;
                if (size == Size.Medium) price = 1.11;
                if (size == Size.Large) price = 1.22;
                return price;
            }
        }

        /// <value>
        /// Gets the calories of Markarth Milk
        /// </value>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 56;
                if (size == Size.Medium) calories = 72;
                if (size == Size.Large) calories = 93;
                return calories;
            }
        }

        /// <value>
        /// Gets and sets the size of Markarth Milk
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
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets if there is ice in Markarth Milk
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
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets the special instructions for Markarth Milk
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

        /// <value>
        /// Overrides the ToString method to return a custom string
        /// </value>
        /// <returns>
        /// The string representation of Markarth Milk
        /// </returns>
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
