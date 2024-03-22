using System;
    class Program{
        public static void Main(){
            int selector;
            Console.WriteLine("Digite a atividade de 1 a 10");
            selector=int.Parse(Console.ReadLine());

            switch (selector){
                case 1:
                //declaração de variaveis
                int numeroA, numeroB;
                //Entrada de dados
                Console.WriteLine("Digite dois números");
                numeroA=int.Parse(Console.ReadLine());
                numeroB=int.Parse(Console.ReadLine());
                //Processamento e saida de dados
                if (numeroA > numeroB){
                    Console.WriteLine("O maior número é " + numeroA);                   
                }
                else{
                    Console.WriteLine("O maior número é " + numeroB);
                }
                break;
                
                case 2:
                //declaração de variaveis
                int resultadoAdicao;
                //Entrada de dados
                Console.WriteLine("Digite dois número");
                numeroA=int.Parse(Console.ReadLine());
                numeroB=int.Parse(Console.ReadLine());
                //Processamento e saida de dados
                resultadoAdicao= numeroA + numeroB;
                if (resultadoAdicao >= 10){
                    int condicao1 = (resultadoAdicao + 5);
                    Console.WriteLine("O valor é " + condicao1);
                }
                else{
                    int condicao2= (resultadoAdicao + 7);
                    Console.WriteLine("O valor é " + condicao2);
                }
                break;
                
                case 3:
                
                
            }
        
            
        }
    }