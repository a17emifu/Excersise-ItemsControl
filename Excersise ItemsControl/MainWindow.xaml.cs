﻿using Excersise_ItemsControl.Views;
using Excersise_ItemsControl.Views.MasterMind;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Excersise_ItemsControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Main.Content = new MainPage();
            //Main.Content = new ListPage();
            //Main.Content = new ListBoxPage();
            //Main.Content = new DDPage();
            Main.Content = new MasterMindPage();


        }
    }
}
