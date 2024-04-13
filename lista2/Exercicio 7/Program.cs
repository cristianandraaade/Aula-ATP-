using System;
    class Program{
        public static void Main(){
            //declaração de variaveis e entrada de dados
            double x,y;
            Console.WriteLine("DIgite o valor de x");
            x=double.Parse(Console.ReadLine());
            // processamento e saida de dados
            if (x <= 1){
                y=1;
                Console.WriteLine("O valor de y é " + y);
            }
            else if (1<x && x<=2){
                y=2;
                Console.WriteLine("O valor de y é " + y);
            }
            else if(x>2 && x<=3){
                y=Math.Pow(x,2);
                Console.WriteLine("O valor de y é " + y);
            }
            else{
                y=Math.Pow(x,3);
                Console.WriteLine("O valor de y é " + y);
            }
        }
    }