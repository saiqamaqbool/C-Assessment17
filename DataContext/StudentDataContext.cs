using Assessment18.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment18.DataContext
{
    public class StudentDataContext : DbContext  
    {
        public StudentDataContext()
        {
        }

        public StudentDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    "server=localhost;database=task18database;user=root;password=mysqlusername@123;",
                    new MySqlServerVersion(new Version(8, 0, 33)) 
                );
            }
        }
    }
}
