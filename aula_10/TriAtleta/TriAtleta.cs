using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriAtleta
{
    public class TriAtleta : Pessoa, ICiclista, ICorredor, INadador
    {
        public TriAtleta(string nome) : base(nome)
        {
        }

        public void Aquecer()
        {
            Console.WriteLine("Aquecendo");
        }

        public void Correr()
        {
            Console.WriteLine("correndo");
        }

        public void Nadar()
        {
            Console.WriteLine("nadando");
        }

        public void Pedalar()
        {
            Console.WriteLine("pedalando");
        }
    }
}
