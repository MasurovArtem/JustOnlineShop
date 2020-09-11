using JustOnlineShop.Data.Models;

namespace JustOnlineShop.Data.Interfaces
{
    public interface IOrderRepository
    {
        public void CreateOrder(Order order);
    }
}