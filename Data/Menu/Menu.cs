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
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class representing a menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets the possible menu item categories
        /// </summary>
        public static string[] Categories
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

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

        /// <summary>
        /// Searches the menu for matching items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of menu items</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return FullMenu();

            foreach (IOrderItem item in FullMenu())
            {
                if (item is Entree entree)
                {
                    if (entree is BriarheartBurger briar 
                        && briar.Name != null 
                        && briar.Name.Contains(terms, 
                        StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(briar);
                    }
                    else if (entree is DoubleDraugr draugr && draugr.Name != null && draugr.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(draugr);
                    }
                    else if (entree is GardenOrcOmelette goo && goo.Name != null && goo.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(goo);
                    }
                    else if (entree is PhillyPoacher pp && pp.Name != null && pp.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(pp);
                    }
                    else if (entree is SmokehouseSkeleton shs && shs.Name != null && shs.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(shs);
                    }
                    else if (entree is ThalmorTriple thal && thal.Name != null && thal.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(thal);
                    }
                    else if (entree is ThugsTBone tBone && tBone.Name != null && tBone.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(tBone);
                    }
                }
                else if (item is Drink drink)
                {//&& entree.Name != null && entree.Name.Contains(terms)  results.Add();
                    if (drink is AretinoAppleJuice aj && aj.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(aj);
                    }
                    else if (drink is CandlehearthCoffee cc && cc.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(cc);
                    }
                    else if (drink is MarkarthMilk mm && mm.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(mm);
                    }
                    else if (drink is SailorSoda ss && ss.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(ss);
                    }
                    else if (drink is WarriorWater ww && ww.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(ww);
                    }
                }
                else if (item is Side side)
                {// results.Add();
                    if (side is DragonbornWaffleFries dwf && dwf.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(dwf);
                    }
                    else if (side is FriedMiraak fm && fm.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(fm);
                    }
                    else if (side is MadOtarGrits mog && mog.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(mog);
                    }
                    else if (side is VokunSalad vs && vs.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(vs);
                    }
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided menu
        /// </summary>
        /// <param name="movies">The collection of menu items to filter</param>
        /// <param name="genres">The categories to include</param>
        /// <returns>A collection containing only menu items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menu, IEnumerable<string> categories)
        {
            // If no filter is specified, just return the provided collection
            if (categories == null || categories.Count() == 0) return menu;

            var results = new List<IOrderItem>();
            foreach (IOrderItem item in menu)
            {
                
                if (categories.Contains("Entree") && item is Entree entree)
                {
                    results.Add(entree);
                }
                
                if (categories.Contains("Drink") && item is Drink drink)
                {
                    results.Add(drink);
                }
                
                if (categories.Contains("Side") && item is Side side)
                {
                    results.Add(side);
                }
            }

            return results;

        }
        /// <summary>
        /// Filters the provided menu
        /// to those with calories falling within
        /// the specified range
        /// </summary>
        /// <param name="menu">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;

        }

        /// <summary>
        /// Filters the provided menu
        /// to those with their price falling within
        /// the specified range
        /// </summary>
        /// <param name="menu">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (Math.Round(item.Price,2) <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (Math.Round(item.Price, 2) >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (Math.Round(item.Price, 2) >= min && Math.Round(item.Price, 2) <= max)
                {
                    results.Add(item);
                }
            }
            return results;

        }
    }
}
