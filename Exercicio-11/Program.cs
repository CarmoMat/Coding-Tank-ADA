using System;

class exercicio11
{
    static void Main()
    {
        Console.WriteLine("Calculadora de reajustes de sálarios");
        Console.WriteLine("_____________________________________");
        Console.Write("Digite seu sálario atual: R$");
        double salarioAtual = double.Parse(Console.ReadLine());

        double salarioReajuste;
        int diferenca;

        if (salarioAtual <= 280.0)
        {
            Console.WriteLine("_____________________________________");
            salarioReajuste = salarioAtual * 1.20;
            diferenca = (int)salarioReajuste - (int)salarioAtual;
            Console.WriteLine($"Seu sálario antigo era de: R${salarioAtual}");
            Console.WriteLine($"Reajustado com aumento de 20%| Com um aumento de R${diferenca} no seu sálario");
            Console.WriteLine($"Seu novo sálario reajustado é: R${salarioReajuste:F2}");
        }
        else if (salarioAtual <= 700 && salarioAtual > 280)
        {
            Console.WriteLine("_____________________________________");
            salarioReajuste = salarioAtual * 1.15;
            diferenca = (int)salarioReajuste - (int)salarioAtual;
            Console.WriteLine($"Seu sálario antigo era de: R${salarioAtual}");
            Console.WriteLine($"Reajustado com aumento de 15%| Com um aumento de R${diferenca} no seu sálario");
            Console.WriteLine($"Seu novo sálario reajustado é: R${salarioReajuste:F2}");
        }
        else if (salarioAtual <= 1500 && salarioAtual > 700)
        {
            Console.WriteLine("_____________________________________");
            salarioReajuste = salarioAtual * 1.10;
            diferenca =(int)salarioReajuste - (int)salarioAtual;
            Console.WriteLine($"Seu sálario antigo era de: R${salarioAtual}");
            Console.WriteLine($"Reajustado com aumento de 10%| Com um aumento de R${diferenca} no seu sálario");
            Console.WriteLine($"Seu novo sálario reajustado é: R${salarioReajuste:F2}");
        }
        else if (salarioAtual >= 1500)
        {
            Console.WriteLine("_____________________________________");
            salarioReajuste = salarioAtual * 1.05;
            diferenca = (int)salarioReajuste - (int)salarioAtual;
            Console.WriteLine($"Seu sálario antigo era de: R${salarioAtual}");
            Console.WriteLine($"Reajustado com aumento de 5%| Com um aumento de R${diferenca} no seu sálario");
            Console.WriteLine($"Seu novo sálario reajustado é: R${salarioReajuste:F2}");
        }
        else
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Condição incorreta!");
        }
    }
}