using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABOHABIB\\MSSQLSERVER01;Database=DemoEf02;Trusted_Connection=True;Trustservercertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
