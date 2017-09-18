using System.Data.Entity;

namespace TwoDataBaseProject.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("TestDB")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}