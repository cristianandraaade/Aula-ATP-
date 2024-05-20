using System;
public class Exercicio3
{
    public void Run()
    {
        int numeroUm, numeroDois, numeroTres, conjuntosNumeros;

        Console.WriteLine("Digite a quantidade de conjuntos de 3 números");
        conjuntosNumeros = int.Parse(Console.ReadLine());

        for (int i = 1; i <= conjuntosNumeros; i++)
        {
            Console.WriteLine("Digite 3 valosres");
            numeroUm = int.Parse(Console.ReadLine());
            numeroDois = int.Parse(Console.ReadLine());
            numeroTres = int.Parse(Console.ReadLine());
            MaiorNumero(numeroUm,numeroDois,numeroTres);
        }
        static void MaiorNumero(int a, int b, int c){
              int menor, meio, maior;

        if (a <= b && a <= c)
        {
            menor = a;
            if (b <= c)
            {
                meio = b;
                maior = c;
            }
            else
            {
                meio = c;
                maior = b;
            }
        }
        else if (b <= a && b <= c)
        {
            menor = b;
            if (a <= c)
            {
                meio = a;
                maior = c;
            }
            else
            {
                meio = c;
                maior = a;
            }
        }
        else
        {
            menor = c;
            if (a <= b)
            {
                meio = a;
                maior = b;
            }
            else
            {
                meio = b;
                maior = a;
            }
        }

        Console.WriteLine($"Os números em ordem crescente são:" + menor + meio + maior);
        }
    }
}