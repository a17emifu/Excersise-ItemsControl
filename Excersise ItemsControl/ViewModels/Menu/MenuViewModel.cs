using Excersise_ItemsControl.DataTypes;
using Excersise_ItemsControl.ViewModels.Base;
using Excersise_ItemsControl.ViewModels.Menu;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Excersise_ItemsControl.ViewModels
{
    class MenuViewModel : BaseViewModel
    {
        public ObservableCollection<MenuItemViewModel> MenuItems { get; set; } = new ObservableCollection<MenuItemViewModel>();

       // private readonly List<MenuItemViewModel> _menuItems = new List<MenuItemViewModel>();

        public MenuViewModel()
        {
            CreateMenuItems();
        }

        private void CreateMenuItems()
        {
            var dragDropItem = new MenuItemViewModel
            {
                Name = "DragDropItem",
                Header = "Drag and Drop",
                Command = new RelayCommand(MenuDD)
            };
            var ItemsControlItem = new MenuItemViewModel
            {
                Name = "ItemControlsItem",
                Header = "ItemControl",
                Command = new RelayCommand(MenuItemsControl)
            };
            var KeyboardItem = new MenuItemViewModel
            {
                Name = "KeyboardItem",
                Header = "Keyboard",
                Command = new RelayCommand(MenuKeyboard)
            };
            var ListboxItem = new MenuItemViewModel
            {
                Name = "ListboxItem",
                Header = "Listbox Control",
                Command = new RelayCommand(MenuListbox)
            }; var MasterMindItem = new MenuItemViewModel
            {
                Name = "MasterMindItem",
                Header = "MasterMind",
                Command = new RelayCommand(MenuMasterMind)
            };

            MenuItems.Add(dragDropItem);
            MenuItems.Add(MasterMindItem);
            MenuItems.Add(ListboxItem);
            MenuItems.Add(KeyboardItem);
            MenuItems.Add(ItemsControlItem);
        }

        private void MenuMasterMind()
        {
            GoToPage(ApplicationPage.MasterMind);
        }

        private void MenuListbox()
        {
            GoToPage(ApplicationPage.ListBox);

        }

        private void MenuKeyboard()
        {
            GoToPage(ApplicationPage.Keyboard);

        }

        private void MenuItemsControl()
        {
            GoToPage(ApplicationPage.ItemsControl);

        }

        private void MenuDD()
        {
            GoToPage(ApplicationPage.DragDrop);

        }
    }
}
