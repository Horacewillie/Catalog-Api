using System;
using System.Collections.Generic;
using CatalogApi.Entities;

namespace CatalogApi.Repositories
{
    public interface IItemRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}