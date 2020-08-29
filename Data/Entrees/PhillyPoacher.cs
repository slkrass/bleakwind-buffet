/*
 * Author: Stephanie Krass
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Philly Poacher (Philly cheesesteak sandwhich)
    /// </summary>
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the Philly Poacher
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the calories of the Philly Poacher
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Holds whether or not there is sirloin on the Philly Poacher
        /// </summary>
        private bool sirloin = true;

        /// <summary>
        /// Gets and sets whether there is sirloin on the Philly Poacher
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }

            set
            {
                sirloin = value;
            }
        }

        /// <summary>
        /// Holds whether or not there onion for the Philly Poacher
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Gets and sets whether or not there is a onion on the Philly Poacher
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                onion = value;
            }
        }

        /// <summary>
        /// Holds whether or not there is roll on the Philly Poacher
        /// </summary>
        private bool roll = true;

        /// <summary>
        /// Gets and sets whether or not there is roll on the Philly Poacher
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
            }
        }


        /// <summary>
        /// Gets the special instructions for the Philly Poacher
        /// </summary>
        public List<string> SpecialInstructions
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
        /// <returns>The string representation of Philly Poacher</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}
