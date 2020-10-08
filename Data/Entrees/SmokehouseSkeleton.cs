/*
 * Author: Stephanie Krass
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Smokehouse Skeleton
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, sausage links, egg,
    /// hash browns, pancakes, and special instructions for a Smokehouse Skeleton.
    /// </remarks>
    public class SmokehouseSkeleton : Entree
    {

        /* Private variable declaration for the Smokehouse Skeleton */
        private bool sausageLink = true;    // Holds whether or not the breakfast combo has sausage links
        private bool egg = true;            // Holds whether or not the breakfast combo has eggs
        private bool hashBrowns = true;     // Holds whether or not the breakfast combo has hash browns
        private bool pancake = true;        // Holds whether or not the breakfast combo has pancakes

        /// <value>
        /// Gets the price of the breakfast combo
        /// </value>
        public override double Price => 5.62;

        /// <value>
        /// Gets the calories of the breakfast combo
        /// </value>
        public override uint Calories => 602;

        /// <value>
        /// Gets and sets whether the breakfast combo has sausage links
        /// </value>
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }

            set
            {
                sausageLink = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SausageLink"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not the breakfast combo has eggs
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
        /// Gets and sets whether or not the breakfast combo has hash browns
        /// </value>
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }

            set
            {
                hashBrowns = value;
                OnPropertyChanged(new PropertyChangedEventArgs("HashBrowns"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets and sets whether or not the breakfast combo has pancakes
        /// </value>
        public bool Pancake
        {
            get
            {
                return pancake;
            }

            set
            {
                pancake = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Pancake"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Gets the special instructions for the the breakfast combo
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!sausageLink) instructions.Add("Hold sausage");
                if (!egg) instructions.Add("Hold eggs");
                if (!hashBrowns) instructions.Add("Hold hash browns");
                if (!pancake) instructions.Add("Hold pancakes");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>
        /// The string representation of Smokehouse Skeleton
        /// </returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

    }
}
