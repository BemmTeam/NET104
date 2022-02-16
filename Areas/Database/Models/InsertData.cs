
using System.Threading.Tasks;
using ASMMAIN.Models;
namespace ASMMAIN.Areas.Models
{
    public class InsertData
    {

        public readonly ShopContext dbcontext;

        public InsertData(ShopContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public async Task insertCategory()
        {



            var categories = new object[] {
                new Category() {name = "Lego Marvel Super Heroes"},
                new Category() {name = "Lego Ninjago"},
                new Category() {name = "Lego Star Wars"},
                new Category() {name = "Lego Star Pop"},
                new Category() {name = "Lego Star Anime"}
            };

            dbcontext.AddRange(categories);
            await dbcontext.SaveChangesAsync();
        }


        public async Task insertProduct()
        {



            var products = new object[] {
                new Product(){name= "DC Batman NO 14", price = 21000, quantity = 13, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp1.jpg" , category_id = 1 },
                 new Product(){name= "DC Flash NO 3", price = 2000000, quantity = 32, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp2.jpg" , category_id = 1 },
                new Product(){name= "DC Sinestro NO 2", price = 190000, quantity = 21, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp3.jpg" , category_id = 1 },
                new Product(){name= "Ninjago 71735 Tournament of Elements", price = 890000, quantity = 43, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp4.jpg" , category_id = 2 },
                new Product(){name= "Ninjago 891945 Wu Foil Pack Polybag", price = 190000, quantity = 16, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp5.jpg" , category_id = 2 },
                new Product(){name= "LEGO Ninjago 891838 Buffer Foil Pack Polybag", price = 130000, quantity = 100, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp6.jpg" , category_id = 2 },
                new Product(){name= "Star Wars 31200 The Sith", price = 4210000, quantity = 30, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp7.jpg" , category_id = 3 },
                new Product(){name= "Star Wars 75239 Action Battle Hoth Generator Attack", price = 790000, quantity = 65, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp8.jpg" , category_id = 3 },
                new Product(){name= "Star Wars 75273 Poe Dameron", price = 900000, quantity = 343, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp9.jpg" , category_id = 3 },
                new Product(){name= "FUNKO POP Overwatch 497 Pharah Special Edition", price = 390000, quantity = 74, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp10.jpg" , category_id = 4 },
                new Product(){name= "FUNKO POP Overwatch 306 Zarya", price = 350000, quantity = 53, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp11.jpg" , category_id = 4 },
                new Product(){name= "FUNKO POP Garbage Pail Kids 01 Adam Bomb", price = 123000, quantity = 6, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp12.jpg" , category_id = 4 },
                new Product(){name= "FUNKO DORBZ Civil War 128 Iron Man Unmasked", price = 210000, quantity = 73, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp13.jpg" , category_id = 5 },
                new Product(){name= "FUNKO POP Spider Man 403 Miles Morales", price = 270000, quantity = 29, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp10.jpg" , category_id = 5 },
                new Product(){name= "FUNKO POP Kingdom Hearts 408 Sora", price = 210000, quantity = 29, description = "sản phẩm làm bằng nhựa ABS an toàn không gây hại cho trẻ khi sử dụng",
                image_url = "sp6.jpg" , category_id = 5 },
                
            };

            dbcontext.AddRange(products);
            await dbcontext.SaveChangesAsync();
        }



        //  1
    }
}