using JustOnlineShop.Data.Interfaces;
using JustOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JustOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public ViewResult Index()
        {
            var homeVm = new HomeViewModel()
            {
                PreferredItems = _itemRepository.PreferredItems
            };

            return View(homeVm);
        }
    }
}