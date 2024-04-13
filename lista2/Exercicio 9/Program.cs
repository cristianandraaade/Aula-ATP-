using System;
    class Program{
        public static void Main(){
            //declaração variavel e entrada de dados
            char selector;
            Console.WriteLine("Digite um sinal (- ou + ou = )");
            selector=char.Parse(Console.ReadLine());
            // switch
            switch (selector){
                case '-':
                Console.WriteLine("SINAL DE MENOR");
                break;
                case '+':
                Console.WriteLine("SINAL DE MAIOR");
                break;
                case '=':
                Console.WriteLine("SINAL DE IGUAL");
                break;
                default:
                Console.WriteLine("OUTRO SINAL");
                break;
            }
        }   
    }