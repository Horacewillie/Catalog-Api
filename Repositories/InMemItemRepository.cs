using System;
using System.Collections.Generic;
using System.Linq;
using CatalogApi.Entities;
using CatalogApi.Repositories;

namespace CatalogApi.Repositories
{


    public class InMemItemRepository : IItemRepository
    {
        private readonly List<Item> items = new()
        {
            new Item() { Id = Guid.NewGuid(), Name = "Price of Persian", Price = 100, CreatedAtDate = DateTimeOffset.UtcNow },
            new Item() { Id = Guid.NewGuid(), Name = "Potion", Price = 10, CreatedAtDate = DateTimeOffset.UtcNow },
            new Item() { Id = Guid.NewGuid(), Name = "Mortal Combat", Price = 20, CreatedAtDate = DateTimeOffset.UtcNow }

        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            var item = items.Where(item => item.Id == id).SingleOrDefault();
            return item;

        }

    }
}