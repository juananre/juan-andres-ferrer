using System;

namespace reto_1_3_semana_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // entrada 
            Console.Write("Ingrese su salario: ");
            int salario = int.Parse(Console.ReadLine());
            int smmls = 908526;

            if (salario < smmls*2 )
            {
                Console.Write("su tarifa es a ");
            }
            else if ( smmls*2 <= salario && salario < smmls*4)
            {
                Console.Write("su tarifa es b ");
            }
            if (salario >= smmls *4)
            {
                Console.Write("su tarifa es c ");
            }

            //https://youtu.be/4ufSuaiGC1E
        }
    }
}
