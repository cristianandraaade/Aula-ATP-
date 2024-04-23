using System;
class Program
{
    public static void Main()
    {
        // declarão de variaveis
        int numeroDigitado = 0, numerosPositivos = 0, NumerosNegativos = 0, zeros = 0, total = 0;
        int stop = 1234;
        do
        {
            Console.WriteLine("Digite números inteiro");
            numeroDigitado = int.Parse(Console.ReadLine());
            if (numeroDigitado != stop)
            {
                if (numeroDigitado == 0)
                {
                    zeros++;
                }
                else if (numeroDigitado > 0)
                {
                    numerosPositivos++;
                }
                else
                {
                    NumerosNegativos++;
                }
            }

        } while (numeroDigitado != stop);
        Console.WriteLine("Números positivos: " + numerosPositivos);
        Console.WriteLine("Números negativos: " + NumerosNegativos);
        Console.WriteLine("Zeros: " + zeros);
    }
}