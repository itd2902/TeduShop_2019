using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TeduShop.Model.Models;

namespace TeduShop.Data
{
    public class TeduShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public TeduShopDbContext() : base("TeduShopDbContext")
        {
            
            //Configuration.LazyLoadingEnabled = false;//load bảng cha không tự động load bảng con
        }

        public DbSet<Footer> Footers { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategorys { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Manu> Manus { get; set; }
        public DbSet<ManuGroup> ManuGroups { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Error> Errors { get; set; }

        public static TeduShopDbContext Create()
        {
            return new TeduShopDbContext();
        }

        //method
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //set primary key for IdentityUserRole,IdentityUserLogin
            modelBuilder.Entity<IdentityUserRole>().HasKey(i=>new { i.UserId,i.RoleId});
            modelBuilder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}