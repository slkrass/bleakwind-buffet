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
        /// <param name="container">The MenuContainer instance where MenuSelection will be placed</param>
        public MenuSelection(MenuContainer container)
        {
            InitializeComponent();
            menuContainer = container;
            order = container.OrderControl;
            DataContext = order;
        }

        /// <summary>
        /// Controls the button click events for the menu options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddItemToOrder(object sender, RoutedEventArgs e)
        {
            if (sender is Button pressedButton)
            {
                if (pressedButton.Name == "briarheartBurgerButton") {
                    if (DataContext is Order order)
                    {
                        BriarheartBurger burger = new BriarheartBurger();
                        order.Add(burger);
                        menuContainer.menuBorder.Child = new BriarheartBurgerCustomization(menuContainer, burger);
                    }
                }
                else if (pressedButton.Name == "doubleDraugrButton")
                {
                    if (DataContext is Order order)
                    {
                        DoubleDraugr burger = new DoubleDraugr();
                        order.Add(burger);
                        menuContainer.menuBorder.Child = new DoubleDraugrCustomization(menuContainer, burger);
                    }
                }
                else if (pressedButton.Name == "thalmorTripleButton")
                {
                    if (DataContext is Order order)
                    {
                        ThalmorTriple tt = new ThalmorTriple();
                        order.Add(tt);
                        menuContainer.menuBorder.Child = new ThalmorTripleCustomization(menuContainer,tt);
                    }
                }                
                else if (pressedButton.Name == "smokehouseSkeletonButton")
                {
                    if (DataContext is Order order)
                    {
                        SmokehouseSkeleton ss = new SmokehouseSkeleton();
                        order.Add(ss);
                        menuContainer.menuBorder.Child = new SmokehouseSkeletonCustomization(menuContainer, ss);
                    }
                }               
                else if (pressedButton.Name == "gardenOrcOmeletteButton")
                {
                    if (DataContext is Order order)
                    {
                        GardenOrcOmelette goo = new GardenOrcOmelette();
                        order.Add(goo);
                        menuContainer.menuBorder.Child = new GardenOrcOmeletteCustomization(menuContainer, goo);
                    }
                }
                else if (pressedButton.Name == "phillyPoacherButton")
                {
                    if (DataContext is Order order)
                    {
                        PhillyPoacher pp = new PhillyPoacher();
                        order.Add(pp);
                        menuContainer.menuBorder.Child = new PhillyPoacherCustomization(menuContainer,pp);
                    }
                }
                else if (pressedButton.Name == "thugsTBoneButton")
                {
                    if (DataContext is Order order)
                    {
                        ThugsTBone ttb = new ThugsTBone();
                        order.Add(ttb);
                        menuContainer.menuBorder.Child = new ThugsTBoneCustomization(menuContainer, ttb);
                    }
                }
                else if (pressedButton.Name == "sailorSodaButton")
                {
                    if (DataContext is Order order)
                    {
                        SailorSoda ss = new SailorSoda();
                        order.Add(ss);
                        menuContainer.menuBorder.Child = new SailorSodaCustomization(menuContainer,ss);
                    }
                }
                else if (pressedButton.Name == "markarthMilkButton")
                {
                    if (DataContext is Order order)
                    {
                        MarkarthMilk mm = new MarkarthMilk();
                        order.Add(mm);
                        menuContainer.menuBorder.Child = new MarkarthMilkCustomization(menuContainer,mm);
                    }
                }
                else if (pressedButton.Name == "aretinoAppleJuiceButton")
                {
                    if (DataContext is Order order)
                    {
                        AretinoAppleJuice aj = new AretinoAppleJuice();
                        order.Add(aj);
                        menuContainer.menuBorder.Child = new AretinoAppleJuiceCustomization(menuContainer,aj);
                    }
                }
                else if (pressedButton.Name == "candlehearthCoffeeButton")
                {
                    if (DataContext is Order order)
                    {
                        CandlehearthCoffee cc = new CandlehearthCoffee();
                        order.Add(cc);
                        menuContainer.menuBorder.Child = new CandlehearthCoffeeCustomization(menuContainer,cc);
                    }
                }
                else if (pressedButton.Name == "warriorWaterButton")
                {
                    if (DataContext is Order order)
                    {
                        WarriorWater ww = new WarriorWater();
                        order.Add(ww);
                        menuContainer.menuBorder.Child = new WarriorWaterCustomization(menuContainer,ww);
                    }
                }
                else if (pressedButton.Name == "vokunSaladButton")
                {
                    if (DataContext is Order order)
                    {
                        VokunSalad vs = new VokunSalad();
                        order.Add(vs);
                        menuContainer.menuBorder.Child = new VokunSaladCustomization(menuContainer, vs);
                    }
                }
                else if (pressedButton.Name == "friedMiraakButton")
                {
                    if (DataContext is Order order)
                    {
                        FriedMiraak fm = new FriedMiraak();
                        order.Add(fm);
                        menuContainer.menuBorder.Child = new FriedMiraakCustomization(menuContainer, fm);
                    }
                }
                else if (pressedButton.Name == "madOtarGritsButton")
                {
                    if (DataContext is Order order)
                    {
                        MadOtarGrits mog = new MadOtarGrits();
                        order.Add(mog);
                        menuContainer.menuBorder.Child = new MadOtarGritsCustomization(menuContainer, mog);
                    }
                }
                else if (pressedButton.Name == "dragonbornWaffleFriesButton")
                {
                    if (DataContext is Order order)
                    {
                        DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                        order.Add(dwf);
                        menuContainer.menuBorder.Child = new DragonbornWaffleFriesCustomization(menuContainer,dwf);
                    }
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
            if(sender is Button button)
            {
                //menuContainer.currentItemsInOrderBorder.Child = new OrderList(menuContainer);
                menuContainer.OrderControl = new Order();
                menuContainer.currentItemsInOrderBorder.Child = new OrderList(menuContainer);
            }
        }

        /// <summary>
        /// Controls the button click events for complete order menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteOrder(object sender, RoutedEventArgs e)
        {

        }
    }
}
