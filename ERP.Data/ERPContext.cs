using ERP.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP.Data
{
    public class ERPContext : DbContext
    {
        public DbSet<BudgetHolder> BudgetHolders { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public ERPContext(DbContextOptions<ERPContext> dbContextOptions) : base(dbContextOptions) { }

    }
}
