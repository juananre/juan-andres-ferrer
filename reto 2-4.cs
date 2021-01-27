using System;

namespace reto_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ingreso de datos 

            Console.Write("angulo d:");
            double Ad = double.Parse(Console.ReadLine());
            Console.Write("ingrese y:");
            double y = double.Parse(Console.ReadLine());
            Console.Write("ingrese angulo b:");
            double Ab = double.Parse(Console.ReadLine());

            //calculos 

            double e = 180 - Ad - Ab;
            double c = 180 - e;

            //rempalzo 

            double rc = c * Math.PI / 180;

            //lado z

            double tanz = Math.Tan(rc);
            double z = tanz * y;
            

            //salida de datos 

            Console.WriteLine("la angulo e es: " + e);
            Console.WriteLine("la angulo c es: " + c);
            Console.WriteLine("la lado z es: " + z );

            //https://youtu.be/NmHqiY_Ni9o
        }
    }
}
