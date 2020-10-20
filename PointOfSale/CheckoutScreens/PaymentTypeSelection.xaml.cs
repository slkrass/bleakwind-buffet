/*
 * Author: Stephanie Krass
 * Class name: PaymentTypeSelection.xaml.cs
 * Purpose: Class used for interaction logic for AmountDue.xaml
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.PointOfSale;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentTypeSelection.xaml
    /// </summary>
    public partial class PaymentTypeSelection : UserControl
    {

        /* Private variable declaration */
        private MenuContainer menuContainer;

        public PaymentTypeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controls the button click events for returning to the ordering screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new MenuSelection() { Container = menuContainer };
            menuContainer.currentItemsInOrderBorder.Child = new OrderList() { Container = menuContainer };
        }

        /// <summary>
        /// Controls the button click events cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelOrder(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                menuContainer.OrderControl = new Order();
                menuContainer.currentItemsInOrderBorder.Child = new OrderList() { Container = menuContainer };
                menuContainer.menuBorder.Child = new MenuSelection() { Container = menuContainer };
            }
        }

        /// <summary>
        /// The menu container for the xaml
        /// </summary>
        public MenuContainer Container
        {
            get
            {
                return menuContainer;
            }
            set
            {
                menuContainer = value;
            }
        }

        /// <summary>
        /// Controls the button click events for paying with cash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CashPayment(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new CashPaymentScreen() { Container = menuContainer };
        }

        /// <summary>
        /// Controls the button click events for paying with card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CardPayment(object sender, RoutedEventArgs e)
        {
            //Invoke the register method for card payment

            RegisterViewModel register = new RegisterViewModel();
            
            CardTransactionResult transactionResult = register.RunCard(menuContainer.OrderControl.Total);

            if(transactionResult == CardTransactionResult.Approved)
            {
                register.PrintLine("Order #" + menuContainer.OrderControl.Number);
                DateTime time = DateTime.Now;
                register.PrintLine(time.ToString()); 

                foreach(IOrderItem item in menuContainer.OrderControl)//Print names and prices of items (may add special instructions)
                {
                    if (item is AretinoAppleJuice aj) 
                    { 
                        register.PrintLine(aj.Name + "\t" + aj.StringPrice);
                        foreach (string str in aj.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is CandlehearthCoffee cc)
                    {
                        register.PrintLine(cc.Name + "\t" + cc.StringPrice);
                        foreach (string str in cc.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is MarkarthMilk mm) 
                    { 
                        register.PrintLine(mm.Name + "\t" + mm.StringPrice);
                        foreach (string str in mm.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is SailorSoda ss) 
                    { 
                        register.PrintLine(ss.Name + "\t" + ss.StringPrice);
                        foreach (string str in ss.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is WarriorWater ww) 
                    { 
                        register.PrintLine(ww.Name + "\t" + ww.StringPrice);
                        foreach (string str in ww.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is BriarheartBurger briar) 
                    { 
                        register.PrintLine(briar.Name + "\t" + briar.StringPrice);
                        foreach (string str in briar.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is DoubleDraugr draugr) 
                    {
                        register.PrintLine(draugr.Name + "\t" + draugr.StringPrice);
                        foreach (string str in draugr.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is GardenOrcOmelette goo) 
                    {
                        register.PrintLine(goo.Name + "\t" + goo.StringPrice);
                        foreach (string str in goo.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is PhillyPoacher pp) 
                    { 
                        register.PrintLine(pp.Name + "\t" + pp.StringPrice);
                        foreach (string str in pp.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is SmokehouseSkeleton skel)
                    { 
                        register.PrintLine(skel.Name + "\t" + skel.StringPrice);
                        foreach (string str in skel.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is ThalmorTriple thal)
                    { 
                        register.PrintLine(thal.Name + "\t" + thal.StringPrice);
                        foreach (string str in thal.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                    else if (item is ThugsTBone thugs) 
                    { 
                        register.PrintLine(thugs.Name + "\t" + thugs.StringPrice); 
                    }
                    else if (item is DragonbornWaffleFries dwf) 
                    { 
                        register.PrintLine(dwf.Name + "\t" + dwf.StringPrice); 
                    }
                    else if (item is FriedMiraak fm) 
                    { 
                        register.PrintLine(fm.Name + "\t" + fm.StringPrice); 
                    }
                    else if (item is MadOtarGrits mog) 
                    { 
                        register.PrintLine(mog.Name + "\t" + mog.StringPrice); 
                    }
                    else if (item is VokunSalad vs) 
                    { 
                        register.PrintLine(vs.Name + "\t" + vs.StringPrice); 
                    }
                    else if (item is Combo combo) 
                    { 
                        register.PrintLine(combo.Name + "\t" + combo.StringPrice); 
                        foreach(string str in combo.SpecialInstructions)
                        {
                            register.PrintLine(str);
                        }
                    }
                     
                }//end foreach

                //Print Subtotal, Tax, and Total
                register.PrintLine("Subtotal:\t" + menuContainer.OrderControl.StringSubtotal);
                register.PrintLine("Tax:\t" + menuContainer.OrderControl.StringTax);
                register.PrintLine("Total:\t" + menuContainer.OrderControl.StringTotal);
                register.PrintLine("Change Owed:\t$0.00");
                register.PrintLine("Payment Method:\tCard");
                register.CutTape();

                menuContainer.OrderControl = new Order();
                menuContainer.currentItemsInOrderBorder.Child = new OrderList() { Container = menuContainer };
                menuContainer.menuBorder.Child = new MenuSelection() { Container = menuContainer };

            }//end if
            else
            {
                //throw an error message as a textbox with proper info
            }
        }
    }
}
