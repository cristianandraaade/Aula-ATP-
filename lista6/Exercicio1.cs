using System;
class Exercicio1
{
    public void Run()
    {
        string frase;
        Console.WriteLine("Escreva uma frase");
        frase = Console.ReadLine();
        contaEspaços(frase);
    }
    public static void contaEspaços(string frase){
        int cont = 0;
        for(int i =0; i < frase.Length; i++){
            if(frase[i] == ' '){
                cont++;
            }
        }
        Console.WriteLine("Quantidade de espaços brancos " + cont);
    }
}

