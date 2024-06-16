using System;
using System.Runtime.InteropServices;
class Exercicio5
{
    public void Run()
    {
        int[] vetorSorteio = sorteiaNumeros();
        tentativaUsuario(vetorSorteio);
    }
    public static int[] sorteiaNumeros()
    {
        int[] vetorSorteio = new int[3];
        Random sorteio = new Random();
        for (int i = 0; i < vetorSorteio.Length; i++)
        {
            vetorSorteio[i] = sorteio.Next(10, 51);
            
        }
        return vetorSorteio;
    }
    public static void tentativaUsuario(int[] vetorSorteio)
    {
        bool final = false;
        while (final == false)
        {
            Console.WriteLine("Tente acerta um número sorteado");
            for (int i = 0; i < vetorSorteio.Length; i++)
            {
                int tentativa = int.Parse(Console.ReadLine());
                if (tentativa == vetorSorteio[i])
                {
                    Console.WriteLine("Você acertou");
                    Console.Write("Os números eram {0} {1} {2}", vetorSorteio[0], vetorSorteio[1], vetorSorteio[2]);
                    final = true;
                }
            }
        }
    }
}