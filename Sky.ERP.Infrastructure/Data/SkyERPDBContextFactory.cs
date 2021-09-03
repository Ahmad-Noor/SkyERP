using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Sky.ERP.Infrastructure.Data
{
    public class SkyERPDBContextFactory : IDesignTimeDbContextFactory<SkyERPDBContext>
    {
        public SkyERPDBContext CreateDbContext(string[] args)
        { 
            var connectionString = "Data Source=localhost;Initial Catalog=Sky-ERP;Persist Security Info=True;User ID=sa;Password=sa"; 
            return new SkyERPDBContext(connectionString);
        }
    }
}
