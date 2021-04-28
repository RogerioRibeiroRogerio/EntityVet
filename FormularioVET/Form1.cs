
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioVET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string yourName = textBox1.Text;
            textBox1.Text = "";

            string yourEmail = textBox2.Text;
            textBox2.Text = "";

            string yourAdress = textBox3.Text;
            textBox3.Text = "";

            string yourNumber = textBox4.Text;
            textBox4.Text = "";

            Customer o1 = new Customer() { NameCustumer = yourName, EmailCustumer = yourEmail, AdressCustumer = yourAdress, Telefone = yourNumber }; // Tabela do Custumers 

            //bd.Customers.Add(o1);
            //bd.SaveChanges();

            BDveteriano bd;
            using (bd = new BDveteriano())
            {
                //Teste: adicionar um Utente:
                Customer ObjCust = new Customer() { NameCustumer = yourName, EmailCustumer = yourEmail, AdressCustumer = yourAdress, Telefone = yourNumber }; 
                bd.Customers.Add(ObjCust);
                bd.SaveChanges();
                //Preferencialemente usar os métodos ASYNC:
                //bd.SaveChangesAsync();
               // Console.WriteLine("FIM DO INSERT DE UM UTENTE");

                //Mesmo com LAZZY LOADING é possível pedir à EF para carregar as propriedades de navegação declaradas com "virtual" (isto é o explicit loading).
                //var lista = bd.Autorias.Include("Autor").Include("Livro");


                //var consultaDeTodosOsUtentesComNomeAna = bd.Utentes.Where(utente => utente.Nome == "Ana");

                //var consultaEquivalente = from utente in bd.Utentes
                                          //where utente.Nome == "Ana"
                                          //select utente;
            }
        }
        //public class VetBD : DbContext
        //{
        //    public DbSet<FormularioVET.Customer> coco { get; set; }
        //    public DbSet<Pet> Pets { get; set; }

        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=VetBD;Trusted_Connection=True;");
        //    }
        //}
    }
}
