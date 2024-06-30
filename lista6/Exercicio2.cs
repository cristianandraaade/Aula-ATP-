using System;
class Exercicio2
{
    public void Run()
    {
        string frase;
        Console.WriteLine("Escreva uma frase");
        frase = Console.ReadLine();
        retiraVogais(frase);
    }
    public void retiraVogais(string frase)
    {
        string[] novaFrase;
        char[] vogais = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
        novaFrase = frase.Split(vogais);
        foreach(string s in novaFrase){
            Console.Write(s);
        }
        Console.WriteLine();
    }
}
