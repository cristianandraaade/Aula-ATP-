using System;
    class Program{
        public static void Main(){
            // declarão de variaveis
            int numeroDigitado=0,numerosPositivos=-1,NumerosNegativos=0,zeros=0;
            int stop=007;
            while (numeroDigitado != stop){
                Console.WriteLine("Digite números inteiro(Digite 007 para encerrar)");
                numeroDigitado=int.Parse(Console.ReadLine());
                if (numeroDigitado == 0){
                    zeros ++;
                }
                else if (numeroDigitado >0){
                    numerosPositivos++;
                }
                else {
                    NumerosNegativos++;
                }
            }
            Console.WriteLine("Números positivos: " + numerosPositivos);
            Console.WriteLine("Números negativos: " + NumerosNegativos);
            Console.WriteLine("Zeros: " + zeros);
        }
    }