/*
 * Author: Stephanie Krass
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr Entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing a Double Draugr Burger
    /// </summary>
    public class DoubleDraugr
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 843;

        /// <summary>
        /// Holds whether or not there is ketchup on the burger
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Gets and sets whether there is ketchup on the burger
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                ketchup = value;
            }
        }

        /// <summary>
        /// Holds whether or not there a bun for the burger
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Gets and sets whether or not there is a bun
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                bun = value;
            }
        }

        /// <summary>
        /// Holds whether or not there is mustard on the burger
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Gets and sets whether or not there is mustard on the burger
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                mustard = value;
            }
        }

        /// <summary>
        /// Holds whether or not there is pickles on the burger
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Gets and sets whether or not there is pickles on the burger
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                pickle = value;
            }
        }

        /// <summary>
        /// Holds whether or not there is cheese on the burger
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Gets and sets whether or not there is cheese on the burger
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
            }
        }

        /// <summary>
        /// Holds whether or not there is tomato on the burger
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Gets and sets whether or not there is tomato on the burger
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
            }
        }

        /// <summary>
        /// Holds whether or not there is lettuce on the burger
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Gets and sets whether or not there is lettuce on the burger
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
            }
        }

        /// <summary>
        /// Holds whether or not there is mayo on the burger
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Gets and sets whether or not there is mayo on the burger
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
            }
        }
        /// <summary>
        /// Gets the special instructions for the burger
        /// </summary>
        public List<string> SpecialInstructions
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
        /// <returns>The string representation of Double Draugr Burger</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }


    }
}
