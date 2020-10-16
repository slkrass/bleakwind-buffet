/*
 * Author: Stephanie Krass
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Philly Poacher (Philly cheesesteak sandwhich)
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, sirloin, onion, roll, 
    /// and special instructions for a Philly Poacher.
    /// </remarks>
    public class PhillyPoacher : Entree
    {

        /* Private variable declaration for the Philly Poacher */
        private bool sirloin = true;    // Holds whether or not there is sirloin on the Philly Poacher
        private bool onion = true;      // Holds whether or not there onion for the Philly Poacher
        private bool roll = true;       // Holds whether or not there is roll on the Philly Poacher

        /// <summary>
        /// Gets the name of the philly poacher
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
        /// Gets the price of the Philly Poacher
        /// </value>
        public override double Price => 7.23;

        /// <value>
        /// Gets the calories of the Philly Poacher
        /// </value>
        public override uint Calories => 784;

        /// <value>
        /// Gets and sets whether there is sirloin on the Philly Poacher
        /// </value>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }

            set
            {
                sirloin = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Sirloin"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is a onion on the Philly Poacher
        /// </value>
        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                onion = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Onion"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is roll on the Philly Poacher
        /// </value>
        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Roll"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether to hold sirloin on the Philly Poacher
        /// </value>
        public bool HoldSirloin
        {
            get
            {
                return !sirloin;
            }

            set
            {
                Sirloin = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldSirloin"));
            }
        }

        /// <value>
        /// Gets and sets whether or not to hold onion on the Philly Poacher
        /// </value>
        public bool HoldOnion
        {
            get
            {
                return !onion;
            }

            set
            {
                Onion = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldOnion"));
            }
        }

        /// <value>
        /// Gets and sets whether or not to hold roll on the Philly Poacher
        /// </value>
        public bool HoldRoll
        {
            get
            {
                return !roll;
            }

            set
            {
                Roll = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldRoll"));
            }
        }

        /// <value>
        /// Gets the special instructions for the Philly Poacher
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!sirloin) instructions.Add("Hold sirloin");
                if (!onion) instructions.Add("Hold onions");
                if (!roll) instructions.Add("Hold roll");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns
        /// >The string representation of Philly Poacher
        /// </returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}
