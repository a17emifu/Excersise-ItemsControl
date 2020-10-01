using Excersise_ItemsControl.ViewModels.Listbox;
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

namespace Excersise_ItemsControl.Views
{
    /// <summary>
    /// ListBoxPage.xaml の相互作用ロジック
    /// </summary>
    public partial class ListBoxPage : Page
    {
        public ListBoxPage()
        {
            InitializeComponent();
            DataContext = new ListboxViewModel();
        }
    }
}
