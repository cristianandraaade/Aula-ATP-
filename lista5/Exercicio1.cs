using System;
    class Exercicio1{
        public void Run(){
            int[] vetorN = new int[20];
            Console.WriteLine("Digite 20 valores para preencher o vetor");
            for(int i=0; i < 20; i++){
                vetorN[i] = int.Parse(Console.ReadLine());
            }
            encontraMenor(vetorN);
        }
        public static void encontraMenor(int[] vetorN){
            int menorValor = vetorN[0], posicao = 0;
            for(int i= 1; i < vetorN.Length; i++){
                if(menorValor > vetorN[i]){
                    menorValor = vetorN[i];
                    posicao = i;
                }
            }
            Console.WriteLine("O menor elemento de vetorN é "+ menorValor + " e sua posição dentro do vetor é " + posicao);
        }
    }