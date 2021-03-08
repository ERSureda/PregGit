using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            char mpreg;
            Console.Clear();
            Console.WriteLine("\n\tMENU \n");
            Console.WriteLine("\t\t   1- Matematicas.");
            Console.WriteLine("\t\t   2- RedSock.");
            Console.WriteLine("\t\t   3- Mercadona.");
            Console.WriteLine("\n\t\t    Presionar Q per tencar el programa.");


            Console.WriteLine("Introdueix el valor: ");
            mpreg = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (mpreg)
            {
                case '1':
                    Tema1();
                    break;
                case '2':
                    Tema2();
                    break;
                case '3':
                    Tema3();
                    break;
                case 'Q':
                    break;
                case 'q':
                    break;
            }
        }

        static void Tema1()
        {

        }

        static void Tema2()
        {

        }

        static void Tema3()
        {

        }
    }
}
