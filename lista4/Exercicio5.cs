using System;
public class Exercicio5
{
    public void Run()
    {
        int numeroUm, numeroDois;

        Console.WriteLine("Digite dois números");
        numeroUm = int.Parse(Console.ReadLine());
        numeroDois = int.Parse(Console.ReadLine());
        if ((numeroUm > 0) && (numeroDois > 0))
        {
            int mdc = CalcularMDC(numeroUm, numeroDois);
            Console.WriteLine("O MDC entre {0} e {1} é: {2}", numeroUm,numeroDois,mdc);
        }
        else
        {
            Console.WriteLine("Numero invalidos");
        }
        
    }
    static int CalcularMDC(int numeroUm, int numeroDois)
    {
        while (numeroDois != 0)
        {
            int aux = numeroDois;
            numeroDois = numeroUm % numeroDois;
            numeroUm = aux;
        }

        return numeroUm;    
    }
}