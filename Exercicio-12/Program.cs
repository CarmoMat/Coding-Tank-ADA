using System;

class exercicio12
{
    static void Main()
    {
        Console.WriteLine("Calculadora de vetores!");
        Console.WriteLine("__________________________");

        int[] vetorA = new int[10];
        int[] vetorB = new int[10];
        int[] vetorC = new int[10];

        Console.WriteLine("Digite os números do Vetor A!");
        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}° Número: ");
            if (int.TryParse(Console.ReadLine(), out int numeroDigitado))
            {
                vetorA[i] = numeroDigitado;
            }
            else {
                Console.WriteLine("Entrada inválida, Digite um número inteiro"); 
                i--;
            }
        }

        Console.Clear();
        Console.WriteLine("Digite os números do Vetor B!");
        Console.WriteLine("__________________________");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}° Número: ");
            if (int.TryParse(Console.ReadLine(), out int numeroDigitado))
            {
                vetorB[i] = numeroDigitado;
            }
            else
            {
                Console.WriteLine("Entrada inválida, Digite um número inteiro");
                i--;
            }
        }

        Console.Clear();

        for (int i = 0; i < 10; i++)
        {
            vetorC[i] = vetorA[i] + vetorB[i];
        }

        Console.WriteLine("Vetor C (soma dos elementos de A e B):");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(vetorC[i]);
        }


    }
}