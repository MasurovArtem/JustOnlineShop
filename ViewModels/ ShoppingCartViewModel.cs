using JustOnlineShop.Data.Models;

namespace JustOnlineShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotalPrice { get; set; }
    }
}