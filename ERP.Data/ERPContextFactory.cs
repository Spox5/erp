using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace ERP.Data
{
    class ERPContextFactory : IDesignTimeDbContextFactory<ERPContext>
    {
        private string connectionString = "Server=DESKTOP-IOTHK51\\SQLEXPRESS;Database=ERP;Trusted_Connection=True;";
        public ERPContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ERPContext>();

            return new ERPContext(builder.UseSqlServer(connectionString).Options);
        }
    }
}
