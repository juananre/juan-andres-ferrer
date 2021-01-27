using System;

namespace ejercicio_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            Console.Write("Ingrese Z: ");
            double z = double.Parse(Console.ReadLine());

            Console.Write("angulo c: ");
            double cg = double.Parse(Console.ReadLine());


            //angulo a
            double aG = 180 - 90 - cg;

            //cambio
            double cR = cg * Math.PI / 180;


            //hipotenusa (t)
            double t = z / Math.Sin(cR);

            //lado y 

            double y = z / Math.Tan(cR);

            //salida 
            Console.WriteLine("angulo a"+ aG);

            Console.WriteLine("hipotenisa" + t);

            Console.WriteLine("lado y" + y);

            //https://youtube.com/video/gpV63EJlocM
        }
    }
}
