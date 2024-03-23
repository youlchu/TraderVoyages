using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TraderVoyages.Infrastructure.Data;

namespace TraderVoyages.Infrastructure.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Burada doğrudan bağlantı dizesini kullanmak yerine, güvenli bir yerden almayı düşünün
            optionsBuilder.UseSqlServer("Server=YOULCHU;Database=traderV;User Id=sa;Password=Yusuf123; TrustServerCertificate=true;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
