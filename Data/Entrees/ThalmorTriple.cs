/*
 * Author: Stephanie Krass
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple Burger
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing a Thalmor Triple
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, ketchup, bun, 
    /// mustard, pickle, cheese, tomato, lettuce, mayo, bacon, egg, 
    /// and special instructions for a Thalmor Triple Burger.
    /// </remarks>
    public class ThalmorTriple : Entree
    {

        /* Private variable declaration for the Thalmor Triple Burger */
        private bool ketchup = true;    // Holds whether or not there is ketchup on the burger
        private bool bun = true;        // Holds whether or not there a bun for the burger
        private bool mustard = true;    // Holds whether or not there is mustard on the burger
        private bool pickle = true;     // Holds whether or not there is pickles on the burger
        private bool cheese = true;     // Holds whether or not there is cheese on the burger
        private bool tomato = true;     // Holds whether or not there is tomato on the burger
        private bool lettuce = true;    // Holds whether or not there is lettuce on the burger
        private bool mayo = true;       // Holds whether or not there is mayo on the burger
        private bool bacon = true;      // Holds whether or not there is bacon on the burger
        private bool egg = true;        // Holds whether or not there is egg on the burger

        /// <value>
        /// Gets the price of the burger
        /// </value>
        public override double Price => 8.32;

        /// <value>
        /// Gets the calories of the burger
        /// </value>
        public override uint Calories => 943;

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
            }
        }

        /// <value>
        /// Gets and sets whether or not there is tomato on the burger
        /// </value>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Tomato"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is lettuce on the burger
        /// </value>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Lettuce"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is mayo on the burger
        /// </value>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Mayo"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is bacon on the burger
        /// </value>
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                bacon = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Bacon"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is egg on the burger
        /// </value>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Egg"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
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
                if (!tomato) instructions.Add("Hold tomato");
                if (!lettuce) instructions.Add("Hold lettuce");
                if (!mayo) instructions.Add("Hold mayo");
                if (!bacon) instructions.Add("Hold bacon");
                if (!egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>
        /// The string representation of Thalmor Triple Burger
        /// </returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }

    }
}
