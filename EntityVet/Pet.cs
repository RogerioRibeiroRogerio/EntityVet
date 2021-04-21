using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityVet
{
    class Pet
    {
        public int PetID { get; set; } //chave primaria da class PET
        public int CustomerID { get; set; } // chave estrangeira da PET para Customer
        public string NamePet { get; set; }
        public string TypeOfPet { get; set; }
        public string WeightPet { get; set; }
    }
}
