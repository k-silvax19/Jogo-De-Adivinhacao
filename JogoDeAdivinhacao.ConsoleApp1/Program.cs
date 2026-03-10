using System;

using System.Security.Cryptography;

while (true == true)
{
 Console.Clear();

 Console.WriteLine("-----------------------------------");
 Console.WriteLine("Jogo De Adivinhação");
 Console.WriteLine("-----------------------------------");
 Console.WriteLine("Selecione Uma Dificuldade: ");
 Console.WriteLine("-----------------------------------");
 Console.WriteLine("1 - Facil");
 Console.WriteLine("2 - Médio");
 Console.WriteLine("3 - Dificil");
 Console.WriteLine("-----------------------------------");

 Console.Write("Digite a dificuldade: ");
 string? dificuldade = Console.ReadLine();

 int numeroMaximo;
 int tentativasMaximas;

 switch (dificuldade)
    {
        case "1":
            numeroMaximo = 20;
            tentativasMaximas = 10;
            break;

        case "2":
        numeroMaximo = 50;
        tentativasMaximas = 5;
        break;

        case "3":
        numeroMaximo = 100;
        tentativasMaximas = 3;
        break;

        default:
            numeroMaximo = 20;
            tentativasMaximas = 10;
            break;
    }
 
 int numeroAleatorio = RandomNumberGenerator.GetInt32(1, numeroMaximo + 1);

 for (int tentativa = 1; tentativa <= tentativasMaximas; tentativa++ )
    {
        Console.Clear();
        Console.WriteLine("------------------------------------");
        Console.WriteLine($"Tentativa {tentativa} de {tentativasMaximas}.");
        Console.WriteLine("------------------------------------");

        Console.Write($"Digite um número entre 1 e {numeroMaximo}: ");
        string? chute = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(chute);

        if (numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Parabéns, você acertou!");
            Console.WriteLine("------------------------------------");

            break;
        }
        else if (numeroDigitado > numeroAleatorio)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("O número digitado foi maior que o número secreto!");
            Console.WriteLine("------------------------------------");
        }
        else
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("O número digitado foi menor que o número secreto!");
            Console.WriteLine("------------------------------------");
        }

        if (tentativa == tentativasMaximas)
        {
            Console.WriteLine($"Você usou todas as suas tentativas! O número era {numeroAleatorio}.");
            Console.WriteLine("------------------------------------");
            break;
        }
    }
    
    Console.ReadLine();

    Console.Write("Deseja Continuar s/N ");
    string? opcaoContinuar = Console.ReadLine();
    
    if (opcaoContinuar?.ToUpper() != "S")
    {
        break;
    }
}

