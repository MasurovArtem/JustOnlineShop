﻿using System.Linq;
using JustOnlineShop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JustOnlineShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Categories.OrderBy(p => p.CategoryName);
            
            return View(categories);
        }
    }
}