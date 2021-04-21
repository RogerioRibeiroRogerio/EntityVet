using Microsoft.EntityFrameworkCore;
using System;

namespace EntityVet
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "Y";
            while (option == "Y")
            {
                Console.WriteLine("Hello and Welcome to Vet Data Base");
                Console.WriteLine("We need some information about you and your pet: ");
                Console.WriteLine("Your Name?");
                string namecustumer = Console.ReadLine();
                Console.WriteLine("Your Email?");
                string emailcustumer = Console.ReadLine();
                Console.WriteLine("Your Adress?");
                string adresscustumer = Console.ReadLine();
                Console.WriteLine("Telefone ?");
                string telefone = Console.ReadLine();

                Customer o1 = new Customer() { NameCustumer = namecustumer, EmailCustumer = emailcustumer, AdressCustumer = adresscustumer,  Telefone = telefone }; // Tabela do Custumers 
                VetBD bd = new VetBD();
                bd.Custumers.Add(o1);
                bd.SaveChanges();

                Console.WriteLine("Name of the Pet?");
                string namepet = Console.ReadLine();
                Console.WriteLine("What Type Of Animal is your Pet? (Ex: Cat, Dog, Rat, Bird, etc)");
                string typeofpet = Console.ReadLine();
                Console.WriteLine("Weight Pet?");
                string weightpet = Console.ReadLine();
                
                Pet o2 = new Pet() { NamePet = namepet, TypeOfPet = typeofpet, WeightPet = weightpet }; //Tabela dos Pets
                // VetBD bd = new VetBD(); nao é necessarioo pois foi instanciado em cima linha 25
                bd.Pets.Add(o2);
                bd.SaveChanges();
                Console.WriteLine("Do you have more Pets?");
                string awanser = Console.ReadLine();
                option = awanser;
            }
            
        }
    }
    class VetBD : DbContext
    {
        public DbSet<Customer> Custumers { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=VetBD;Trusted_Connection=True;");
        }
    }
}
