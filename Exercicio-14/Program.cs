using System;

class exercicio14
{
    static void Main()
    {
        Console.WriteLine("Soma dos números de 1 a 100!");

        int soma = 0;

        for (int i = 1; i <= 100; i++)
        {
            soma += i;
        }
        Console.WriteLine("________________________________________");
        Console.WriteLine($"A soma dos números de 1 a 100 é: {soma}");
     }
        
 }
