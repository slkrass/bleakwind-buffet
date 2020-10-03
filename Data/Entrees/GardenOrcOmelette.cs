﻿/*
 * Author: Stephanie Krass
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Garden Orc Omelette
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, broccoli, mushrooms, 
    /// tomato, cheddar, and special instructions for a Garden Orc Omelette.
    /// </remarks>
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /* Private variable declaration for the Garden Orc Omelette */
        private bool broccoli = true; // Holds whether or not there is broccoli on the omelette
        private bool mushrooms = true; // Holds whether or not there is mushrooms on the omelette
        private bool tomato = true; // Holds whether or not there is tomato on the omelette
        private bool cheddar = true; // Holds whether or not there is cheddar on the omelette


        /// <value>
        /// Gets the price of the omelette
        /// </value>
        public override double Price => 4.57;

        /// <value>
        /// Gets the calories of the omelette
        /// </value>
        public override uint Calories => 404;

        /// <value>
        /// Gets and sets whether there is broccoli on the omelette
        /// </value>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }

            set
            {
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is mushrooms on the omelette
        /// </value>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }

            set
            {
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is tomato on the omelette
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not there is cheddar on the omelette
        /// </value>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }

            set
            {
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets the special instructions for the omelette
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <returns>
        /// The string representation of Garden Orc Omelette
        /// </returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
