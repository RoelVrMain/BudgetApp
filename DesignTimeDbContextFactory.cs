using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using BudgetApp.Models;

namespace BudgetApp
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=budgetapp.db");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}