using System;

namespace reto_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("ingrese z:");
            double z = double.Parse(Console.ReadLine());
            Console.Write("ingrese y:");
            double y = double.Parse(Console.ReadLine());
            Console.Write("ingrese angulo b:");
            double Ab = double.Parse(Console.ReadLine());

            //convercion a radiales 
            double rab = Ab * (180 / Math.PI);
            //angulos

            double ang1 = Math.Atan(z / y);

            double angC1 = ang1 * 180 / Math.PI;

            double ang2 = 180 - angC1;
            double ang3 = 180 - ang2 - Ab;
            double ra3 = ang3 * Math.PI / 180;

            //hipotenusa

            double laA = Math.Sqrt((z * z) + (y * y));

            //encotrar x
            double x = (Math.Sin(ra3) * (laA / Math.Sin(rab)));

            //salida
            
            Console.WriteLine("la ang1 es: " + angC1);
            Console.WriteLine("la ang2 es: " + ang2);
            Console.WriteLine("la ang3 es: " + ang3);
            Console.WriteLine("la hipo es: " + laA);
            Console.WriteLine("la x es: " + x);

            //https://youtu.be/PWbTtei5SdE
        }
    }
}
