using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data.Models;
using EFCSession2G02FluentAPIS;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=ABOHABIB\\MSSQLSERVER01;Database=DemoEf02;Trusted_Connection=True;Trustservercertificate=True");
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Employee
            //modelBuilder.Entity<Employee>()
            //        .Property<string>("Address")
            //        .HasColumnType("varchar")
            //        .HasMaxLength(50)
            //        .IsRequired(); 
            #endregion

            #region Department
            modelBuilder.Entity<Department>()
                //.HasKey("DeptId") // first way to detecct key
                //.HasKey(d => d.DeptId) // second way to detecct key
                .HasKey(nameof(Department.DeptId)); // third way to detecct key *BETTER*
            modelBuilder.Entity<Department>()
                .Property(p => p.DeptId).UseIdentityColumn(10,10);
            modelBuilder.Entity<Department>()
                .Property(D => D.Name)
                .HasColumnName("DepartmentName")
                .HasColumnType("varchar")
                .IsRequired();
            modelBuilder.Entity<Department>()
                .Property(P => P.CreationDate)
                .HasDefaultValueSql("GETDATE()");
            #endregion
        }
    }
}
