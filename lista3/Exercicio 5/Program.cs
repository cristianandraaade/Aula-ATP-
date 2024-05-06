using System;

class Program
{
    public static void Main()
    {
        // declaração de variaveis
        int numeroPositivo;
        float varE = 0;

        //Entrada de dados
        Console.WriteLine("Digite um número positivo");
        numeroPositivo = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroPositivo; i++)
        {
            int resultadoFatorial = 1;
            for (int fat = i; fat >= 1; fat--)
            {
                resultadoFatorial *= fat;
            }
            varE += ((float)1 / resultadoFatorial);
        }

        Console.WriteLine("o valor de E é: {0:f5} ", varE);
    }
}
