using System;
class exercicio6
{
    static void Main()
    {

Console.Write("Digite a idade do Nadador: ");
int age = int.Parse(Console.ReadLine());

while (age < 5)
{
    Console.WriteLine("Idade mínima é 5!");
    Console.Write("Digite a idade do Nadador: ");
    age = int.Parse(Console.ReadLine());
}

if (age <= 7)
{
    Console.WriteLine("Sua categoria é Infantil A!");
}
else if (age <= 11)
{
    Console.WriteLine("Sua categoria é Infantil B!");
}
else if (age <= 13)
{
    Console.WriteLine("Sua categoria é Juvenil A!");
}
else if (age <= 17)
{
    Console.WriteLine("Sua categoria é Juvenil B!");
}
else
{
    Console.WriteLine("Sua categoria é Adultos!");
}
}
}