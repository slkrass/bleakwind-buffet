/*
 * Author: Stephanie Krass
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing Mad Otar Grits
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, size, 
    /// and special instructions for a Mad Otar Grits.
    /// </remarks>
    public class MadOtarGrits : Side, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /* Private variable declaration for the Mad Otar Grits */
        private double price = 1.22;    // The price of Mad Otar Grits
        private uint calories = 105;    // The calories of the Mad Otar Grits
        private Size size = Size.Small; // The size of Mad Otar Grits

        /// <value>
        /// Gets the price of Mad Otar Grits
        /// </value>
        public override double Price
        {
            get
            {
                if (size == Size.Small) price = 1.22;
                if (size == Size.Medium) price = 1.58;
                if (size == Size.Large) price = 1.93;
                return price;
            }
        }

        /// <value>
        /// Gets the calories of Mad Otar Grits
        /// </value>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 105;
                if (size == Size.Medium) calories = 142;
                if (size == Size.Large) calories = 179;
                return calories;
            }
        }

        /// <value>
        /// Gets and sets the size of Mad Otar Grits
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
        /// Gets the special instructions for Mad Otar Grits
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
        /// The string representation of Mad Otar Grits
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (size == Size.Small) sb.Append("Small ");
            if (size == Size.Medium) sb.Append("Medium ");
            if (size == Size.Large) sb.Append("Large ");

            sb.Append("Mad Otar Grits");
            return sb.ToString();
        }
    }
}
