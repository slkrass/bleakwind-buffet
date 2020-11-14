/*
 * Author: Stephanie Krass
 * Class: Drink.cs
 * Purpose: Class used to represent the drink base class
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The item type
        /// </summary>
        public string ItemType => "Drink";

        /// <summary>
        /// The Name of the drink
        /// </summary>
        public abstract String Name { get; }

        /// <summary>
        /// The description of the drink
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions to prepare the drink
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
