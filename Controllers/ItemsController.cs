using System;
using System.Collections.Generic;
using System.Linq;
using JustOnlineShop.Data.Interfaces;
using JustOnlineShop.Data.Models;
using JustOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JustOnlineShop.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IItemRepository _itemRepository;

        public ItemsController(ICategoryRepository categoryRepository, IItemRepository itemRepository)
        {
            _categoryRepository = categoryRepository;
            _itemRepository = itemRepository;
        }

        public ViewResult List(string incomingCategory)
        {
            var category = incomingCategory;
            IEnumerable<Item> items;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                items = _itemRepository.Items.OrderBy(p => p.ItemId);
                currentCategory = "All products";
            }
            else
            {
                if (string.Equals("Coffee", category, StringComparison.OrdinalIgnoreCase))
                    items = _itemRepository.Items.Where(p => p.Category.CategoryName.Equals("Coffee")).OrderBy(p => p.Name);
                else
                    items = _itemRepository.Items.Where(p => p.Category.CategoryName.Equals("Tea")).OrderBy(p => p.Name);

                currentCategory = category;
            }

            return View(new ItemListViewModel()
            {
                Items = items,
                CurrentCategory = currentCategory
            });
        }
    }
}