using System;
using System.Collections.Generic;
using PersonalCatalogue.Models;

namespace PersonalCatalogue.Data.ServiceInterfaces
{
    public interface ITagData
    {
        IEnumerable<Item> GetTags(string name);
        Item GetTagById(int itemId);
        Item Update(Tag updatedTag);
        Item Create(Tag newTag);
        void Delete(int id);
    }
}
