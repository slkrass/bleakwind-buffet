/*
 * Author: Stephanie Krass
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing the Candlehearth Coffee.
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, size, ice, room for cream, 
    /// caffination, and special instructions for a Candlehearth Coffee.
    /// </remarks>
    public class CandlehearthCoffee : Drink
    {

        /* Private variable declaration for the Candlehearth Coffee */
        private double price = 0.75;        // The price of Candlehearth Coffee
        private uint calories = 7;          // The calories of the Candlehearth Coffee
        private Size size = Size.Small;     // The size of Candlehearth Coffee
        private bool ice = false;           // If there is ice in Candlehearth Coffee
        private bool roomForCream = false;  // If there is room for cream in Candlehearth Coffee
        private bool decaf = false;         // If the coffee is decaf Candlehearth Coffee

        /// <value>
        /// Gets the price of Candlehearth Coffee
        /// </value>
        public override double Price
        {
            get
            {
                if (size == Size.Small) price = 0.75;
                if (size == Size.Medium) price = 1.25;
                if (size == Size.Large) price = 1.75;
                return price;
            }
        }

        /// <value>
        /// Gets the calories of Candlehearth Coffee
        /// </value>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 7;
                if (size == Size.Medium) calories = 10;
                if (size == Size.Large) calories = 20;
                return calories;
            }
        }

        /// <value>
        /// Gets and sets the size of Candlehearth Coffee
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
        /// Gets and sets if there is ice in Candlehearth Coffee
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
        /// Gets and sets if there is room for cream in Candlehearth Coffee
        /// </value>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }

            set
            {
                roomForCream = value;

                OnPropertyChanged(new PropertyChangedEventArgs("RoomForCream"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets if the coffee is decaf Candlehearth Coffee
        /// </value>
        public bool Decaf
        {
            get
            {
                return decaf;
            }

            set
            {
                decaf = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Decaf"));
            }
        }

        /// <value>
        /// Gets the special instructions for Candlehearth Coffee
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <returns>
        /// The string representation of Candlehearth Coffee
        /// </returns>
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
