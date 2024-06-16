using System;
class Exercicio3
{
    public void Run()
    {
        int[] vetorInicial = new int[10];
        int[] vetorNegativos;
        preencheVetor(vetorInicial);
        vetorNegativos = retiraNegativos(vetorInicial);
        exibeVetores(vetorNegativos);
    }
    public static void preencheVetor(int[] vetorInicial)
    {
        Console.WriteLine("Digite 10 valores");
        for (int i = 0; i < vetorInicial.Length; i++)
        {
            vetorInicial[i] = int.Parse(Console.ReadLine());
        }
    }
    public static int[] retiraNegativos(int[] vetorInicial)
    {
        int[] vetorNegativos = new int[10];
        int i = 0;
        foreach (int num in vetorInicial)
        {
            if (num < 0)
            {
                vetorNegativos[i] = num;
                i++;
            }
        }
        return vetorNegativos;
    }
    public static void exibeVetores(int[] vetorNegativos)
    {
        Console.WriteLine("Vetor de Negativos:");
        for (int i = 0; i < vetorNegativos.Length; i++)
        {
            Console.WriteLine("Posição {0}: {1}", i, vetorNegativos[i]);
        }
    }
}
