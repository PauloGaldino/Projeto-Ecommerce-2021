using Entity.Entities.Persons.Users;
using Entity.Entities.ProductEntity;
using Entity.Entities.ShopEntity;
using Microsoft.AspNetCore.Identity;
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
        public DbSet<UserShop> UserShop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Personalizando os nomes das tabelas No Identity
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>(b =>
            {
                b.ToTable("Identity_Usuario");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.ToTable("Identity_UsuarioDeclaracao");

            });

            modelBuilder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.ToTable("Identity_UsuarioLogins");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(b =>
            {
                b.ToTable("Identity_UsuarioTokens");
            });

            modelBuilder.Entity<IdentityRole>(b =>
            {
                b.ToTable("Identity_Funcao");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(b =>
            {
                b.ToTable("Identity_FuncaoDeclaracao");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(b =>
            {
                b.ToTable("Identity_UsuarioFuncao");
            });
        }
        private string GetStringConnectionConfig()
        {
            //Data Source=(localdb)\\MSSQLLocalDB
            //Data Source=DESKTOP-PAULO\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            string strCon = "Data Source=DESKTOP-PAULO\\SQLSERVEREXPRESS;Initial Catalog=Ecommerce2021;Integrated Security=True";
            return strCon;
        }
    }
}
