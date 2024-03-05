/*
git add . (adiciona os arquivos pra comitar)
git commit -m "lista 1 4/3/2024" (criar uma versão nova)
git push (sobe a versão pro github)
*/
using System;
class Program{
    public static void Main(){

        //declaração de variaveis

        int b,altura,perim,area;
        double diago;

        //Entrada de dados

        Console.WriteLine ("Digite base e altura");
        b = int.Parse(Console.ReadLine());
        altura = int.Parse(Console.ReadLine());

        //Processamento de dados

        area =b*altura;
        perim = 2*(b+altura);
        diago = Math.Sqrt(Math.Pow(b,2) +Math.Pow(altura,2));

        //Saida de Dados
        Console.WriteLine("O valor da área é: " + area);
        Console.WriteLine("O valor do perimetro é: " + perim);
        Console.WriteLine("O valor da diagonal é " + diago);
        
    

    }
}