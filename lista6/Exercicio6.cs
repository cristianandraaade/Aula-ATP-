using System;
class Exercicio6
{
    public void Run()
    {
        int[] divisores = new int [100];
        int numeroDigitado;
        Console.WriteLine("Digite um número");
        numeroDigitado = int.Parse(Console.ReadLine());
        mostraDivisores(divisores, numeroDigitado);
        StreamReader arquivo = new StreamReader("arquivos/teste2.txt");
        string linha = arquivo.ReadLine();
        Console.WriteLine(linha);
        arquivo.Close();
    }
    public void mostraDivisores(int[] divisores, int numeroDigitado){
        int index = 0;
        StreamWriter arquivo = new StreamWriter("arquivos/teste2.txt");
        for(int i =1; i <= numeroDigitado; i++){
            if(numeroDigitado % i == 0){
                arquivo.Write(i +" ");
            }
        }
        arquivo.Close();
    }
}
