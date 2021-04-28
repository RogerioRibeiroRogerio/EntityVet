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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typeofani = textBox1.Text;
            textBox1.Text = "";

            // Tabela do Custumers 

            //bd.Customers.Add(o1);
            //bd.SaveChanges();

            BDveteriano bd;
            using (bd = new BDveteriano())
            {
                //Teste: adicionar um Utente:
                TypeOfVet o1 = new TypeOfVet() { typeofAnimal = typeofani };
                bd.TypeOfVets.Add(o1);
                bd.SaveChanges();
            }
        }
    }
}
