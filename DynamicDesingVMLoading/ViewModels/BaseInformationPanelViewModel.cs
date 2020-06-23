using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDesingVMLoading.ViewModels
{
    public class BaseInformationPanelViewModel
    {
        private BaseSideBarViewModel _baseSideBarViewModel;

        public BaseSideBarViewModel BaseSideBarViewModel
        {
            get => _baseSideBarViewModel;

            set
            {
                _baseSideBarViewModel = value;
                // NotifyOnPropertyChange(() => BaseSideBarViewModel);
            }
        }
    }
}
