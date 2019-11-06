using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lamamos a la clase principal que es en donde esta todo
            Principal P = new Principal();
            P.Bienvenido();
            Console.ReadKey();
        }
    }
}
