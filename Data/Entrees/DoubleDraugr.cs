/*
 * Author: Stephanie Krass
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr Entree
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing a Double Draugr Burger
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, ketchup, bun, 
    /// mustard, pickle, cheese, tomato, lettuce, mayo, and special 
    /// instructions for a Double Draugr Burger.
    /// </remarks>
    public class DoubleDraugr : Entree
    {


        /* Private variable declaration for the Double Draugr Burger */
        private bool ketchup = true;    // Holds whether or not there is ketchup on the burger
        private bool bun = true;        // Holds whether or not there a bun for the burger
        private bool mustard = true;    // Holds whether or not there is mustard on the burger
        private bool pickle = true;     // Holds whether or not there is pickles on the burger
        private bool cheese = true;     // Holds whether or not there is cheese on the burger
        private bool tomato = true;     // Holds whether or not there is tomato on the burger
        private bool lettuce = true;    // Holds whether or not there is lettuce on the burger
        private bool mayo = true;       // Holds whether or not there is mayo on the burger

        /// <summary>
        /// Gets the name of the burger
        /// </summary>
        public override string Name
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
        /// Gets the price of the burger
        /// </value>
        public override double Price => 7.32;

        /// <value>
        /// Gets the calories of the burger
        /// </value>
        public override uint Calories => 843;

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
        /// Gets and sets whether or not to hold tomato on the burger
        /// </value>
        public bool HoldTomato
        {
            get
            {
                return !tomato;
            }
            set
            {
                Tomato = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldTomato"));
            }
        }

        /// <value>
        /// Gets and sets whether or not tto hold lettuce on the burger
        /// </value>
        public bool HoldLettuce
        {
            get
            {
                return !lettuce;
            }
            set
            {
                Lettuce = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldLettuce"));
            }
        }

        /// <value>
        /// Gets and sets whether or not to hold mayo on the burger
        /// </value>
        public bool HoldMayo
        {
            get
            {
                return !mayo;
            }
            set
            {
                Mayo = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldMayo"));
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
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>
        /// The string representation of Double Draugr Burger
        /// </returns>
        public override string ToString()
        {
            return "Double Draugr";
        }


    }
}
