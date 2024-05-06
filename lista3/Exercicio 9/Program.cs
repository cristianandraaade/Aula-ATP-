using System;

class Program
{
    static void Main()
    {
        int L,soma = 0,termoAnterior = 0,termoAtual = 1, proximoTermo;
        Console.WriteLine("Digite o valor de L:");
        L = int.Parse(Console.ReadLine());
        if (L <= 0)
        {
            Console.WriteLine("insira um valor de L válido");
        }

        while (termoAtual < L)
        {
            soma += termoAtual;
            proximoTermo = termoAnterior + termoAtual;
            termoAnterior = termoAtual;
            termoAtual = proximoTermo;
        }

        Console.WriteLine("A soma dos elementos da sequência de Fibonacci menores que " + L + " é: " + soma);
    }
}
