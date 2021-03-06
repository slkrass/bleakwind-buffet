﻿/*
 * Author: Stephanie Krass
 * Class name: MenuSelection.xaml.cs
 * Purpose: Class used for interaction logic for MenuSelection.xaml
 */
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;


namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private Order order;

        /// <summary>
        /// Constructor for the MenuSelection.xaml Class
        /// </summary>
        public MenuSelection()
        {
            InitializeComponent();
            
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
                order = menuContainer.OrderControl;
                DataContext = order;
            }
        }

        /// <summary>
        /// Controls the button click events for the menu options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddItemToOrder(object sender, RoutedEventArgs e)
        {
            if ((sender is Button pressedButton) && (DataContext is Order order))
            {
                if (pressedButton.Name == "briarheartBurgerButton") 
                {
                        BriarheartBurger burger = new BriarheartBurger();
                        order.Add(burger);
                        menuContainer.menuBorder.Child = new BriarheartBurgerCustomization() { Container = menuContainer, Burger = burger };                    
                }
                else if (pressedButton.Name == "doubleDraugrButton")
                {                                            
                        DoubleDraugr burger = new DoubleDraugr();
                        order.Add(burger);
                        menuContainer.menuBorder.Child = new DoubleDraugrCustomization() { Container = menuContainer, Burger = burger };                    
                }
                else if (pressedButton.Name == "thalmorTripleButton")
                {                    
                        ThalmorTriple tt = new ThalmorTriple();
                        order.Add(tt);
                        menuContainer.menuBorder.Child = new ThalmorTripleCustomization() { Container = menuContainer, Burger = tt };                    
                }                
                else if (pressedButton.Name == "smokehouseSkeletonButton")
                {                    
                        SmokehouseSkeleton ss = new SmokehouseSkeleton();
                        order.Add(ss);
                        menuContainer.menuBorder.Child = new SmokehouseSkeletonCustomization() { Container = menuContainer, Skeleton = ss };                    
                }               
                else if (pressedButton.Name == "gardenOrcOmeletteButton")
                {                    
                        GardenOrcOmelette goo = new GardenOrcOmelette();
                        order.Add(goo);
                        menuContainer.menuBorder.Child = new GardenOrcOmeletteCustomization() { Container = menuContainer, Omelette = goo };                    
                }
                else if (pressedButton.Name == "phillyPoacherButton")
                {                   
                        PhillyPoacher pp = new PhillyPoacher();
                        order.Add(pp);
                        menuContainer.menuBorder.Child = new PhillyPoacherCustomization() { Container = menuContainer, Philly = pp };                  
                }
                else if (pressedButton.Name == "thugsTBoneButton")
                {                    
                        ThugsTBone ttb = new ThugsTBone();
                        order.Add(ttb);
                        menuContainer.menuBorder.Child = new ThugsTBoneCustomization() { Container = menuContainer, TBone = ttb };                    
                }
                else if (pressedButton.Name == "sailorSodaButton")
                {                    
                        SailorSoda ss = new SailorSoda();
                        order.Add(ss);
                        menuContainer.menuBorder.Child = new SailorSodaCustomization() { Container = menuContainer, Soda = ss };                    
                }
                else if (pressedButton.Name == "markarthMilkButton")
                {                    
                        MarkarthMilk mm = new MarkarthMilk();
                        order.Add(mm);
                        menuContainer.menuBorder.Child = new MarkarthMilkCustomization() { Container = menuContainer, Milk = mm };                    
                }
                else if (pressedButton.Name == "aretinoAppleJuiceButton")
                {                    
                        AretinoAppleJuice aj = new AretinoAppleJuice();
                        order.Add(aj);
                    menuContainer.menuBorder.Child = new AretinoAppleJuiceCustomization() { Container = menuContainer, AppleJuice = aj };                    
                }
                else if (pressedButton.Name == "candlehearthCoffeeButton")
                {                    
                        CandlehearthCoffee cc = new CandlehearthCoffee();
                        order.Add(cc);
                        menuContainer.menuBorder.Child = new CandlehearthCoffeeCustomization() { Container = menuContainer, Coffee = cc };                    
                }
                else if (pressedButton.Name == "warriorWaterButton")
                {                   
                        WarriorWater ww = new WarriorWater();
                        order.Add(ww);
                        menuContainer.menuBorder.Child = new WarriorWaterCustomization() { Container = menuContainer, Water = ww };                    
                }
                else if (pressedButton.Name == "vokunSaladButton")
                {                    
                        VokunSalad vs = new VokunSalad();
                        order.Add(vs);
                        menuContainer.menuBorder.Child = new VokunSaladCustomization() { Container = menuContainer, Salad = vs };                    
                }
                else if (pressedButton.Name == "friedMiraakButton")
                {                    
                        FriedMiraak fm = new FriedMiraak();
                        order.Add(fm);
                        menuContainer.menuBorder.Child = new FriedMiraakCustomization() { Container = menuContainer, Miraak = fm };                    
                }
                else if (pressedButton.Name == "madOtarGritsButton")
                {                    
                        MadOtarGrits mog = new MadOtarGrits();
                        order.Add(mog);
                        menuContainer.menuBorder.Child = new MadOtarGritsCustomization() { Container = menuContainer, Grits = mog };                    
                }
                else if (pressedButton.Name == "dragonbornWaffleFriesButton")
                {                    
                        DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                        order.Add(dwf);
                        menuContainer.menuBorder.Child = new DragonbornWaffleFriesCustomization() { Container = menuContainer, Fries = dwf };                    
                }
                else if (pressedButton.Name == "comboButton")
                {
                    Combo combo = new Combo();
                    order.Add(combo);
                    menuContainer.menuBorder.Child = new ComboSelectionStartScreen() { Container = menuContainer, ComboItem = combo};
                }
            }
        }

        /// <summary>
        /// Controls the button click events cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelOrder(object sender, RoutedEventArgs e)
        {
            if(sender is Button)
            {
                menuContainer.OrderControl = new Order();
                menuContainer.currentItemsInOrderBorder.Child = new OrderList() { Container = menuContainer};
            }
        }

        /// <summary>
        /// Controls the button click events for complete order menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteOrder(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new PaymentTypeSelection() { Container = menuContainer };
            menuContainer.currentItemsInOrderBorder.Child = new CompletedOrderList() { Container = menuContainer };
        }
    }
}
