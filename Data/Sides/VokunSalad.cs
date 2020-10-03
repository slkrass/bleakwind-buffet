/*
 * Author: Stephanie Krass
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing Vokun Salad
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, size, 
    /// and special instructions for a Vokun Salad.
    /// </remarks>
    public class VokunSalad : Side, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /* Private variable declaration for the Vokun Salad */
        private double price = 0.93;    // The price of Vokun Salad
        private uint calories = 41;     // The calories of the Vokun Salad
        private Size size = Size.Small; // The size of Vokun Salad

        /// <value>
        /// Gets the price of Vokun Salad
        /// </value>
        public override double Price
        {
            get
            {
                if (size == Size.Small) price = 0.93;
                if (size == Size.Medium) price = 1.28;
                if (size == Size.Large) price = 1.82;
                return price;
            }
        }

        /// <value>
        /// Gets the calories of Vokun Salad
        /// </value>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 41;
                if (size == Size.Medium) calories = 52;
                if (size == Size.Large) calories = 73;
                return calories;
            }
        }

        /// <value>
        /// Gets and sets the size of Vokun Salad
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <value>
        /// Gets the special instructions for Vokun Salad
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
        /// The string representation of Vokun Salad
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Vokun Salad");
            return sb.ToString();
        }
    }
}
