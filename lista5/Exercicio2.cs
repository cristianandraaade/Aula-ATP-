using System;
    class Exercicio2{
        public void Run(){
            double[] vetorNotas = new double [10];
            entradaDeNotas(vetorNotas);
            calculaMedia(vetorNotas);
        }
        public static void entradaDeNotas(double[] vetorNotas){
            Console.WriteLine("Digite as 10 notas dos alunos");
            for(int i=0; i < vetorNotas.Length; i++){
                vetorNotas[i] = double.Parse(Console.ReadLine());
            }
        }
        public static void calculaMedia(double[] vetorNotas){
            double mediaTurma, soma = 0;
            int alunosAcima = 0;
            for(int i=0; i < vetorNotas.Length; i++){
                soma += vetorNotas[i];
            }
            mediaTurma = soma/(double)10;
            for(int i=0; i < vetorNotas.Length; i++){
                if(vetorNotas[i] > mediaTurma){
                    alunosAcima++;
                }
            }
            Console.WriteLine("A média das notas é {0:f2}" , mediaTurma);
            Console.WriteLine("A quantidade de alunos acima da media foi " + alunosAcima);
        }
    }