/*
 * Author: Stephanie Krass
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor's Soda
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing Sailor's Soda.
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, size, ice, flavor, 
    /// and special instructions for a Sailor's Soda.
    /// </remarks>
    public class SailorSoda : Drink
    {
        /* Private variable declaration for the Sailor's Soda */
        private double price = 1.42;                    // The price of Sailor's soda
        private uint calories = 117;                    // The calories of the Sailor's Soda
        private Size size = Size.Small;                 // The size of Sailor's Soda
        private bool ice = true;                        // If there is ice in Sailor's Soda
        private SodaFlavor flavor = SodaFlavor.Cherry;  // The flavor of the soda

        /// <summary>
        /// Gets the name of the Sailor's Soda
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

        /// <value>
        /// Gets the price of Sailor's Soda
        /// </value>
        public override double Price
        {
            get
            {
                if (size == Size.Small) price = 1.42;
                if (size == Size.Medium) price = 1.74;
                if (size == Size.Large) price = 2.07;
                return price;
            }
        }

        /// <value>
        /// Gets the calories of Sailor's Soda
        /// </value>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) calories = 117;
                if (size == Size.Medium) calories = 153;
                if (size == Size.Large) calories = 205;
                return calories;
            }
        }

        /// <value>
        /// Gets and sets the size of Sailor's Soda
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
        /// Gets and sets if there is ice in Sailor's Soda
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

        /// <summary>
        /// Gets and sets the opposite of Ice in order to work around checkboxes
        /// </summary>
        public bool HoldIce
        {
            get { return !ice; }
            set
            {
                Ice = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldIce"));
            }
        }

        /// <value>
        /// Gets and sets the flavor of the Sailor's Soda
        /// </value>
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }

            set
            {
                flavor = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Flavor"));
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        /// <value>
        /// Gets the special instructions for Sailor's Soda
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <returns>
        /// The string representation of Sailor's Soda
        /// </returns>
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
