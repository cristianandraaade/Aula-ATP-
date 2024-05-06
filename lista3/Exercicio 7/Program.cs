using System;
class Program
{
    public static void Main()
    {
        // declaração de variaveis
        int numeroDigitado;
        double somaFinal = 0;
        Console.WriteLine("Digite um número inteiro e positivo");
        numeroDigitado = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numeroDigitado; i++)
        {
            somaFinal += 1 / (double)i;
            Console.WriteLine("Resultado parcial após adicionar 1/" + i + ": " + somaFinal);
        }
        Console.WriteLine("Resultado final " + somaFinal);
    }
}