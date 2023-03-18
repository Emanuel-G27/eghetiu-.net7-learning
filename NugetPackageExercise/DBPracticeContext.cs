using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NugetPackageExercise
{
    public class DBPracticeContext : DbContext
    {
        string connectionString = "Server=localhost;Database=EntityFramework;User Id=sa;Password=Emanuel127;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
           OptionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Book> Books { get; set; } 
    }
}
