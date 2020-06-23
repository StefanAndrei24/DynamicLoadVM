using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDesingVMLoading.ViewModels.SubViewModels
{
    public class PocketsInfoPanelViewModel : BaseInformationPanelViewModel
    {
        private int _selectedTab;

        public int SelectedTab
        {
            get => _selectedTab;

            set
            {
                _selectedTab = value;

                // NotifyOnPropertyChanged(() => SelectedTab);
            }
        }

        public void LoadSideBarViewModels()
        {
            this.BaseSideBarViewModel = SelectedTab switch
            {
                // The TabItem index starts from 0.
                0 => new PocketsTabItemOneSideBarViewModel(),
                1 => new PocketsTabItemTwoSideBarViewModel(),
                _ => new PocketsTabItemOneSideBarViewModel()
            };
        }
    }
}
