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

        public DbSet<Cart_detail>  Cart_Details { get; set; }

        public DbSet<Invoice>  invoices { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cart_detail>().HasKey(o => new { o.cart_id, o.product_id });
             // Bỏ tiền tố AspNet của các bảng: mặc định
            foreach (var entityType in modelBuilder.Model.GetEntityTypes ()) {
                var tableName = entityType.GetTableName ();
                if (tableName.StartsWith ("AspNet")) {
                    entityType.SetTableName (tableName.Substring (6));
                }
            
        }
        }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options){}
    }
}