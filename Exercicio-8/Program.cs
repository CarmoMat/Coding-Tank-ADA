using System;
using System.ComponentModel.Design;

class exercicio8
{
    static void Main()
    {
        Console.WriteLine("Calculadora de notas");
        Console.WriteLine("______________________");
        Console.WriteLine("Digite a nota das provas:");
        Console.Write("Prova 1: ");
        double prova1 = double.Parse(Console.ReadLine());
        Console.Write("Prova 2: ");
        double prova2 = double.Parse(Console.ReadLine());
        Console.Write("Prova 3: ");
        double prova3 = double.Parse(Console.ReadLine());

        double media = (prova1 + prova2 + prova3) / 3;
        double notaNecessaria = 10 - media;

        if (media >= 7)
        {
            Console.Clear();
            Console.WriteLine("______________________");
            Console.WriteLine("Parabéns! Você foi aprovado!");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("______________________");
            Console.WriteLine("Você ficou de exame!");
            Console.WriteLine($"Você precisa tirar nota {notaNecessaria} para poder passar de ano!");
            
        }

        Console.WriteLine("______________________");
        Console.Write("Digite a nota do exame: ");
        double exame = double.Parse(Console.ReadLine());
        double final = (media + exame) / 2;

        if (exame >= 5) {
            Console.WriteLine("Parabéns! Você passou de ano!");
        }
        else
        {
            Console.WriteLine("Você repetiu de ano!!");
        }

    }
}