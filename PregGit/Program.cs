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
            char rpreg;
            int r = 0;

            Console.Clear();
            Console.WriteLine("\n\t\t_______________________ REDSOCK _______________________\n");
            //Preguntes de RedSock
            //5 Pregunte
            Console.WriteLine("\t\t\t   1- Quin any es va fundar RedSock?");
            Console.WriteLine("1. 2013");
            Console.WriteLine("2. 1972");
            Console.WriteLine("3. 2019");
            Console.WriteLine("4. 2020");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);  //Preginta Solució

            switch (rpreg)  //Switch
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


            Console.WriteLine("\t\t\t   2- Qui es el principal fundador?");
            Console.WriteLine("1. Eduard Ribas");
            Console.WriteLine("2. Cristian Reyes");
            Console.WriteLine("3. Biel Auguet");
            Console.WriteLine("4. Pedro Sar");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);  //Preginta Solució

            switch (rpreg)  //Switch
            {
                case '1':
                    r++;
                    break;
                case '2':
                    r = r;
                    break;
                case '3':
                    r = r;
                    break;
                case '4':
                    r = r;
                    break;
            }

            Console.WriteLine("\t\t\t   3- Donde se fundo RedSock?");
            Console.WriteLine("1. Madrid");
            Console.WriteLine("2. Andorra");
            Console.WriteLine("3. Playa de Aro");
            Console.WriteLine("4. Girona");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);  //Preginta Solució

            switch (rpreg)  //Switch
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

            Console.WriteLine("\t\t\t   4- Presuspost Inicial?");
            Console.WriteLine("1. 225€");
            Console.WriteLine("2. 110€");
            Console.WriteLine("3. 500€");
            Console.WriteLine("4. 1212€");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);  //Preginta Solució

            switch (rpreg)  //Switch
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

            Console.WriteLine("\t\t\t   5- En quin any sera la sortida de Glore?");
            Console.WriteLine("1. 2022");
            Console.WriteLine("2. 2021");
            Console.WriteLine("3. 2023");
            Console.WriteLine("4. 2050");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);  //Preginta Solució

            switch (rpreg)  //Switch
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
            Console.WriteLine("\t\t______________________________________________________________\n");
            //Contador per saber cuantes estan malament y de correctes
            Console.WriteLine("Errors: " + (5 - r) + ", Correctes: " + r);  //Marcador de soluciones
        }

        static void Tema3()
        {

        }
    }
}
