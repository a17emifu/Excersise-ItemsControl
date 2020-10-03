using Excersise_ItemsControl.DataTypes;
using Excersise_ItemsControl.ViewModels.Base;
using Excersise_ItemsControl.Views;
using Excersise_ItemsControl.Views.MasterMind;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Excersise_ItemsControl.Helper
{
    public static class NavigateToPageHelper
    {
        public static Page GetPage(ApplicationPage page, BaseViewModel model = null)
        {
            return page switch
            {
                ApplicationPage.DragDrop => new DDPage(),
                ApplicationPage.ItemsControl => new ListPage(),
                ApplicationPage.Keyboard => new MainPage(),
                ApplicationPage.ListBox => new ListBoxPage(),
                ApplicationPage.MasterMind => new MasterMindPage(),
                _ => null,
            };
        }
    }
}
