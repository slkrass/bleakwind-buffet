/*
 * Author: Stephanie Krass
 * Class: IOrderItem.cs
 * Purpose: An interface used to represent the menu order items
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface of things found on the menu
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the order item
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the order item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The special instructions to prepare the order item
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// The description of the order item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The Name of the order item
        /// </summary>
        public String Name { get; }

        /// <summary>
        /// The type of the order item
        /// </summary>
        public string ItemType { get; }
    }
}
