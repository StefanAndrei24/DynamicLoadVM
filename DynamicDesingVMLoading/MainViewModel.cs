using DynamicDesingVMLoading.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDesingVMLoading
{
    public class MainViewModel
    {
        public MainViewModel(NavigationViewModel inNavigationViewModel)
        {
            this.NavigationViewModel = inNavigationViewModel ?? throw new ArgumentNullException(nameof(inNavigationViewModel));
        }

        public NavigationViewModel NavigationViewModel { get; }
    }
}
