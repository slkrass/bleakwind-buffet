﻿/*
 * Author: Stephanie Krass
 * Class: Combo.cs
 * Purpose: This class is used to represent a combo meal consisting of a drink, entree and side
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories, and 
    /// special instructions for the combo meal.
    /// </remarks>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The item type
        /// </summary>
        public string ItemType => "";

        /* Private Variables */
        private Drink drink = new WarriorWater();
        private Entree entree = new BriarheartBurger();
        private Side side = new VokunSalad();
        
        /// <summary>
        /// The constructor for the Combo class
        /// </summary>
        public Combo()
        {
            entree.PropertyChanged += ItemChangeListener;
            drink.PropertyChanged += ItemChangeListener;
            side.PropertyChanged += ItemChangeListener;
        }

        /// <summary>
        /// The description of the combo
        /// </summary>
        public string Description => "";

        /// <summary>
        /// Gets the name of the Combo
        /// </summary>
        public string Name
        {
           get=>  "Combo";
        }
        /// <value>
        /// Gets the total price of the combo
        /// </value>
        public double Price
        {
            get 
            { 
                return drink.Price + entree.Price + side.Price - 1;
            }
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
        /// Gets the total calories of the combo
        /// </value>
        public uint Calories
        {
            get 
            {
                return drink.Calories + entree.Calories + side.Calories; 
            }
        }

        /// <value>
        /// Gets the special instructions for the combo
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                instructions.Add(entree.ToString());
                instructions.AddRange(entree.SpecialInstructions);

                instructions.Add(drink.ToString());
                instructions.AddRange(drink.SpecialInstructions);

                instructions.Add(side.ToString());

                return instructions;
            }
        }

        /// <value>
        /// Gets the drink for the combo
        /// </value>
        public Drink ComboDrink
        {
            get 
            { 
                return drink; 
            }
            set 
            {
                drink.PropertyChanged -= ItemChangeListener;
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ComboDrink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringPrice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                drink.PropertyChanged += ItemChangeListener;
            }
        }

        /// <value>
        /// Gets the entree for the combo
        /// </value>
        public Entree ComboEntree
        {
            get { return entree; }
            set 
            {

                entree.PropertyChanged -= ItemChangeListener;
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ComboEntree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringPrice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                entree.PropertyChanged += ItemChangeListener;
            }
        }

        /// <value>
        /// Gets the side for the combo
        /// </value>
        public Side ComboSide
        {
            get { return side; }
            set 
            {
                side.PropertyChanged -= ItemChangeListener;
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ComboSide"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringPrice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                side.PropertyChanged += ItemChangeListener;
            }
        }

        /// <summary>
        /// PropertyChange event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ItemChangeListener(object sender, PropertyChangedEventArgs e)
        {
            //Size, flavor, special instructions
            if(e.PropertyName == "Size")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringPrice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
            else if(e.PropertyName == "Flavor")
            {
               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
            else if(e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringPrice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            else
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringPrice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

    }
}
