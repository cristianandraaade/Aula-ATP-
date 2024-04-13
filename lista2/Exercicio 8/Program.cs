using System;
    class Program{
        public static void Main(){
            // declaração de variaveis
            double salarioAtual, opcaoA, opcaoB, opcaoC;
            char selector;
            // entrada de dados
            Console.WriteLine("Digite o salario atual");
            salarioAtual=double.Parse(Console.ReadLine());
            Console.WriteLine("Selecione uma opção (A, B ou C)");
            selector=char.Parse(Console.ReadLine());
            //switch
            switch (selector){
                case 'A':
                    opcaoA = salarioAtual * 1.08;
                    Console.WriteLine("O novo salario é {0:c2}", opcaoA);
                break;
                case 'B':
                    opcaoB= salarioAtual * 1.11;
                    Console.WriteLine("O novo salario é {0:c2}", opcaoB);
                break;
                case 'C':
                    if (salarioAtual <=1000){
                        opcaoC= salarioAtual + 350;
                        Console.WriteLine("O novo salario é {0:c2}", opcaoC);
                    }
                    else{
                        opcaoC= salarioAtual + 200;
                        Console.WriteLine("O novo salario é {0:c2}", opcaoC);
                    }
                break;
            }
        }
    }