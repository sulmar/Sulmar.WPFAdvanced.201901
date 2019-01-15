using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.IServices
{
    public interface IDepartmentsService : IItemsService<Department>
    {
        
    }


    public interface IItemsService<TItem>
    {
        IEnumerable<TItem> Get();
        // TItem Get(int id);
    }
}
