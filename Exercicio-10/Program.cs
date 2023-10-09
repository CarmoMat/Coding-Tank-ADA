using System;
using System.Runtime.InteropServices;

class exercicio10
{
    static void Main()
    {
        Console.WriteLine("Comparador de palíndromos");
        Console.WriteLine("__________________________");
        Console.WriteLine("\r\nCuriosidade: Palavras palíndromos são aquelas que são lidas da direita para a esquerda da mesma\r\nmaneira que da esquerda para a direita.");
        Console.WriteLine("__________________________");
        Console.Write("Digite a palavra a ser comparada: ");
        string textoOriginal = Console.ReadLine();

        string textoMinusculo = textoOriginal.ToLower();
        int cumprimento = textoMinusculo.Length;
        string textoReverso = new string(textoMinusculo.Reverse().ToArray());
       
        if(textoMinusculo == textoReverso)
        {
            Console.WriteLine("__________________________");
            Console.WriteLine($"A palavra {textoOriginal} é um Palíndromo!");
        }
        else
        {
            Console.WriteLine("__________________________");
            Console.WriteLine($"A palavra {textoOriginal} não é um Palíndromo!");
        }
    }
}