using System;

namespace reto_2_3_semana_6__dado_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dado1 = 0;
            int dado2 = 0;
            int turnos1 = 0;
            int vidas = 3;
            int total = 0;

            while (1 <= vidas && vidas <= 3)
            {
                //https://youtu.be/Ut1_q5ObrCM

                Console.WriteLine("Desea volver a tirar? (s/n)");
                string comparador = Console.ReadLine();
                turnos1++;
                while (comparador != "n" && comparador !="s")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada no valida");
                    Console.WriteLine("Desea volver a tirar? (s/n)");
                    comparador = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (comparador == "s")
                {

                    
                    Console.ForegroundColor = ConsoleColor.Blue;
                    dado1 = random.Next(1, 7);
                    Console.WriteLine("El valor de su dado es:" + dado1);
                    total += dado1;
                    Console.WriteLine("los puntos son: " + total);
                    Console.WriteLine("los turnos: " + turnos1);
                    Console.ForegroundColor = ConsoleColor.White;

                    if (turnos1 % 2 == 0)
                    {
                        vidas--;
                        
                    }

                    Console.WriteLine("su vida es: " + vidas);

                    if (turnos1 %3 ==0)
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        dado2 = random.Next(1, 7);
                        Console.WriteLine("El valor de su dado (2) es:" + dado2);
                        total += dado2;
                        Console.WriteLine("los puntos son: " + total);
                        
                        turnos1 = 0;
                        Console.ForegroundColor = ConsoleColor.White;
                        if (dado1 == dado2)
                        {
                            vidas++;
                        }

                    }
                    
                }
                if (comparador == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("muchas gracias por participar bb :3");
                    Console.WriteLine("te falto: " + (100-total) + " para ganar ");
                    break;
                }
                if (total >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("has ganado vijo sabroso");
                    break;
                }
            }
            if (vidas == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("lo siento perdiste");
            }
        }
    }
}
