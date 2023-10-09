using System;
using System.Diagnostics.Metrics;

class exercicio13
{
    static void Main()
    {
        Console.WriteLine("Calculadora de números inteiros");
        Console.WriteLine("_________________________________");

        int[] entrada = new int[10];
        int soma = 0;

        Console.WriteLine("Digite 10 números inteiros:");

        for(int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}° Número: ");
            if (int.TryParse(Console.ReadLine(), out int numeroDigitado))
            {
                entrada[i] = numeroDigitado;
                soma += numeroDigitado;
            }
            else
            {
                Console.WriteLine("Entrada inválida, Digite um número inteiro");
                i--;
            }          
        }
        //comparando o menor número

        int menor = entrada[0];
        for (int i = 1; i < entrada.Length; i++)
        {
            if (entrada[i] < menor)
            {
                menor = entrada[i];
            }
        }
        //resultados 
        Console.Clear();
        Console.WriteLine("Resultados:");
        Console.WriteLine("_________________________________");
        Console.WriteLine($"O menor número digitado é {menor}");
        Console.WriteLine($"A Média dos números digitados é {soma / 10}");
        Console.WriteLine($"A soma dos números digitados é {soma}");
    }
}