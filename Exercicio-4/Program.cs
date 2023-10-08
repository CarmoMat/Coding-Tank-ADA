using System;

Console.WriteLine("Bem vindo ao conversor de moedas!");
Console.Write("Digite o valor em Reais ");
string real = Console.ReadLine();
Console.WriteLine("Digite para qual moeda deseja converter: ");
Console.WriteLine("1 - Dólar ");
Console.WriteLine("2 - Euro ");
string opcaoStrg = Console.ReadLine();

int num1 = int.Parse(real);
int opcao = int.Parse(opcaoStrg);

switch (opcao)
{
    case 1:
        Console.WriteLine("Você selecionou a opção 1 - Dólar ");
        { 
            double somaDolar = num1 * 5.50;
            Console.WriteLine($"A opção em Dólar é USD {somaDolar}");
         }
        break;
    case 2:
        Console.WriteLine("Você selecionou a opção 2 - Euro ");
        {
            double somaEuro = num1 * 6.50;
            Console.WriteLine($"A opção em Euro é EUR {somaEuro}");
        }
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;



}

