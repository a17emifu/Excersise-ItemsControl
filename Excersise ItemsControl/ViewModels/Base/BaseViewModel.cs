using Excersise_ItemsControl.DataTypes;
using Excersise_ItemsControl.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using static Excersise_ItemsControl.ViewModels.Base.RelayParametrizedCommand;

namespace Excersise_ItemsControl.ViewModels.Base
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected static NavigationService NavigationService { get; } = (Application.Current.MainWindow as MainWindow).Main.NavigationService;
        public ICommand NavigateToPageByParameterCommand { get; set; }
        public ICommand NavigateBackParameterCommand { get; set; }

        protected BaseViewModel()
        {
            NavigateToPageByParameterCommand = new RelayParameterizedCommand(parameter => GoToPage(parameter));
            NavigateBackParameterCommand = new RelayCommand(GoBack);
        }

        protected virtual void GoToPage(object parameter)
        {
            var selectedPage = (ApplicationPage)parameter;
            Page page = NavigateToPageHelper.GetPage(selectedPage);
            NavigationService.Navigate(page);
        }
        protected void GoBack()
        {
            NavigationService.GoBack();
        }

    }
}
