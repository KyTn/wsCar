using CarRestAPI.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRestAPI.DataAccess.Concrete.EntityFramework.Context
{
    public class CarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarDB;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
    }
}
