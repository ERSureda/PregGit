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
            Console.WriteLine("\n\t MENU \n");
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
            char rpreg;
            int r = 0;
            Console.Clear();
            Console.WriteLine("MERCADONA");

            Console.WriteLine("\t\t\t   1- De donde es Mercadona?");
            Console.WriteLine("1. Aleman");
            Console.WriteLine("2. Italiano");
            Console.WriteLine("3. Frances");
            Console.WriteLine("4. Español");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (rpreg)
            {
                case '1':
                    r = r;
                    break;
                case '2':
                    r = r;
                    break;
                case '3':
                    r = r;
                    break;
                case '4':
                    r++;
                    break;
            }


            Console.WriteLine("2- Any de fundació?");
            Console.WriteLine("1. 1975");
            Console.WriteLine("2. 2000");
            Console.WriteLine("3. 1977");
            Console.WriteLine("4. 1981");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (rpreg)
            {
                case '1':
                    r = r;
                    break;
                case '2':
                    r = r;
                    break;
                case '3':
                    r++;
                    break;
                case '4':
                    r = r;
                    break;
            }

            Console.WriteLine("3- El mejor supermercado?");
            Console.WriteLine("1. Bonpreu");
            Console.WriteLine("2. Mercadona");
            Console.WriteLine("3. Suma");
            Console.WriteLine("4. Spar");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (rpreg)
            {
                case '1':
                    r = r;
                    break;
                case '2':
                    r = r;
                    break;
                case '3':
                    r = r;
                    break;
                case '4':
                    r++;
                    break;
            }

            Console.WriteLine("\t\t\t   4- Que color relacionan a mercadona?");
            Console.WriteLine("1. Rojo");
            Console.WriteLine("2. verde");
            Console.WriteLine("3. Marron");
            Console.WriteLine("4. Azul");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (rpreg)
            {
                case '1':
                    r = r;
                    break;
                case '2':
                    r++;
                    break;
                case '3':
                    r = r;
                    break;
                case '4':
                    r = r;
                    break;
            }

            Console.WriteLine("\t\t\t   5- En que pais tiene mas supermercados?");
            Console.WriteLine("1. Portugal");
            Console.WriteLine("2. Italia");
            Console.WriteLine("3. Suiza");
            Console.WriteLine("4. España");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (rpreg)
            {
                case '1':
                    r = r;
                    break;
                case '2':
                    r = r;
                    break;
                case '3':
                    r = r;
                    break;
                case '4':
                    r++;
                    break;
            }
            Console.WriteLine("Errors: " + (5 - r) + ", Correctes: " + r);
        }
    }
}
