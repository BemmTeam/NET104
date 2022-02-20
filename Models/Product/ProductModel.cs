

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASMMAIN.Models{ 

    public class ProductModel{ 

        private readonly ShopContext context;

        public ProductModel(ShopContext context)
        {
            this.context = context;
        }

        
        public async Task<List<Product>> FindAll() {

            return(await context.products.ToListAsync());
        }

          public async Task<Product> Find(int? id) {

            return(await context.products.FindAsync(id));
        }

    }
}