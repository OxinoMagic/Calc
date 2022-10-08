using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculatrice();

            void Calculatrice()
            {
                // ask for digit to calcul
                Console.WriteLine("Write the first digit of your calcul:");
                int firstDigit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write the second digit of your calcul:");
                int secondDigit = Convert.ToInt32(Console.ReadLine());

                //ask for calcul operator
                Console.WriteLine("Is your calcul a multiplication ? (y/n)");
                char mult = Convert.ToChar(Console.ReadLine());
                if (mult == 'y')
                {
                    Console.WriteLine("The result of your calcul is: " + firstDigit * secondDigit);
                    Console.WriteLine("if you want to do another calcul type y otherwise it will close itself");
                    char restart = Convert.ToChar(Console.ReadLine());
                    if (restart == 'y')
                    {
                        Calculatrice();
                    }
                }
                else if (mult == 'n')
                {
                    Console.WriteLine("Is your calcul an addition ? (y/n)");
                    char addi = Convert.ToChar(Console.ReadLine());
                    if (addi == 'y')
                    {
                        Console.WriteLine("The result of your calcul is: " + (firstDigit + secondDigit));
                        Console.WriteLine("if you want to do another calcul type y otherwise it will close itself");
                        char restart = Convert.ToChar(Console.ReadLine());
                        if (restart == 'y')
                        {
                            Calculatrice();
                        }
                    }
                    else if (addi == 'n')
                    {
                        Console.WriteLine("Is your calcul a substraction ? (y/n)");
                        char sub = Convert.ToChar(Console.ReadLine());
                        if (sub == 'y')
                        {
                            Console.WriteLine("The result of your calcul is: " + (firstDigit - secondDigit));
                            Console.WriteLine("if you want to do another calcul type y otherwise it will close itself");
                            char restart = Convert.ToChar(Console.ReadLine());
                            if (restart == 'y')
                            {
                                Calculatrice();
                            }
                        }
                        else if (sub == 'n')
                        {
                            Console.WriteLine("Is your calcul a division ? (y/n)");
                            char div = Convert.ToChar(Console.ReadLine());
                            if (div == 'y')
                            {
                                Console.WriteLine("The result of your calcul is: " + firstDigit / secondDigit);
                                Console.WriteLine("if you want to do another calcul type y otherwise it will close itself");
                                char restart = Convert.ToChar(Console.ReadLine());
                                if (restart == 'y')
                                {
                                    Calculatrice();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
