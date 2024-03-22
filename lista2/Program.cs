using System;
    class Program{
        public static void Main(){
            int selector;
            Console.WriteLine("Digite a atividade de 1 a 10");
            selector=int.Parse(Console.ReadLine());

            switch (selector){
                case 1:
                int numeroA, numeroB;
                Console.WriteLine("Digite dois números");
                numeroA=int.Parse(Console.ReadLine());
                numeroB=int.Parse(Console.ReadLine());
                if (numeroA > numeroB){
                    Console.WriteLine("O maior número é " + numeroA);                   
                }
                else{
                    Console.WriteLine("O maior número é " + numeroB);
                }
                break;
                
                case 2:
                int numeroA, numeroB;
                Console.WriteLine("Digite dois número");
                numeroA=int.Parse(Console.ReadLine());
                numeroB=int.Parse(Console.ReadLine());
            }
        
            
        }
    }