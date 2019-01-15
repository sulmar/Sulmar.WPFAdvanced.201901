using Sulmar.WPF.Advanced.IServices;
using System.Collections.Generic;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public abstract class ItemsViewModel<TItem> : ViewModelBase
    {
        public IEnumerable<TItem> Items { get; set; }

        public TItem SelectedItem { get; set; }

        private readonly IItemsService<TItem> itemsService;

        public ItemsViewModel(IItemsService<TItem> itemsService)
        {
            this.itemsService = itemsService;

            Load();
        }

        protected virtual void Load()
        {
            Items = itemsService.Get();
        }
    }
}
