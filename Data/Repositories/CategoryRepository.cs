using System.Collections.Generic;
using JustOnlineShop.Data.Interfaces;
using JustOnlineShop.Data.Models;

namespace JustOnlineShop.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}