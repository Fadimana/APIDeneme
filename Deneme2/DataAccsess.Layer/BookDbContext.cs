using DataAccsess.Layer.Entitys;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess.Layer
{
    public class BookDbContext :DbContext 
    {
        public DbSet<Book> Books { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}