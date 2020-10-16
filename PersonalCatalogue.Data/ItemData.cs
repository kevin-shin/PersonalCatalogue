using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PersonalCatalogue.Data
{
    public class ItemData : IItemData
    {
        private readonly ItemDbContext context;

        public ItemData(ItemDbContext context)
        {
            this.context = context;
        }
  
        public int Commit()
        {
            return context.SaveChanges();
        }

        public Item Create(Item newItem)
        {
            context.Add(newItem);
            return newItem;
        }

        public void Delete(int id)
        {
            var item = GetItemById(id);
            if (item != null)
            {
                context.Remove(item);
            }
        }

        public Item GetItemById(int itemId)
        {
            return context.items.Find(itemId);
        }

        public IEnumerable<Item> GetItemsByName(string name)
        {
            var query = from r in context.items
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;

            return query;
        }

        public IEnumerable<Item> GetItems(string name)
        {
            return context.items.ToList();
        }

        public Item Update(Item updatedItem)
        {
            var entity = context.items.Attach(updatedItem);
            entity.State = EntityState.Modified;
            return updatedItem;
        }
    }
}
