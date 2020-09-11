using System.Collections.Generic;
using System.Linq;
using JustOnlineShop.Data.Interfaces;
using JustOnlineShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JustOnlineShop.Data.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;
        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Item> Items => _appDbContext.Items.Include(c => c.Category);

        public IEnumerable<Item> PreferredItems => _appDbContext.Items.Where(p => p.IsPreferredItem).Include(c => c.Category);

        public Item GetItemById(int itemId) => _appDbContext.Items.FirstOrDefault(p => p.ItemId == itemId);
    }
}