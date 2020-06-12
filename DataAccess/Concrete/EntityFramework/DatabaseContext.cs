using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class DatabaseContext : DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=OnlinePhoneBook;Integrated Security=True;");
        }

        public DbSet<Phones> Tbl_Phones { get; set; }
        public DbSet<Contacts> Tbl_Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}