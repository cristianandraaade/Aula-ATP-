using System;
    class Program{
        public static void Main(){
            // declaração de variavel e entrada de dados
            Console.WriteLine("Insira sua nota");
            float nota= float.Parse(Console.ReadLine());
            //processamento e saida de dados
            if (nota>10){
                Console.WriteLine("Nota inválida");
            }
            else if(nota >=8 && nota <=10){
                Console.WriteLine("Ótimo");
            }
            else if(nota >=7 && nota <8){
                Console.WriteLine("Bom");
            }
            else if(nota >=5 && nota <7){
                Console.WriteLine("Regular");
            }
            else if(nota <5){
                Console.WriteLine("Insatisfatório");
            }
            else{
                Console.WriteLine("Nota inválida");
            }
        }
    }
