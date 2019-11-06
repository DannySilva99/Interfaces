using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Operacion : Valores, DivisionYMultiplicacion, SumaYResta
    {
        public void Dividir()
        {
            double res;
            Console.WriteLine("Dividir:");
            Console.WriteLine("Ingrese el numero que quiere dividir:");
            Numero_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el divisor");
            Numero_2 = Convert.ToDouble(Console.ReadLine());
            res = Numero_1 / Numero_2;
            Console.WriteLine("El resultado es: " + res);
            Console.ReadKey();
            Console.Clear();
        }
        public void Mutiplicar()
        {
            double res;
            Console.WriteLine("Multiplicar:");
            Console.WriteLine("Ingrese el primer numero:");
            Numero_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el otro numero");
            Numero_2 = Convert.ToDouble(Console.ReadLine());
            res = Numero_1 * Numero_2;
            Console.WriteLine("El resultado es: " + res);
            Console.ReadKey();
            Console.Clear();
        }
        public void Resta()
        {
            double res;
            Console.WriteLine("Restar:");
            Console.WriteLine("Ingrese el primer numero:");
            Numero_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            Numero_2 = Convert.ToDouble(Console.ReadLine());
            res = Numero_1 - Numero_2;
            Console.WriteLine("El resultado es: " + res);
            Console.ReadKey();
            Console.Clear();
        }
        public void Suma()
        {
            double res;
            Console.WriteLine("Sumar:");
            Console.WriteLine("Ingrese el primer numero:");
            Numero_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            Numero_2 = Convert.ToDouble(Console.ReadLine());
            res = Numero_1 + Numero_2;
            Console.WriteLine("El resultado es: " + res);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
