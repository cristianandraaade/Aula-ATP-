using System;
class Program
{
    public static void Main()
    {

        //declaração de variaveis
        int numeroA, numeroB;
        //Entrada de dados
        Console.WriteLine("Digite dois números");
        numeroA = int.Parse(Console.ReadLine());
        numeroB = int.Parse(Console.ReadLine());
        //Processamento e saida de dados
        if (numeroA > numeroB)
        {
            Console.WriteLine("O maior número é " + numeroA);
        }
        else
        {
            Console.WriteLine("O maior número é " + numeroB);
        }
    }
}
