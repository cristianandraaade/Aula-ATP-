using System;
class Program{
    public static void Main(){
        //entrada de dados
        int a,b,x;
        Console.WriteLine("Digite o valor de a e b");
        a=int.Parse(Console.ReadLine());
        b=int.Parse(Console.ReadLine());
        // processamento e saide de dados
        if (a>0){
            x = -b/a;
            Console.WriteLine("O valor de x é " + x);
        }
        else {
            Console.WriteLine("Não é possivel calcular x");
        }       
    }
}