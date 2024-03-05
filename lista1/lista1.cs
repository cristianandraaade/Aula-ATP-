/*
git add . (adiciona os arquivos pra comitar)
git commit -m "lista 1 4/3/2024" (criar uma versão nova)
git push (sobe a versão pro github)
*/
using System;
class Program{
    public static void Main(){

        

        /*Questão 1

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

        */

        /*Questão 2

        //declaração de variaveis

        double hip,cat1,cat2;

        //Entrada de dados

        Console.WriteLine("Digite dois catetos");
        cat1 = double.Parse(Console.ReadLine());
        cat2 = double.Parse(Console.ReadLine());

        //Processamento de dados

        hip = Math.Sqrt(Math.Pow(cat1,2) + (Math.Pow(cat2,2)));

        //Saida de dados

        Console.WriteLine("O valor da hipotenusa é: {0:2f} ",hip);

        */

        //Questão 3

        //declaração de variaveis

        double salario, watt, valor_100watt, valor_pagar, valor_desconto;

        //Entrada de dados

        Console.WriteLine(" Digite o valor de um salário mínimo ");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine(" Digite a quantidade de quilowatts gasta na residencia");
        watt = double.Parse(Console.ReadLine());

        //Processamento de dados

        valor_100watt = salario / 7 / 100;
        valor_pagar = watt + valor_100watt;
        valor_desconto = valor_pagar * 0.9;

        //saida de dados
        
        Console.WriteLine("o valor em reais de cada kilowatt: {0:f2}", valor_100watt);
        Console.WriteLine("o valor a ser pago: {0:f2}", valor_pagar);
        Console.WriteLine("o valor com desconto: {0:f2}", valor_desconto);
    

        




        

    

    }
}