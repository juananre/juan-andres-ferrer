using System;

namespace reto_1_1_semana_8_detectar_letras_
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/zhFcGIpNNyQ

            string frase = "";

            string palabra = "";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("ingrese la frase que quiera:  " );
            Console.ForegroundColor = ConsoleColor.White;

            frase = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("ingrese la palabra que buscas:  ");

            Console.ForegroundColor = ConsoleColor.White;
            palabra = Console.ReadLine().ToUpper();
           

            string[] palabras2 = frase.Split(" ");

            int contador = 0;
            for (int i = 0; i < palabras2.Length; i++)
            {
                if (palabras2[i] == palabra)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("encontro la palabra: " + palabras2[i] + " en la posicion: " + (i + 1));
                    Console.ForegroundColor = ConsoleColor.White;
                    contador++;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("repetida: "+ contador + " veces ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
