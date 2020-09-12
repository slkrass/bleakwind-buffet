/*
 * Author: Stephanie Krass
 * Class: Menu.cs
 * Purpose: Class used to represent a menu
 */
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class representing a menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Returns an IEnumerable of all the entrees on the menu
        /// </summary>
        /// <returns>
        /// The an IEnumerable of the entrees on the menu
        /// </returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());

            return entrees;
        }

        /// <summary>
        /// Returns an IEnumerable of all the sides on the menu
        /// </summary>
        /// <returns>
        /// The an IEnumerable of the sides on the menu
        /// </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            for(int num = 0; num < 3; num++)
                sides.Add(new DragonbornWaffleFries());

            for (int num = 0; num < 3; num++)
                sides.Add(new FriedMiraak());

            for (int num = 0; num < 3; num++)
                sides.Add(new MadOtarGrits());

            for (int num = 0; num < 3; num++)
                sides.Add(new VokunSalad());

            int size = 0;
            foreach(Side side in sides)
            {
                side.Size = (Size)size;

                if (size < 2) size++;
                else size = 0;
            }

            return sides;
        }

        /// <summary>
        /// Returns an IEnumerable of all the drinks on the menu
        /// </summary>
        /// <returns>
        /// The an IEnumerable of the drinks on the menu
        /// </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            for (int num = 0; num < 3; num++)
                drinks.Add(new AretinoAppleJuice());
            
            bool decaf = false;
            for (int num = 0; num < 2; num++)
            {
                for(int count = 0; count < 3; count++)
                {
                    CandlehearthCoffee coffee = new CandlehearthCoffee();
                    coffee.Decaf = decaf;
                    drinks.Add(coffee);
                }
                decaf = true;
            }
                
            for (int num = 0; num < 3; num++)
                drinks.Add(new MarkarthMilk());

            for(int flav = 0; flav < 6; flav++)
            {
                for (int num = 0; num < 3; num++)
                {
                    SailorSoda soda = new SailorSoda();
                    soda.Flavor = (SodaFlavor)flav;
                    drinks.Add(soda);
                }
                   
            }
            
            for (int num = 0; num < 3; num++)
                drinks.Add(new WarriorWater());

            int size = 0;
            foreach (Drink drink in drinks)
            {
                drink.Size = (Size)size;

                if (size < 2) size++;
                else size = 0;
            }

            return drinks;
        }

        /// <summary>
        /// Returns an IEnumerable of all the items on the menu
        /// </summary>
        /// <returns>
        /// The an IEnumerable of the all the items on the menu
        /// </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            List<IOrderItem> entrees = (List<IOrderItem>) Entrees();
            List<IOrderItem> sides = (List<IOrderItem>) Sides();
            List<IOrderItem> drinks = (List<IOrderItem>) Drinks();

            foreach (Entree entree in entrees)
                fullMenu.Add(entree);

            foreach (Side side in sides)
                fullMenu.Add(side);

            foreach (Drink drink in drinks)
                fullMenu.Add(drink);

            return fullMenu;
        }
    }
}
