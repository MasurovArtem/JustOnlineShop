using System.Collections.Generic;
using JustOnlineShop.Data.Models;

namespace JustOnlineShop.Data.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> Categories { get;}

    }
}