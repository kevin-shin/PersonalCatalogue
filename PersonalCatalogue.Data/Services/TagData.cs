using System;
using System.Collections.Generic;
using PersonalCatalogue.Data.ServiceInterfaces;
using PersonalCatalogue.Models;

namespace PersonalCatalogue.Data.Services
{
    public class TagData : ITagData
    {
        public TagData()
        {
        }

        public Item Create(Tag newTag)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Item GetTagById(int itemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetTags(string name)
        {
            throw new NotImplementedException();
        }

        public Item Update(Tag updatedTag)
        {
            throw new NotImplementedException();
        }
    }
}
