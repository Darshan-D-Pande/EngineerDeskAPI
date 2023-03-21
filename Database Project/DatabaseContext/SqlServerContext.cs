using Database_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Project.DatabaseContext
{
    public class SqlServerContext :DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext>dbContextOptions) : base(dbContextOptions)
        {

        }

        //create dbset for table
        public DbSet<Employee>Employee { get; set; }

        //create method which map with table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //passing employee entity by mapping the key
            modelBuilder.Entity<Employee>().HasKey(e => e.EmpId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
