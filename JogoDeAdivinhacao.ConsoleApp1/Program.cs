using System.Security.Cryptography;

while (true == true)
{
    int[] numerosDigitados = new int[100];
    int contadorNumerosDigitados = 0;
    int pontuacao = 1000;

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
            Console.WriteLine("-------------------------------");
            Console.WriteLine("selecione uma dificuldade valida");
            Console.WriteLine("aperte ENTER para continuar...");
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

        bool numeroEstaRepetido = false;

        for (int contadorNumeros = 0; contadorNumeros < contadorNumerosDigitados; contadorNumeros++)
        {
            if (numerosDigitados[contadorNumeros] == numeroDigitado)
            {
                numeroEstaRepetido = true;
                break;
            }
        }
        
        if (numeroEstaRepetido == true)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("voce ja digitou esse numero, tente novamente");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("digite ENTER para continuar...");
            Console.ReadLine();

            tentativa--;

            continue;

        }
         if (contadorNumerosDigitados < numerosDigitados.Length)
        {
            numerosDigitados[contadorNumerosDigitados] = numeroDigitado;

            contadorNumerosDigitados++;
        }

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

        int diferencaNumerica = Math.Abs(numeroAleatorio - numeroDigitado);

        if (diferencaNumerica >= 10)
        {
            pontuacao -= 100;
        }
        else if (diferencaNumerica >= 5)
        {
            pontuacao -= 50;
        }
        else
        {
            pontuacao -= 20;
        }

        Console.WriteLine("Sua pontuação é: " + pontuacao);
        Console.WriteLine("------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();


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

