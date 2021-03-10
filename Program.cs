using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cracking_the_coding_intvw_oop
{
    class Program
    {
        static void Main(string[] args)
        {
          
            bool repeta = true;
            do
            {


                try
                {
                    Console.WriteLine("choose operation");
                    Console.WriteLine("1 -> +");
                    Console.WriteLine("2 -> -");
                    Console.WriteLine("3 -> *");
                    Console.WriteLine("4 -> /");
                    Console.WriteLine("5 -> sqrt");
                    Console.WriteLine("6 -> ^");
                    int x = int.Parse(Console.ReadLine());

                    if (x == 1)
                    {
                        Console.WriteLine("no1");
                        int no1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("no2");
                        int no2 = int.Parse(Console.ReadLine());
                        int sum = no1 + no2;
                        Console.Beep();
                        Console.WriteLine("suma dintre {0} si {1} e {2}", no1, no2, sum);
                    }

                    else if (x == 2)
                    {
                        
                        Console.WriteLine("no1");
                        int no1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("no2");
                        int no2 = int.Parse(Console.ReadLine());
                        int dif = no1 - no2;
                        Console.Beep();                      
                       Console.WriteLine("diferenta dintre {0} si {1} e {2}", no1, no2, dif);
                    }
                    else if (x == 3)
                    {
                        Console.WriteLine("no1");
                        int no1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("no2");
                        int no2 = int.Parse(Console.ReadLine());
                        int ori = no1 * no2;
                        Console.Beep();
                        Console.WriteLine("  {0} * {1} e {2}", no1, no2, ori);
                    }
                    else if (x == 4)
                    {
                        Console.WriteLine("no1");
                        double no1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("no2");
                        double no2 = int.Parse(Console.ReadLine());
                        double supra = no1 / no2;
                        Console.Beep();
                        Console.WriteLine(" {0} / {1} e {2}", no1, no2, supra);
                    }
                    else if (x == 5)
                    {
                        Console.WriteLine("no1");
                        double no1 = double.Parse(Console.ReadLine());
                        double radical = Math.Sqrt(no1);
                        Console.Beep();
                        Console.WriteLine("radical din {0} e {1} ", no1, radical);
                    }
                    else if (x == 6)
                    {
                        Console.WriteLine("no1");
                        double no1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("no2");
                        double no2 = double.Parse(Console.ReadLine());
                        double putere = Math.Pow(no1, no2);
                        Console.Beep();
                        Console.WriteLine(" {0} ^ {1} e {2}", no1, no2, putere);
                    }
                    else
                    {
                        Console.WriteLine("introdu una din operatiile date");
                    }
                    Console.WriteLine("doriti sa continuati? y/n");
                    string optiune = Console.ReadLine();
                    Console.Beep();
                    if (optiune.ToLower() == "y")
                    {
                        repeta = true;
                    }
                    else if (optiune.ToLower() == "n")
                    {
                        repeta = false;
                        Console.WriteLine("Apasa orice tasta pentru a iesi");
                    }
                    else
                    {
                        Console.Beep();
                        Console.WriteLine("Optiunile disponibile sunt y sau n. apasa orice tasta pentru a iesi");
                        repeta = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("introdu una din operatiile date");
                }

            }
            while (repeta);

            

            Console.ReadKey();
        }

      
    }

}

