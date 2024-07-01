using System;
class Exercicio7
{
    public void Run()
    {
        int numeroDeLetras;
        Console.WriteLine("Escreva o número de letras a ser escritas no arquivo");
        numeroDeLetras = int.Parse(Console.ReadLine());
        escreveText(numeroDeLetras);
        leTexto();
    }
    public void escreveText(int numeroDeLetras)
    {
        char letra;
        StreamWriter escreve = new StreamWriter("arquivos/teste3.txt");
        for (int i = 1; i <= numeroDeLetras; i++)
        {
            letra = char.Parse(Console.ReadLine());
            escreve.Write(letra);
        }
        escreve.Close();
    }
    public void leTexto()
    {
        int qtdVogais = 0;
        char[] vogais = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        StreamReader leitura = new StreamReader("arquivos/teste3.txt");
            string linha;
        while ((linha = leitura.ReadLine()) != null)
        {
            foreach (char c in linha)
            {
                if (Array.IndexOf(vogais, c) != -1)
                {
                    qtdVogais++;
                }
            }
        }
        Console.WriteLine($"Quantidade de vogais encontradas: {qtdVogais}");
    }
}