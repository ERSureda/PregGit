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
            char rpreg;
            int r = 0;
            //Tema de Matematiques
            //5 Preguntes Diferents
            Console.Clear();
            Console.WriteLine("MATEMATIQUES");

            Console.WriteLine("\t\t\t   1- La Suma 1+1 dona com a resultat?");
            Console.WriteLine("1. Resultat = 25");
            Console.WriteLine("2. Resultat = 52");
            Console.WriteLine("3. Resultat = 5");
            Console.WriteLine("4. Resultat = 2");

            Console.WriteLine("Introdueix el valor: ");
            rpreg = Convert.ToChar(Console.ReadKey().KeyChar);  //Preginta Solució

            switch (rpreg)      //Switch
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


            Console.WriteLine("\t\t\t   2- La Suma 11*5 dona com a resultat?");
            Console.WriteLine("1. Resultat = 25");
            Console.WriteLine("2. Resultat = 52");
            Console.WriteLine("3. Resultat = 55");
            Console.WriteLine("4. Resultat = 21");

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

            Console.WriteLine("\t\t\t   3- La Suma 3/1 dona com a resultat?");
            Console.WriteLine("1. Resultat = 232");
            Console.WriteLine("2. Resultat = 12");
            Console.WriteLine("3. Resultat = 2");
            Console.WriteLine("4. Resultat = 3");

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

            Console.WriteLine("\t\t\t   4- La Suma 250*4 dona com a resultat?");
            Console.WriteLine("1. Resultat = 225");
            Console.WriteLine("2. Resultat = 1000");
            Console.WriteLine("3. Resultat = 500");
            Console.WriteLine("4. Resultat = 212");

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

            Console.WriteLine("\t\t\t   5- La Suma 33/3 dona com a resultat?");
            Console.WriteLine("1. Resultat = 25");
            Console.WriteLine("2. Resultat = 2");
            Console.WriteLine("3. Resultat = 23");
            Console.WriteLine("4. Resultat = 11");

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
            //Contador per saber cuantes estan malament y de correctes
            Console.WriteLine("Errors: " + (5 - r) + ", Correctes: " + r);    //Marcador
        }

        static void Tema2()
        {

        }

        static void Tema3()
        {

        }
    }
}
