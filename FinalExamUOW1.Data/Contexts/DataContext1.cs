using FinalExamUOW1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalExamUOW1.Data.Contexts
{
    public class DataContext1:DbContext
    {
        public DataContext1(DbContextOptions<DataContext1> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
