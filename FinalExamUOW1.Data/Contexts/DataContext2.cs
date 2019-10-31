using FinalExamUOW1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalExamUOW1.Data.Contexts
{
    public class DataContext2:DbContext
    {
        public DataContext2(DbContextOptions<DataContext2> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
