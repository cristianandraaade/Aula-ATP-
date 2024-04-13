using System;
    class Program{
        public static void Main(){
            // declaração de variaveis
            double valorNormal, valorPromocional,totalPromocional,totalNormal,difTotais;
            // entrada de dados
            Console.WriteLine("Qual o valor normal da diária");
            valorNormal=double.Parse(Console.ReadLine());
            // processamento de dados
            valorPromocional= valorNormal - valorNormal * 0.25;
            totalPromocional= (75 * 0.8)*valorPromocional;
            totalNormal= (75 * 0.5)*valorNormal;
            difTotais= totalPromocional-totalNormal;
            // saida de dados
            Console.WriteLine("O valor da diaria promocional é {0:c2}" , valorPromocional);
            Console.WriteLine("O total da diaria promocional com 80% de ocupação é {0:c2}" , totalPromocional);
            Console.WriteLine("O total da diaria normal com 50% de ocupação é {0:c2}" , totalNormal);
            Console.WriteLine("A diferença entre os dois totais é {0:c2}", difTotais);
        }
    }