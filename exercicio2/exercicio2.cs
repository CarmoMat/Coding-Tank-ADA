using System;

Console.WriteLine("Bem vindo a calculadora de idade!");
Console.Write("Digite o ano atual: ");
string anoAtual = Console.ReadLine();
int ano1 = int.Parse(anoAtual);
Console.Write("Digite o ano do seu nascimento: ");
string anoNasc = Console.ReadLine();    
int ano2 = int.Parse(anoNasc);

int soma = ano1 - ano2;

Console.WriteLine($"A sua idade é {soma}");
