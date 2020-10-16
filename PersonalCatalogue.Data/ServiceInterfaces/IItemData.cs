using System;
using System.Collections.Generic;

namespace PersonalCatalogue.Data
{
    public interface IItemData
    {
        IEnumerable<Item> GetItems(string name);
        Item GetItemById(int itemId);
        Item Update(Item updatedItem);
        Item Create(Item newItem);
        void Delete(int id);
    }
}
