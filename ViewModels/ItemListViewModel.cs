using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JustOnlineShop.Data.Models;

namespace JustOnlineShop.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public string CurrentCategory { get; set; }

    }
}
