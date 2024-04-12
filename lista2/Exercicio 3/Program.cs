using System;
class Program
{
    public static void Main()
    {
        // Declaração de variaveis
        int x,a,b;
        // Entrada de dados
        Console.WriteLine("Digite o valor de A e B");
        a=int.Parse(Console.ReadLine());
        b=int.Parse(Console.ReadLine());
        if (a >0)
        {
        // Processamento de dados
        x= -b/a;
        // Saida de dados
        Console.WriteLine("A raiz de x é " + x);
        }
        else{
            Console.WriteLine("x não possui raíz");
        }
    }
}