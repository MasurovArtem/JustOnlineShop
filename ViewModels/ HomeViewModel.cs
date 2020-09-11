using System.Collections.Generic;
using JustOnlineShop.Data.Models;

namespace JustOnlineShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Item> PreferredItems { get; set; }
    }
}