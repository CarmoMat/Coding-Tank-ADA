using System;

Console.WriteLine("Bem vindo a calculadora de gorjeta!");
Console.Write("Insira o valor total da sua conta: ");
string conta = Console.ReadLine();
Console.Write("Insira a porcentagem de gorjeta desejada: (por exemplo 15% ou 20%) ");
string gorjeta = Console.ReadLine();

gorjeta = gorjeta.Replace("%", "");
//função pra retirar o símbolo de porcentagem

int contaTotal = int.Parse(conta);
int gorjetaTotal = int.Parse(gorjeta);


int soma = (contaTotal * gorjetaTotal) / 100;

Console.WriteLine($"O total da conta é R${conta} e o valor da gorjeta é R${soma}  ");