        using System;
        public class Exercicio9
        {
            public void Run()
            {
                float mediaalunos = CalcularMediaFunção();
                Console.WriteLine("A media dos alunos aprovados é: " + mediaalunos);
            }
            static float CalcularMediaFunção(){
                int notaAluno, qtdAprov = 0, somaNotaAprov = 0;
                float mediaAlunosAprov;
                do{
                    Console.WriteLine("Digite a nota do aluno (insira um número negativo para sair)");
                    notaAluno = int.Parse(Console.ReadLine());
                    if (notaAluno > 0){
                        if (notaAluno >= 6){
                            Console.WriteLine(notaAluno);
                            somaNotaAprov+=notaAluno;
                            qtdAprov++;
                        }
                    }
                }while(notaAluno > 0);
                mediaAlunosAprov = (float)somaNotaAprov/qtdAprov;
                return mediaAlunosAprov;
            }
        }