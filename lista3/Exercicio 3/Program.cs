using System;
class Program
{
    public static void Main()
    {
        int numeroDigitado = 0, numerosDivisiveis3e9 = 0, numerosDivisiveis2e5 = 0;
        Console.WriteLine("Insira 10 números");
        for (int i = 1; i <= 10; i++)
        {
            numeroDigitado = int.Parse(Console.ReadLine());
            if ((numeroDigitado % 2 == 0) && (numeroDigitado % 5 == 0))
            {
                numerosDivisiveis2e5++;
                Console.WriteLine(numeroDigitado + " é divisível por 2 e 5.");
            }
            else if ((numeroDigitado % 3 == 0)&& (numeroDigitado % 9 == 0))
            {
                numerosDivisiveis3e9++;
                Console.WriteLine(numeroDigitado + " é divisível por 3 e 9.");
            }
                else
            {
                Console.WriteLine(numeroDigitado + "não é divisivel pelos valores");
            }
        }
        Console.WriteLine("Quantidade de números divisíveis por 3 e 9: " + numerosDivisiveis3e9);
        Console.WriteLine("Quantidade de números divisíveis por 2 e 5: " + numerosDivisiveis2e5);
    }
}