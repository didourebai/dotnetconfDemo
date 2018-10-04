using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace DotnetConfSample.Models
{
    public class ItemRepository : IItemRepository
    {
        private static ConcurrentDictionary<string, Item> items =
            new ConcurrentDictionary<string, Item>();

        public ItemRepository()
        {
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Session 1", Description = "C'est une session sur ASP.NET Core 2.1." });
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Session 2", Description = "C'est une session sur Xamarin.Forms." });
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Session 3", Description = "C'est une session sur Windows Azure." });
        }

        public Item Get(string id)
        {
            return items[id];
        }

        public IEnumerable<Item> GetAll()
        {
            return items.Values;
        }

        public void Add(Item item)
        {
            item.Id = Guid.NewGuid().ToString();
            items[item.Id] = item;
        }

        public Item Find(string id)
        {
            Item item;
            items.TryGetValue(id, out item);

            return item;
        }

        public Item Remove(string id)
        {
            Item item;
            items.TryRemove(id, out item);

            return item;
        }

        public void Update(Item item)
        {
            items[item.Id] = item;
        }
    }
}
