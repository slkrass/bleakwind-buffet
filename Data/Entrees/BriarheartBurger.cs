/*
 * Author: Stephanie Krass
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger Entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Briarheart Burger 
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, ketchup, bun, 
    /// mustard, pickle, cheese, and special instructions for a Briarheart Burger.
    /// </remarks>
    public class BriarheartBurger : Entree
    {

        /* Private variable declaration for the Briarheart Burger */
        private bool ketchup = true;    // Holds whether or not there is ketchup on the burger
        private bool bun = true;        // Holds whether or not there a bun for the burger
        private bool mustard = true;    // Holds whether or not there is mustard on the burger
        private bool pickle = true;     // Holds whether or not there is pickles on the burger
        private bool cheese = true;     // Holds whether or not there is cheese on the burger

        /// <value>
        /// Gets the price of the burger
        /// </value>
        public override double Price => 6.32;

        /// <value>
        /// Gets the calories of the burger
        /// </value>
        public override uint Calories => 743;

        /// <summary>
        /// Gets the name of the burger
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
                foreach (String s in SpecialInstructions)
                {
                    sb.Append("- " + s + "\n");
                }
                return sb.ToString();
            }
        }

        /// <value>
        /// Gets and sets whether there is ketchup on the burger
        /// </value>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                ketchup = value;

                OnPropertyChanged(new PropertyChangedEventArgs("Ketchup"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is a bun
        /// </value>
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                bun = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Bun"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is mustard on the burger
        /// </value>
        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                mustard = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Mustard"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is pickles on the burger
        /// </value>
        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                pickle = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Pickle"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is cheese on the burger
        /// </value>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Cheese"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether hold ketchup on the burger
        /// </value>
        public bool HoldKetchup
        {
            get
            {
                return !ketchup;
            }

            set
            {
                Ketchup = !value;

                OnPropertyChanged(new PropertyChangedEventArgs("HoldKetchup"));
            }
        }

        /// <value>
        /// Gets and sets whether to hold the bun
        /// </value>
        public bool HoldBun
        {
            get
            {
                return !bun;
            }

            set
            {
                Bun = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldBun"));
            }
        }

        /// <value>
        /// Gets and sets whether or not to hold mustard on the burger
        /// </value>
        public bool HoldMustard
        {
            get
            {
                return !mustard;
            }

            set
            {
                Mustard = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldMustard"));
            }
        }

        /// <value>
        /// Gets and sets whether or not to hold pickles on the burger
        /// </value>
        public bool HoldPickle
        {
            get
            {
                return !pickle;
            }

            set
            {
                Pickle = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldPickle"));
            }
        }

        /// <value>
        /// Gets and sets whether or not to hold cheese on the burger
        /// </value>
        public bool HoldCheese
        {
            get
            {
                return !cheese;
            }
            set
            {
                Cheese = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldCheese"));
            }
        }

        /// <value>
        /// Gets the special instructions for the burger
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!bun) instructions.Add("Hold bun");
                if (!ketchup) instructions.Add("Hold ketchup");
                if (!mustard) instructions.Add("Hold mustard");
                if (!pickle) instructions.Add("Hold pickle"); 
                if (!cheese) instructions.Add("Hold cheese");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>
        /// The string representation of Briarheart Burger
        /// </returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }


    }
}
