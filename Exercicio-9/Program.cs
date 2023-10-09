using System;

class exercicio9
{
    static void Main()
    {
        Console.WriteLine("Bem vindo ao sistemas de cursos!");
        Console.WriteLine("_________________________________");
        Console.WriteLine("Escolha o curso desejado: ");
        Console.WriteLine("1- Fundamentos do C#");
        Console.WriteLine("2- Html,css, javascript");
        Console.WriteLine("3- Banco de dados");
        Console.WriteLine("4- Git e github");
        Console.WriteLine("5- Java");
        Console.WriteLine("_________________________________");
        Console.Write("Digite o número do curso desejado: ");
        int opcao = int.Parse(Console.ReadLine());

        while (opcao > 5)
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("Digite somente o número do curso desejado!");
            Console.Write("Digite o número do curso desejado: ");
            opcao = int.Parse(Console.ReadLine());
        }

        switch (opcao)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Você foi matriculado com sucesso!");
                Console.WriteLine("_________________________________");
                Console.WriteLine("Dados do acesso:");
                Console.WriteLine("Curso: Fundamentos do C# |Turma: #0001| Inicio:25/12/2023 ás 19hrs");
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Você foi matriculado com sucesso!");
                Console.WriteLine("_________________________________");
                Console.WriteLine("Dados do acesso:");
                Console.WriteLine("Curso: Html,css,javascript |Turma: #0002| Inicio:25/12/2023 ás 19hrs");
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Você foi matriculado com sucesso!");
                Console.WriteLine("_________________________________");
                Console.WriteLine("Dados do acesso:");
                Console.WriteLine("Curso: Banco de dados |Turma: #0003| Inicio:25/12/2023 ás 19hrs");
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Você foi matriculado com sucesso!");
                Console.WriteLine("_________________________________");
                Console.WriteLine("Dados do acesso:");
                Console.WriteLine("Curso: Git e Github |Turma: #0004| Inicio:25/12/2023 ás 19hrs");
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Você foi matriculado com sucesso!");
                Console.WriteLine("_________________________________");
                Console.WriteLine("Dados do acesso:");
                Console.WriteLine("Curso: Java |Turma: #0005| Inicio:25/12/2023 ás 19hrs");
                break;
        }
    }
}