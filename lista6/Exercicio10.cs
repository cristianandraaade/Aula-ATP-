using System;
class Exercicio10
{
    public void Run()
    {
        float valorMinimo = float.MaxValue, valorMaximo = float.MinValue, valorTotal = 0, mediaValores = 0, valor;
        int qtdValores = 0;
        string linha;
        StreamReader leitura = new StreamReader("arquivos/teste5.txt");
        linha = leitura.ReadLine();
        while (linha != null)
        {
            valor = float.Parse(linha);
            if (valorMinimo > valor)
            {
                valorMinimo = valor;
            }
            if (valorMaximo < valor)
            {
                valorMaximo = valor;
            }
            valorTotal += valor;
            qtdValores++;
            linha = leitura.ReadLine();
        }
        leitura.Close();
        mediaValores = valorTotal / (float)qtdValores;
        Console.WriteLine("Maior valor " + valorMaximo);
        Console.WriteLine("Menor valor " + valorMinimo);
        Console.WriteLine("media dos valors " + mediaValores);
    }
}
