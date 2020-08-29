/*
 * Author: Stephanie Krass
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Holds whether or not there is broccoli on the omelette
        /// </summary>
        private bool broccoli = true;

        /// <summary>
        /// Gets and sets whether there is broccoli on the omelette
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }

            set
            {
                broccoli = value;
            }
        }

        /// <summary>
        /// Holds whether or not there is mushrooms on the omelette
        /// </summary>
        private bool mushrooms = true;

        /// <summary>
        /// Gets and sets whether or not there is mushrooms on the omelette
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }

            set
            {
                mushrooms = value;
            }
        }

        /// <summary>
        /// Holds whether or not there is tomato on the omelette
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Gets and sets whether or not there is tomato on the omelette
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
        /// Holds whether or not there is cheddar on the omelette
        /// </summary>
        private bool cheddar = true;

        /// <summary>
        /// Gets and sets whether or not there is cheddar on the omelette
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }

            set
            {
                cheddar = value;
            }
        }

        /// <summary>
        /// Gets the special instructions for the omelette
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                
                if (!broccoli) instructions.Add("Hold broccoli");
                if (!mushrooms) instructions.Add("Hold mushrooms");
                if (!tomato) instructions.Add("Hold tomato");
                if (!cheddar) instructions.Add("Hold cheddar");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>The string representation of Garden Orc Omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
