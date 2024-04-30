using System;
class Program
{
    public static void Main()
    {
        // declarão de variaveis
        int numeroDigitado = 0, numerosPositivos = 0, numerosNegativos = 0, zeros = 0, total = 0;
        float percentPositivos=0,percentNegativos=0,percentZeros=0;
        int stop = 1234;
        //entrada de dados e processamento
        // entra numeros e valida seu tipo
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
                    numerosNegativos++;
                }
                total++;
            }

        } while (numeroDigitado != stop);
        //calcula a porcentagem dos tipos de numeros baseados no total
        
        percentZeros=(float)(total/zeros)*10;
        percentPositivos=(float)(total/numerosPositivos)*10;
        percentNegativos=(float)(total/numerosNegativos)*10;
        //saida de dados
        Console.WriteLine("Números positivos: " + numerosPositivos);
        Console.WriteLine("Números negativos: " + numerosNegativos);
        Console.WriteLine("Zeros: " + zeros);
        Console.WriteLine("total " + total);
        Console.WriteLine("Porcentagem de zeros " + percentZeros + "%");
        Console.WriteLine("Porcentagem de Positivos " + percentPositivos + "%");
        Console.WriteLine("Porcentagem de Negativos " + percentNegativos + "%");
    }
}