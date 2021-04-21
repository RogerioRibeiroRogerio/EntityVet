using Microsoft.EntityFrameworkCore;
using System;

namespace EntityVet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Animals!");
        }
    }
    class VetBD : DbContext
    {
        public DbSet<Customer> Custumers { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sessao3App2;Integrated Security=True;");
        }
    }
}
