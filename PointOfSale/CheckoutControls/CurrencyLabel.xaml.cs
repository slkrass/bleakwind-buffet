/*
 * Author: Stephanie Krass
 * Class name: CurrencyLabel.xaml.cs
 * Purpose: Class used for interaction logic for CurrencyLabel.xaml
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
    /// Interaction logic for CurrencyLabel.xaml
    /// </summary>
    public partial class CurrencyLabel : UserControl
    {
        /// <summary>
        /// A dependency property representing the number this control represents
        /// </summary>
        public static DependencyProperty NumberProperty = DependencyProperty.Register("Number", typeof(string), typeof(CurrencyLabel), new FrameworkPropertyMetadata("$0.00", FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// The Number this control represents
        /// </summary>
        public string Number
        {
            get
            {
                return (string)GetValue(NumberProperty);
            }
            set
            {
                SetValue(NumberProperty, value);
            }
        }
        public CurrencyLabel()
        {
            InitializeComponent();
        }
    }
}
