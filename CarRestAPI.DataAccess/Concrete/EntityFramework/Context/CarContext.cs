using CarRestAPI.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarRestAPI.DataAccess.Concrete.EntityFramework.Context
{
    public class CarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CarDB;Trusted_Connection=True;");
        }

        public DbSet<Car> Cars { get; set; }
    }
}
