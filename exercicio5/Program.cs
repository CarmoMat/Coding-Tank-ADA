using System;
using System.Reflection.PortableExecutable;


    class Desafio5
    {
        static void Main()
        {
            double peso;

            Console.Write("Digite o peso dos peixes (em Kg): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out peso))
            {
                if (peso < 50.0)
                {
                    Console.WriteLine($"A pesca hoje não ultrapassou os valores estabelecidos!");
                    Console.WriteLine($"Total pescado: {peso} Kg | Total de multa R$ 0");
                }
                else
                {
                    double excesso = peso - 50.0;
                    double multa = excesso * 4.0;
                    Console.WriteLine($"A pesca hoje ultrapassou os valores estabelecidos!");
                    Console.WriteLine($"Total ultrapassado: {excesso:F2} Kg | Total de multa R$ {multa:F2}");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar um número válido (use ponto decimal, se necessário).");
            }
        }
    }
