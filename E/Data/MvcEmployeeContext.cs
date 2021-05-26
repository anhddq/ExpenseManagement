using System;
using ExpenseManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManagement.Data
{
    public class MvcEmployeeContext : DbContext
    {
        public MvcEmployeeContext(DbContextOptions<MvcEmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
