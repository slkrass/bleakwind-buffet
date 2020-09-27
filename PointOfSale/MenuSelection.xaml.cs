/*
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

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;

        /// <summary>
        /// Constructor for the MenuSelection.xaml Class
        /// </summary>
        /// <param name="container">The MenuContainer instance where MenuSelection will be placed</param>
        public MenuSelection(MenuContainer container)
        {
            InitializeComponent();
            menuContainer = container;
        }

        /// <summary>
        /// Controls the button click events for the menu options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddItemToOrder(object sender, RoutedEventArgs e)
        {
            Button pressedButton = (Button)sender;
            if (pressedButton.Name == "briarheartBurgerButton")             menuContainer.menuBorder.Child = new BriarheartBurgerCustomization(menuContainer);
            else if (pressedButton.Name == "doubleDraugrButton")            menuContainer.menuBorder.Child = new DoubleDraugrCustomization(menuContainer);
            else if (pressedButton.Name == "thalmorTripleButton")           menuContainer.menuBorder.Child = new ThalmorTripleCustomization(menuContainer);
            else if (pressedButton.Name == "smokehouseSkeletonButton")      menuContainer.menuBorder.Child = new SmokehouseSkeletonCustomization(menuContainer);
            else if (pressedButton.Name == "gardenOrcOmeletteButton")       menuContainer.menuBorder.Child = new GardenOrcOmeletteCustomization(menuContainer);
            else if (pressedButton.Name == "phillyPoacherButton")           menuContainer.menuBorder.Child = new PhillyPoacherCustomization(menuContainer);
            else if (pressedButton.Name == "thugsTBoneButton")              menuContainer.menuBorder.Child = new ThugsTBoneCustomization(menuContainer);
            else if (pressedButton.Name == "sailorSodaButton")              menuContainer.menuBorder.Child = new SailorSodaCustomization(menuContainer);
            else if (pressedButton.Name == "markarthMilkButton")            menuContainer.menuBorder.Child = new MarkarthMilkCustomization(menuContainer);
            else if (pressedButton.Name == "aretinoAppleJuiceButton")       menuContainer.menuBorder.Child = new AretinoAppleJuiceCustomization(menuContainer);
            else if (pressedButton.Name == "candlehearthCoffeeButton")      menuContainer.menuBorder.Child = new CandlehearthCoffeeCustomization(menuContainer);
            else if (pressedButton.Name == "warriorWaterButton")            menuContainer.menuBorder.Child = new WarriorWaterCustomization(menuContainer);
            else if (pressedButton.Name == "vokunSaladButton")              menuContainer.menuBorder.Child = new VokunSaladCustomization(menuContainer);
            else if (pressedButton.Name == "friedMiraakButton")             menuContainer.menuBorder.Child = new FriedMiraakCustomization(menuContainer);
            else if (pressedButton.Name == "madOtarGritsButton")            menuContainer.menuBorder.Child = new MadOtarGritsCustomization(menuContainer);
            else if (pressedButton.Name == "dragonbornWaffleFriesButton")   menuContainer.menuBorder.Child = new DragonbornWaffleFriesCustomization(menuContainer);
        }
    }
}
