using System;
class Exercicio5
{
    public void Run()
    {
        StreamReader arquivo = new StreamReader("arquivos/teste.txt");
        string leitura = arquivo.ReadLine();
        int contLinha = 0;
        while(leitura != null){
            Console.WriteLine(leitura);
            contLinha++;
            leitura = arquivo.ReadLine();
            
        }
        Console.WriteLine("QTD de linhas " + contLinha);
        arquivo.Close();
    }
}
