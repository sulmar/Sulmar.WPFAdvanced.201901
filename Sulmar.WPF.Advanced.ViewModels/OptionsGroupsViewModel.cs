using Sulmar.WPF.Advanced.IServices;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public class OptionsGroupsViewModel : ItemsViewModel<OptionsGroup>
    {
        public OptionsGroupsViewModel(IOptionsGroupsService itemsService) 
            : base(itemsService)
        {
        }
    }
}
