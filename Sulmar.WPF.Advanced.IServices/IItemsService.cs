using System.Collections.Generic;

namespace Sulmar.WPF.Advanced.IServices
{
    public interface IItemsService<TItem>
    {
        IEnumerable<TItem> Get();
        TItem Get(int id);
    }
}
