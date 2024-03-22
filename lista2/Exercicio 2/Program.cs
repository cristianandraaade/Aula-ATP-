using System;
class Program
{
    public static void Main()
    {
        //declaração de variaveis
        int numeroA,numeroB,resultadoAdicao;
        //Entrada de dados
        Console.WriteLine("Digite dois número");
        numeroA = int.Parse(Console.ReadLine());
        numeroB = int.Parse(Console.ReadLine());
        //Processamento e saida de dados
        resultadoAdicao = numeroA + numeroB;
        if (resultadoAdicao >= 10)
        {
            int condicao1 = (resultadoAdicao + 5);
            Console.WriteLine("O valor é " + condicao1);
        }
        else
        {
            int condicao2 = (resultadoAdicao + 7);
            Console.WriteLine("O valor é " + condicao2);
        }
    }
}