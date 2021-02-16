using System;

namespace reto_1_3_semana_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double total = 0;
            Console.Write("ingrese el numero de datos(n):  ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 0;
            string nombreMenor = "", nombreMayor = "";

            while (i < n)
            { 
                Console.Write("edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("nombre: ");
                string nombre = Console.ReadLine();

                
                if (i == 0)
                {
                    max = edad;
                    min = edad;
                }
                if (edad > max)
                {
                    max = edad;
                    nombreMayor = nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    nombreMenor = nombre;
                }
                total += edad;
                i++;
            }
            double promedio = total / n;
            Console.WriteLine("promedio: " + promedio);
            Console.WriteLine("mayor: " + nombreMayor + "de edad: " + max);
            Console.WriteLine("menor: " + nombreMenor + "de edad: " + min);

            //https://youtu.be/rJLsT9TZEAA
        }
    }
}
