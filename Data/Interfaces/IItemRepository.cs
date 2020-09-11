using System.Collections;
using System.Collections.Generic;
using JustOnlineShop.Data.Models;

namespace JustOnlineShop.Data.Interfaces
{
    public interface IItemRepository
    {
        public IEnumerable<Item> Items { get; }
        public IEnumerable<Item> PreferredItems { get; }
        public Item GetItemById(int id);
    }
}