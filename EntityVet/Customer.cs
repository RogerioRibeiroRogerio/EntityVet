using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityVet
{
    class Customer
    {
        public int CustomerID { get; set; } // chave primaria da classe Customer
        public string NameCustumer { get; set; }
        public string EmailCustumer { get; set; }
        public string AdressCustumer { get; set; }
        public string Telefone { get; set; }


        // public int IdPet { get; set; } (NAO INSIRO AQUI POIS POSSO TER VÀRIOS ANIMAIS PARA UMA PESSOA E NAO O CONTRARIO)  




    }
}
