/*
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
    public class GardenOrcOmelette : Entree
    {

        /* Private variable declaration for the Garden Orc Omelette */
        private bool broccoli = true; // Holds whether or not there is broccoli on the omelette
        private bool mushrooms = true; // Holds whether or not there is mushrooms on the omelette
        private bool tomato = true; // Holds whether or not there is tomato on the omelette
        private bool cheddar = true; // Holds whether or not there is cheddar on the omelette

        /// <summary>
        /// Gets the name of the omelette
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
                OnPropertyChanged(new PropertyChangedEventArgs("Broccoli"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Mushrooms"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Tomato"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Cheddar"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether to hold broccoli on the omelette
        /// </value>
        public bool HoldBroccoli
        {
            get
            {
                return !broccoli;
            }

            set
            {
                Broccoli = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldBroccoli"));
            }
        }

        /// <value>
        /// Gets and sets whether or not to hold mushrooms on the omelette
        /// </value>
        public bool HoldMushrooms
        {
            get
            {
                return !mushrooms;
            }

            set
            {
                Mushrooms = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldMushrooms"));
            }
        }

        /// <value>
        /// Gets and sets whether or not to hold tomato on the omelette
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
        /// Gets and sets whether or not to hold cheddar on the omelette
        /// </value>
        public bool HoldCheddar
        {
            get
            {
                return !cheddar;
            }

            set
            {
                Cheddar = !value;
                OnPropertyChanged(new PropertyChangedEventArgs("HoldCheddar"));
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
