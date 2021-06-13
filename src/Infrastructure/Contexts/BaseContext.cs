using Entity.Entities.ProductEntity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }
        private string GetStringConnectionConfig()
        {
            string strCon = "Data SOurce=(localdb)\\MSSQLLocalDB;Initial Catalog=ControleEstoque;Integrated Security=True";
            return strCon;
        }
    }
}
