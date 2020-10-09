using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class that represents the order
    /// </summary>
    public class Order : ObservableCollection<IOrderItem>
    {
        /* Private Variable Declarations */
        private static int nextOrderNumber = 1;
        private int orderNumber;
        private double salesTaxRate = 0.12;

        /// <summary>
        /// Gets and sets the sales tax rate for the order
        /// </summary>
        public double SalesTaxRate 
        {
            get { return salesTaxRate; } 
            set
            {
                salesTaxRate = value;
            }
        }

        /// <summary>
        /// Gets the subtotal for the order
        /// </summary>
        public double Subtotal 
        { 
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in this)
                {
                    subtotal += item.Price;
                }

                return subtotal;
            }
        }

        /// <summary>
        /// Gets the total tax for the order
        /// </summary>
        public double Tax { get => Subtotal * SalesTaxRate; }

        /// <summary>
        /// Gets the total cost for the order
        /// </summary>
        public double Total { get => Tax + Subtotal;}

        /// <summary>
        /// Gets the total calories for the order
        /// </summary>
        public uint Calories 
        {
            get
            {
                uint totalCals = 0;
                foreach (IOrderItem item in this)
                {
                    totalCals += item.Calories;
                }

                return totalCals;
            }
        }

        /// <summary>
        /// Gets the string representation of Tax
        /// </summary>
        public string StringTax
        {
            get
            {
                return "$" + string.Format("{0:0.00}", Tax);
            }
        }

        /// <summary>
        /// Gets the string representation of Total
        /// </summary>
        public string StringTotal
        {
            get
            {
                return "$" + string.Format("{0:0.00}", Total);
            }
        }

        /// <summary>
        /// Gets the string representation of Subtotal
        /// </summary>
        public string StringSubtotal
        {
            get
            {
                return "$" + string.Format("{0:0.00}", Subtotal);
            }
        }

        /// <summary>
        /// Gets the order number and privately sets the order number 
        /// </summary>
        public int Number 
        {
            get { return orderNumber; }
            private set
            {
                orderNumber = value;
            }
        }

        /// <summary>
        /// Constructor for the Order
        /// </summary>
        public Order()
        {
            this.orderNumber = nextOrderNumber;
            nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;    
        }

        /// <summary>
        /// Listener to check to see if the collection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("SalesTaxRate"));
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            OnPropertyChanged(new PropertyChangedEventArgs("StringTax"));
            OnPropertyChanged(new PropertyChangedEventArgs("StringSubtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("StringTotal"));

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        if (item is AretinoAppleJuice drink) { drink.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is CandlehearthCoffee cc) { cc.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is MarkarthMilk mm) { mm.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is SailorSoda ss) { ss.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is WarriorWater ww) { ww.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is BriarheartBurger briar) { briar.PropertyChanged += CollectionItemChangedListener;}
                        else if (item is DoubleDraugr draugr) { draugr.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is GardenOrcOmelette goo) { goo.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is PhillyPoacher pp) { pp.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is SmokehouseSkeleton shs) { shs.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is ThalmorTriple thal) {thal.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is ThugsTBone tBone) { tBone.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is DragonbornWaffleFries dwf) { dwf.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is FriedMiraak fm) { fm.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is MadOtarGrits mog) { mog.PropertyChanged += CollectionItemChangedListener; }
                        else if (item is VokunSalad vs) { vs.PropertyChanged += CollectionItemChangedListener; }
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        if (item is AretinoAppleJuice drink) { drink.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is CandlehearthCoffee cc) { cc.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is MarkarthMilk mm) { mm.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is SailorSoda ss) { ss.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is WarriorWater ww) { ww.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is BriarheartBurger briar) { briar.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is DoubleDraugr draugr) { draugr.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is GardenOrcOmelette goo) { goo.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is PhillyPoacher pp) { pp.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is SmokehouseSkeleton shs) { shs.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is ThalmorTriple thal) { thal.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is ThugsTBone tBone) { tBone.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is DragonbornWaffleFries dwf) { dwf.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is FriedMiraak fm) { fm.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is MadOtarGrits mog) { mog.PropertyChanged -= CollectionItemChangedListener; }
                        else if (item is VokunSalad vs) { vs.PropertyChanged -= CollectionItemChangedListener; }
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }

        /// <summary>
        /// Listener to check to see if the items in the collection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Size")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged(new PropertyChangedEventArgs("SalesTaxRate"));
                OnPropertyChanged(new PropertyChangedEventArgs("SalesTax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringPrice"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSpecialInstructions"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringTax"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringSubtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("StringTotal"));

            }

            if(e.PropertyName == "SalesTaxRate")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("SalesTaxRate"));
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }
        }
    }
}
