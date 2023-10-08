using System;

Console.WriteLine("Bem vindo a Calculadora!");
Console.Write("Digite o primeiro número: ");
string numero1 = Console.ReadLine();
Console.Write("Digite o segundo número: ");
string numero2 = Console.ReadLine();
Console.WriteLine("Qual operação você deseja realizar? ");
Console.WriteLine("1- Adição");
Console.WriteLine("2- Subtração");
Console.WriteLine("3- Multiplicação");
Console.WriteLine("4- Divisão");

int opcao = int.Parse(Console.ReadLine()); 

int num1 = int.Parse(numero1);
int num2 = int.Parse(numero2);

switch (opcao)
{
    case 1:
        Console.WriteLine("Você selecionou a opção 1 - Adição");
        { int adicao = num1 + num2;
        Console.WriteLine($"resultado da adição: {adicao}");
        }
        break;

    case 2:
        Console.WriteLine("Você selecionou a opção 2 - Subtração");
        {
            int subtracao = num1 - num2;
            Console.WriteLine($"resultado da Subtração: {subtracao}");
        }
        break;

    case 3:
        Console.WriteLine("Você selecionou a opção 3 - Multiplicação");
        {
            int multiplicacao = num1 * num2;
            Console.WriteLine($"resultado da Multiplicação: {multiplicacao}");
        }
        break;
    case 4:
        Console.WriteLine("Você selecionou a opção 4 - Divisao");
        {
            int divisao = num1 / num2;
            Console.WriteLine($"resultado da Divisão: {divisao}");
        }
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;

}


