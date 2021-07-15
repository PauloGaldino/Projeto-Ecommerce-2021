using Entity.Entities.Persons.Users;
using Entity.Entities.ProductEntity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class BaseContext : IdentityDbContext<ApplicationUser>
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
            //Data Source=(localdb)\\MSSQLLocalDB
            //Data Source=DESKTOP-PAULO\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            string strCon = "Data Source=DESKTOP-PAULO\\SQLEXPRESS;Initial Catalog=Ecommerce2021;Integrated Security=True";
            return strCon;
        }
    }
}
