using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityVet
{
    class Pet
    {
        public int IdPet { get; set; }
        public string NamePet { get; set; }
        public string TypeOfPet { get; set; }
        public int IdCustumer { get; set; }
        public int MyProperty { get; set; }
        public DateTime BornDateAnimal { get; set; }
    }
}
