using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PersonalCatalogue.Data
{

    public class InMemoryItemsData : IItemData
    {
        public List<Item> _items { get; set; }

        public InMemoryItemsData()
        {
            _items = new List<Item>()
            {
                new Item
                {
                    ItemId = 1,
                    Name = "Vile Bodies",
                    Purchased = new DateTime(),
                    Description = "A novel by Evenlyen Waugh",
                    TagId = 0,
                    ImagePath = "Vile_bodies.png",
                    Price = 10.50
                },
                new Item
                {
                    ItemId=2,
                    Name = "Th Death of Ivan Lynch",
                    Purchased = new DateTime(),
                    Description = "A novel by Leo Tolstoy",
                    TagId = 2,
                    ImagePath = "ivan_lynch.png",
                    Price = 11.45
                },
                new Item
                {
                    ItemId=3,
                    Name = "Atonement",
                    Purchased = new DateTime(),
                    Description = "A novel by Ian McEwan",
                    TagId = 1,
                    ImagePath = "Ian_Mc.png",
                    Price = 10.50
                }
            };
        }

        public IEnumerable<Item> GetItems(string name)
        {
            return from r in _items
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        public Item GetItemById(int itemId)
        {
            return _items.SingleOrDefault(r => r.ItemId == itemId);
        }

        public Item Update(Item updatedItem)
        {
            var item = _items.SingleOrDefault(item => item.ItemId == updatedItem.ItemId);
            if (item != null)
            {
                item.Name = updatedItem.Name;
                item.Description = updatedItem.Description;
                item.Price = updatedItem.Price;
            }

            return item;
        }

        public Item Create(Item newItem)
        { 
            var maxId = _items.Max(item => item.ItemId);
            newItem.ItemId = maxId + 1;
            _items.Add(newItem);
            return newItem;

        }


        public int Commit()
        {
            return 0;
        }

        public void Delete(int id)
        {
            var item = _items.FirstOrDefault(r => r.ItemId == id);
            if (item != null)
            {
                _items.Remove(item);
            }
        }
    }
}
