using System.Linq;
using JustOnlineShop.Data.Interfaces;
using JustOnlineShop.Data.Models;
using JustOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JustOnlineShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IItemRepository itemRepository, ShoppingCart shoppingCart)
        {
            _itemRepository = itemRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartVm = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotalPrice = _shoppingCart.GetShoppingCartTotalPrice()
            };

            return View(shoppingCartVm);
        }

        public RedirectToActionResult AddToShoppingCart(int itemId)
        {
            var selectedItem = _itemRepository.Items.FirstOrDefault(i => i.ItemId == itemId);

            if (selectedItem != null)
            {
                _shoppingCart.AddToCart(selectedItem, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int itemId)
        {
            var selectedItem = _itemRepository.Items.FirstOrDefault(i => i.ItemId == itemId);

            if (selectedItem != null)
            {
                _shoppingCart.RemoveFromCart(selectedItem);
            }

            return RedirectToAction("Index");
        }

    }
}