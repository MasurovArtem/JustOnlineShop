using System.Collections.Generic;
using System.Linq;
using JustOnlineShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace JustOnlineShop.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Items.Any())
            {
                context.AddRange
                (
                    new Item
                    {
                        Name = "Caffee Tomeucci Rossa Blend Beans",
                        Price = 325.00M,
                        ShortDescription = "Italians are master coffee blenders and Caffe’ Tomeucci is no exception.",
                        LongDescription =
                            "Italians are master coffee blenders and Caffe’ Tomeucci is no exception. Since 1883 Caffe’ Tomeucci has been sourcing and blending top quality single origin coffee from around the globe. With over 130 years of dedication to the coffee industry, this coffee’s quality is guaranteed.",
                        Category = Categories["Coffee"],
                        ImageUrl = "https://onlinecoffeeshop.co.za/wp-content/uploads/2015/06/CAFFETOMEUCCIrossa.png",
                        InStock = false,
                        IsPreferredItem = true,
                    },
                    new Item
                    {
                        Name = "Single Origin Coffee Beans",
                        Price = 93.00M,
                        ShortDescription = "Guatemala SHB Huehuetenango – Single Origin Speciality Coffee Beans.",
                        LongDescription =
                            "Coffee production in Guatemala began to develop in the 1850s. Coffee is an important element of Guatemala’s economy. Guatemala was Central America’s top producer of coffee for most of the 20th and the beginning of the 21st century..",
                        Category = Categories["Coffee"],
                        ImageUrl = "https://www.shopcoffee.co.uk/wp-content/uploads/2017/02/Guatemala-SHB-Huehuetenango-768x755.png",
                        InStock = true,
                        IsPreferredItem = true,
                    },
                    new Item
                    {
                        Name = "Especial Lempira, Single Origin Coffee Beans",
                        Price = 76.00M,
                        ShortDescription = "Honduras San Andres Especial Lempira, Single Origin Coffee Beans.",
                        LongDescription =
                            "The coffee production in Honduras played a role in the country’s history and is important for the Honduran economy. In 2011, the country became Central America’s top producer of coffee. The cultivation of the coffee plant was in its infancy in the Republic of Honduras at the end of the 19th century. While there were numerous coffee plantations at the time, they were small. The soil, climate, and conditions in Honduras are the same as those of Guatemala, Nicaragua, or Costa Rica.",
                        Category = Categories["Coffee"],
                        ImageUrl = "https://onlinecoffeeshop.co.za/wp-content/uploads/2015/06/CAFFETOMEUCCIrossa.png",
                        InStock = false,
                        IsPreferredItem = false,
                    },
                    new Item
                    {
                        Name = "Decaffeinated Coffee Bags",
                        Price = 39.49M,
                        ShortDescription = "Coffee Bags are taking the world by storm. ",
                        LongDescription =
                            "Coffee Bags are taking the world by storm. If you, too, are looking for quality, ease and great taste, coupled with minimal caffeine, you’ve come to the right place. Our Decaffeinated Coffee Bags offer all of this and so much more.",
                        Category = Categories["Coffee"],
                        ImageUrl = "https://www.tea-and-coffee.com/media/amasty/webp/catalog/product/cache/4d236cf5fe8c7ee1041ddbc87a4ed182/d/e/decaffeinated_coffee_bags_copy.webp",
                        InStock = true,
                        IsPreferredItem = false,
                    },
                    new Item
                    {
                        Name = "Nepal Himshikhar Black Tea Organic",
                        Price = 44.60M,
                        ShortDescription = "Nepal Himshikhar Black Tea Organic consists of beautifully-worked, olive-coloured leaves with green inserts and a high proportion of silver tips. ",
                        LongDescription =
                            "Nepal Himshikhar Black Tea Organic consists of beautifully-worked, olive-coloured leaves with green inserts and a high proportion of silver tips. Its finer qualities transcend upon brewing, whereby it offers a flowery, fresh, complex taste rounded off with muscatel undertones.",
                        Category = Categories["Tea"],
                        ImageUrl = "https://www.tea-and-coffee.com/media/amasty/webp/catalog/product/cache/4d236cf5fe8c7ee1041ddbc87a4ed182/n/e/nepal_himshikhar_sftgfop1_organic_black_tea.webp",
                        InStock = true,
                        IsPreferredItem = false,
                    },
                    new Item
                    {
                        Name = "Organic Darjeeling Tea Risheehat",
                        Price = 40.30M,
                        ShortDescription = "Organic Darjeeling Tea Risheehat is an Indian Estate Black Tea produced high up in the Himalayas. ",
                        LongDescription =
                            "Organic Darjeeling Tea Risheehat is an Indian Estate Black Tea produced high up in the Himalayas. It comes from the region’s Mid Season Flush, which means it’s usually harvested between June and July.",
                        Category = Categories["Tea"],
                        ImageUrl = "https://www.tea-and-coffee.com/media/catalog/product/cache/4d236cf5fe8c7ee1041ddbc87a4ed182/d/a/darjeeling_risheehat_ftgfop1_brewed_leaves_1.jpg",
                        InStock = true,
                        IsPreferredItem = true,
                    },
                    new Item
                    {
                        Name = "Golden Nepal Black Tea",
                        Price = 250.00M,
                        ShortDescription = "Golden Nepal Black Tea comes from a family run smallholder business at altitudes between 1,000 and 2,000 metres above sea level. ",
                        LongDescription =
                            "The unique climatic conditions found here contribute significantly to the quality, character and taste of this infusion. It consists of medium-sized, well-worked leaves with many tips, which, when brewed, offer a light, smoky sweetness - a rare delight from start to finish.",
                        Category = Categories["Tea"],
                        ImageUrl = "https://www.tea-and-coffee.com/media/amasty/webp/catalog/product/cache/e39eb8ff6e45642cc12047f80e8ede85/n/e/nepal_golden_black_tea.webp",
                        InStock = true,
                        IsPreferredItem = true,
                    },
                    new Item
                    {
                        Name = "Nepalese Jun Chiyabari Tea First Flush 2020",
                        Price = 250.00M,
                        ShortDescription = "Nepalese Jun Chiyabari Tea First Flush 2020 is a type of Black Tea from this year’s harvest.",
                        LongDescription =
                            "Nepalese Jun Chiyabari Tea First Flush 2020 is a type of Black Tea from this year’s harvest. It comes from the Jun Chiyabari Tea Estate, a relatively new garden, which has been building its outstanding reputation in Nepal and beyond.",
                        Category = Categories["Tea"],
                        ImageUrl = "https://www.tea-and-coffee.com/media/amasty/webp/catalog/product/cache/4d236cf5fe8c7ee1041ddbc87a4ed182/n/e/nepal_first_flush_jun_chiyabari_20.webp",
                        InStock = true,
                        IsPreferredItem = true,
                    },
                    new Item
                    {
                        Name = "Organic Darjeeling Tea FTGFOP1",
                        Price = 70.00M,
                        ShortDescription = "Organic Darjeeling Tea FTGFOP1 is a type of Indian Black Tea.",
                        LongDescription =
                            "It comes from the Darjeeling district of West Bengal, an area known for producing “the champagne of Tea”. This beverage is, of course, no exception, going above and beyond to impress casual drinkers and connoisseurs alike. We pack it fresh to order, ensuring not only quality but also consistency.",
                        Category = Categories["Tea"],
                        ImageUrl = "https://www.tea-and-coffee.com/media/amasty/webp/catalog/product/cache/4d236cf5fe8c7ee1041ddbc87a4ed182/d/a/darjeeling_organic_ftgfop1.webp",
                        InStock = true,
                        IsPreferredItem = false,
                    });
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> _categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category {CategoryName = "Coffee", Description = "All coffee"},
                        new Category {CategoryName = "Tea", Description = "All tea"}
                    };

                    _categories = new Dictionary<string, Category>();

                    foreach (var genre in genresList)
                    {
                        _categories.Add(genre.CategoryName, genre);
                    }
                }

                return _categories;
            }
        }
    }
}