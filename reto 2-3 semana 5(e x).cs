using System;

namespace reto_2_3_semana_5_e_x_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese x: ");

            double x = double.Parse(Console.ReadLine()); ;
            double euler = 0;
            int n = 100;


            for (int i = 0; i <= n; i++)
            {
                euler += (Math.Pow(x, i) / Factorial(i));
                Console.WriteLine("Euler es : " + euler);
            }
            


        }
        static double Factorial(double valor)
        {
            double total = 1;
            for (int cont = 1; cont <= valor; cont++)
            {
                total *= cont;
            }
            return total;
        }
    }

    //https://youtu.be/Ml788vYWenA
}
