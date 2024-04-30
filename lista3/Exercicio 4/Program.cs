using System;
class Program
{
    public static void Main()
    {
        int numeroDigitado = 0, fatorialNumero = 1;
        Console.WriteLine("Digite um número para o calculo de fatorial");
        numeroDigitado = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numeroDigitado; i++)
        {
            if (numeroDigitado != 0)
            {
                fatorialNumero *= i;
            }
            else
                Console.WriteLine("O fatorial de 0 é 1");
        }
        Console.WriteLine("A fatorial de {0} é: {1}", numeroDigitado, fatorialNumero);
    }
}