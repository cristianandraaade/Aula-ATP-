using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o número de termos da sequência de Fibonacci que você deseja calcular:");
        int numeroDeTermos = int.Parse(Console.ReadLine());
        if(numeroDeTermos <= 0)
        {
            Console.WriteLine("insira um número de termos válido");
        }
        Console.WriteLine("Sequência de Fibonacci:");
        int termoAnterior = 0;
        int termoAtual = 1;
        Console.Write(termoAnterior + " " + termoAtual + " ");

        for(int i = 2; i < numeroDeTermos; i++)
        {
            int proximoTermo = termoAnterior + termoAtual;
            Console.Write(proximoTermo + " ");
            termoAnterior = termoAtual;
            termoAtual = proximoTermo;
        }
    }
}
