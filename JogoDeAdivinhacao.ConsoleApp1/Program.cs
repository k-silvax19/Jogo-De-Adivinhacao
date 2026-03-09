using System;

using System.Security.Cryptography;

while (true == true)
{
 Console.Clear();

 Console.WriteLine("-----------------------------------");
 Console.WriteLine("Jogo De Adivinhação");
 Console.WriteLine("-----------------------------------");

 int numeroAleatorio = RandomNumberGenerator.GetInt32(1,21);

 Console.Write("Digite Um Numero De 1 - 21: ");
 string? chute = Console.ReadLine();

 int numeroDigitado = Convert.ToInt32(chute);

 if (numeroDigitado == numeroAleatorio)
    {
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Parabens Você Acertou!!");
    Console.WriteLine("-----------------------------------");
    }

 else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(" O número digitado e maior que o número secreto!!");
        Console.WriteLine("-----------------------------------");

    }
 else
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("O número e menor que o número secreto");
        Console.WriteLine("-----------------------------------");
    }
    
    Console.Write("Deseja Continuar s/N ");
    string? opcaoContinuar = Console.ReadLine();
    
    if (opcaoContinuar?.ToUpper() != "S")
    {
        break;
    }

    Console.ReadLine();
}
