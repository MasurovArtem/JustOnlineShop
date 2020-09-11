using System;
using System.Collections.Generic;
using System.Linq;
using JustOnlineShop.Data.Interfaces;
using JustOnlineShop.Data.Models;

namespace JustOnlineShop.Data.Mock
{
    public class MockItemRepository : IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Item> Items =>
            new List<Item>()
            {
                new Item
                {
                    Name = "Beer",
                    Price = 24.55m,
                    ShortDescription = "The most widely consumed alcohol",
                    LongDescription =
                        "The long text The long text The long text The long text The long text The long text The long text The long text The long text",
                    Category = _categoryRepository.Categories.First(),
                    ImageUrl =
                        "https://images.squarespace-cdn.com/content/59c3feb149fc2b152179e47e/1520645676306-NGOLJTF29X2H8JM4TFJ6/dot-beer.jpg?content-type=image%2Fjpeg",
                    InStock = true,
                    IsPreferredItem = true,
                },
                new Item
                {
                    Name = "Whiskey",
                    Price = 524.65m,
                    ShortDescription = "The most widely consumed alcohol",
                    LongDescription =
                        "The long text The long text The long text The long text The long text The long text The long text The long text The long text",
                    Category = _categoryRepository.Categories.First(),
                    ImageUrl = "https://alcoshopping.com.ua/image/cache/catalog/evanviljams05-500x500.jpg",
                    InStock = true,
                    IsPreferredItem = true,
                },
                new Item {
                    Name = "Tequila",
                    Price = 12.95M, ShortDescription = "Beverage made from the blue agave plant.",
                    LongDescription = "Tequila (Spanish About this sound (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi).",
                    Category =  _categoryRepository.Categories.First(),
                    ImageUrl = "http://imgh.us/tequilaL.jpg",
                    InStock = true,
                    IsPreferredItem = false,
                },
                new Item
                {
                    Name = "Juice",
                    Price = 12.95M,
                    ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                    LongDescription = "Contrary to popular belief,   is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard , a Latin professor at -Sydney College in Virginia, looked up one of the more obscure Latin words,",
                    Category = _categoryRepository.Categories.Last(),
                    ImageUrl = "http://imgh.us/juiceL.jpg",
                    InStock = true,
                    IsPreferredItem = false,
                }
            };

        public IEnumerable<Item> PreferredItems { get; }
        public Item GetItemById(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}