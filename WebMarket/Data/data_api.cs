using Microsoft.EntityFrameworkCore;
using WebMarket.models;


namespace WebMarket.Data
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Manufacturer> manufacturers { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Basket> baskets { get; set; }
        public DbSet <Basket_composition> basketcomps { get; set; }
        public ApplicationContext() => Database.EnsureCreated();
        public ApplicationContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            try
            {
                Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=marketdb;Username=postgres;Password=postgres");
        }
    }
}
