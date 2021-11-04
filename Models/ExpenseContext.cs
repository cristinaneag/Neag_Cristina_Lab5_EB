using Microsoft.EntityFrameworkCore;

namespace Neag_Cristina_Lab5_EB.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
        : base(options)
        {
        }
        public DbSet<Expense> Expense { get; set; }

        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}
