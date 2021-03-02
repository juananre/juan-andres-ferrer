using System;

namespace reto_1_3_semana_6__dado_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/FaJhjsYRE1g

            Random random = new Random();
            
            int dado1 = 0;
            int dado2 = 0;
            int vidas = 3;
            int puntos = 0;
            int dadoE = 2;
            int turno = 0;
            int conta1 = 0;
            int dadoAnterior = 0;
            int dadoActual = 0; ;

            while (1 <= vidas && vidas <= 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("vida: " + vidas);
                Console.WriteLine("quiere continuar jugando (s/n)");
                string verificar = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;




                while (verificar != "s" && verificar != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada no valida");
                    verificar = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (verificar == "s")
                {
                    


                    if (dadoE <= 2 && verificar == "s")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("quiere usar el dado de 12 (s/n): ");
                        string comparador = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        if (comparador == "s" && dadoE != 0)
                        {
                            
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            dado2 = random.Next(1, 13);
                            dadoActual = dado2;
                            puntos += dado2;
                            turno++;
                            dadoE--;
                            Console.WriteLine("uso el dado especial y te queda : " + dadoE  + " usos ");
                            Console.WriteLine("usted seco el dado: " + dado2);
                            Console.WriteLine("usted tiene estos puntos: " + puntos);
                            Console.WriteLine("dado anterior: " + dadoAnterior);
                            
                            Console.ForegroundColor = ConsoleColor.White;


                        }
                        if (comparador == "s" && dadoE == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ya no tienes mas dados");
                            Console.WriteLine("usted tiene estos puntos: " + puntos);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (verificar == "s" && comparador == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            dado1 = random.Next(1, 7);
                            dadoActual = dado1;
                            puntos += dado1;
                            Console.WriteLine("dado especial, te queda : " + dadoE  + " usos ");
                            Console.WriteLine("usted saco el dado: " + dado1);
                            Console.WriteLine("usted tiene estos puntos: " + puntos);
                            Console.WriteLine("dado anterior: " + dadoAnterior);
                            turno++;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (verificar != "s" && verificar != "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Entrada no valida");
                            verificar = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }

                    if (dado1 == 1 || dado2 == 1)
                    {
                        conta1++;
                    }

                    if (conta1 == 2)
                    {
                        Console.WriteLine("has perdido 1 vida y 10 puntos");
                        vidas--;
                        puntos = puntos - 10;
                        conta1 = 0;
                    }
                    if (dadoActual == 6 && dadoAnterior == 6)
                    {
                        vidas++;
                        if (vidas > 3)
                        {
                            vidas--;
                        }
                    }


                    //gane 
                    if (puntos >= 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("bien, ganeee!!!!!!!");

                        break;
                    }


                    dadoAnterior = dadoActual;
                }
                if (verificar == "n")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("hasta luego, te falto: " + (100 - puntos) + " puntos ");

                    break;
                }

            }
            //pierde
            if(vidas< 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("perdiste fantasma alcaguete ");

            }
        }
    }
}
