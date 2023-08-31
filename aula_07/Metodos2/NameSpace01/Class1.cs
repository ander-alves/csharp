using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2.NameSpace01
{
    internal class Class1
    {
        public static void MetodoPublico() 
        {
            Console.WriteLine("Metodo Publico - Classe 02");
        }
        internal static void MetodoInternal() 
        {
            Console.WriteLine("Metodo Internal - Classe 02");
        }
        protected static void MetodoProtect() 
        {
            Console.WriteLine("Metodo protect - Classe 02");
        }
        private static void MetodoPrivate()
        {
            Console.WriteLine("Metodo protect - Classe 02");
        }
    }
}
