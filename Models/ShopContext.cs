using Microsoft.EntityFrameworkCore;
using ASMMAIN.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace ASMMAIN
{
    public class ShopContext : IdentityDbContext<User>
    {
        public DbSet<User>  users { get; set; }
        public DbSet<Product>  products { get; set; }
        public DbSet<Category>  categories { get; set; }
        public DbSet<Cart>  carts { get; set; }

        public DbSet<Invoice>  invoices { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

     

        public ShopContext(DbContextOptions<ShopContext> options) : base(options){}
    }
}