using System;
class Exercicio4
{
    public void Run()
    {
        // Declarando os vetores X e Y com 10 elementos cada
        int[] vetorX = new int[10];
        int[] vetorY = new int[10];

        // Preenchendo os vetores X e Y
        Console.WriteLine("Preenchimento do vetor X:");
        PreencherVetor(vetorX);

        Console.WriteLine("\nPreenchimento do vetor Y:");
        PreencherVetor(vetorY);

        // Intercalando os vetores X e Y
        int[] vetorIntercalado = IntercalarVetores(vetorX, vetorY);

        // Exibindo o vetor intercalado
        Console.WriteLine("\nVetor intercalado:");
        ExibirVetor(vetorIntercalado);

        Console.ReadLine();
    }
    static void PreencherVetor(int[] vetor)
    {

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Digite o elemento {i} do vetor: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static int[] IntercalarVetores(int[] vetor1, int[] vetor2)
    {
        int[] vetorIntercalado = new int[vetor1.Length + vetor2.Length];
        int indiceVetor1 = 0;
        int indiceVetor2 = 0;

        for (int i = 0; i < vetorIntercalado.Length; i++)
        {
            if (i % 2 == 0 && indiceVetor1 < vetor1.Length)
            {
                vetorIntercalado[i] = vetor1[indiceVetor1];
                indiceVetor1++;
            }
            else if (indiceVetor2 < vetor2.Length)
            {
                vetorIntercalado[i] = vetor2[indiceVetor2];
                indiceVetor2++;
            }
        }

        return vetorIntercalado;
    }

    static void ExibirVetor(int[] vetor)
    {
        Console.Write("Conteúdo do vetor: ");
        foreach (var item in vetor)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}