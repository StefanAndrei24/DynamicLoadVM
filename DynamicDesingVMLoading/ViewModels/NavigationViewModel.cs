
using DynamicDesingVMLoading.ViewModels.SubViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDesingVMLoading.ViewModels
{
    public class NavigationViewModel
    {
        private BaseInformationPanelViewModel _baseInformationPanelViewModel;

        public BaseInformationPanelViewModel BaseInformationPanelViewModel
        {
            get => _baseInformationPanelViewModel;

            set

            {
                _baseInformationPanelViewModel = value;

                // NotifyOnPropertyChange(() => BaseInformationPanelViewModel);
            }
        }


        public void LoadInfoPanels(string argument)
        {
            BaseInformationPanelViewModel = argument switch
            {
                // Of course you should use dependency injecton
                // or at least factories :).
                "Users" => new UserInfoPanelViewModel(),
                "Pockets" => new PocketsInfoPanelViewModel(),
                "Trays" => new TrayInfoPanelViewModel(),
                _ => new UserInfoPanelViewModel() // a default value for switch
            };
        }
    }
}
