﻿using LukomskiMajorkowski.KeyboardCatalog.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LukomskiMajorkowski.KeyboardCatalog.UI_WPF.ViewModels;

namespace LukomskiMajorkowski.KeyboardCatalog.UI_WPF
{
    /// <summary>
    /// Interaction logic for ProductFormWindow.xaml
    /// </summary>
    public partial class ProductFormWindow : Window
    {
        public ProductFormViewModel ViewModel { get; private set; }

        public ProductFormWindow(IDAO dao,
                                 IProduct product = null)
        {
            InitializeComponent();
            ViewModel = new ProductFormViewModel(dao, this, product);
            DataContext = ViewModel;
        }
    }

}
