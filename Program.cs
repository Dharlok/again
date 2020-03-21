using System;

namespace thursday_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Type a number:");
                int n = int.Parse(Console.ReadLine());
                double chislo = 1.1;
                double chislo2 = 1.2;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 1)
                    {
                        chislo -= chislo2; 
                    }
                    else if (i % 2 == 0)
                    {
                        chislo += chislo2;
                    }
                    chislo2 += 0.1;
                }
                Console.WriteLine("Answer= " + chislo);
                Console.ReadKey();
            }
        }
    }
}  
    

