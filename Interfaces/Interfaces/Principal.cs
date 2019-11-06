using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Principal
    {
        Operacion Op = new Operacion();
        public void Bienvenido()
        {
            Console.WriteLine("Bienvenido al programa calculadora");
            Menu();
            Console.ReadKey();
        }
        public void Menu()
        {
            Console.WriteLine("Elige la opcion que desea realizar ");
            Console.WriteLine("1.- Sumar ");
            Console.WriteLine("2.- Restar ");
            Console.WriteLine("3.- Multiplicar ");
            Console.WriteLine("4.- Dividir ");
            Console.WriteLine("5.- Salir del programa ");
            switch (Console.ReadLine())
            {
                case "1":
                    Op.Suma();

                    break;
                case "2":
                    Op.Resta();

                    break;
                case "3":
                    Op.Mutiplicar();

                    break;
                case "4":

                    Op.Dividir();
                    break;
                case "5":

                    Environment.Exit(0);
                    break;

            }
            Menu();
        }
    }
}
