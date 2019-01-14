﻿using SimpleInventory.Helpers;
using SimpleInventory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleInventory.ViewModels
{
    class ViewQuantityAdjustmentsViewModel : BaseViewModel
    {

        public ViewQuantityAdjustmentsViewModel(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {
        }

        public ICommand ReturnToManageItems
        {
            get { return new RelayCommand(PopToManageItems); }
        }

        private void PopToManageItems()
        {
            PopViewModel();
        }
    }
}