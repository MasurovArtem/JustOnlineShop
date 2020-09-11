using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JustOnlineShop.Data.Interfaces;
using JustOnlineShop.Data.Models;

namespace JustOnlineShop.Data.Mock
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>()
                {
                    new Category(){ CategoryName = "Alcohol", Description = "All Alcohol"},
                    new Category(){ CategoryName = "Non-Alcohol", Description = "All Non-Alcohol"}
                };
            }
        }
    }
}
