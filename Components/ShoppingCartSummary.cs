using System.Collections.Generic;
using JustOnlineShop.Data.Models;
using JustOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JustOnlineShop.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotalPrice = _shoppingCart.GetShoppingCartTotalPrice()
            };

            return View(shoppingCartViewModel);
        }
    }
}