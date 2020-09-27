﻿/*
 * Author: Stephanie Krass
 * Class name: MenuContainer.xaml.cs
 * Purpose: Class used for interaction logic for MenuContainer.xaml
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuContainer.xaml
    /// </summary>
    public partial class MenuContainer : UserControl
    {
        /* Private variable declaration */
        private MenuSelection menuSelection;
        private OrderList orderList;

        /// <summary>
        /// Constructor for the MenuContainer
        /// </summary>
        public MenuContainer()
        {
            InitializeComponent();

            menuSelection = new MenuSelection(this);
            orderList = new OrderList();
            menuBorder.Child = menuSelection;
            currentItemsInOrderBorder.Child = orderList;
        }

    }
}