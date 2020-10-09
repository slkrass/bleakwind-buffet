/*
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

        /* Private Variables */
        //private double price = 0;
        //private uint calories = 0;
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
                entree.PropertyChanged += ItemChangeListener;
                //Iprop to notify the calories and price and special instructions
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
                side.PropertyChanged += ItemChangeListener;

                //listen for property changed event
                //side.PropertyChanged += ItemChangeListener;
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
            if(e.PropertyName == "Size" )
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
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
            }
        }

    }
}
