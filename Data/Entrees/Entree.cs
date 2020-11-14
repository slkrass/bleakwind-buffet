/*
 * Author: Stephanie Krass
 * Class: Entree.cs
 * Purpose: Class used to represent the entree base class
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The item type
        /// </summary>
        public string ItemType => "Entree";
        
        /// <summary>
        /// The Name of the entree
        /// </summary>
        public abstract String Name { get; }

        /// <summary>
        /// The description of the entree
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Helper method for invoking PropertyChangeg.Invoke(..
        /// </summary>
        /// <param name="e"></param>
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
