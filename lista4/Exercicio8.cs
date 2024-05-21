using System;
public class Exercicio8{
    public void Run(){
        int numeroDigitado;
        Console.WriteLine("Digite um número");
        numeroDigitado = int.Parse(Console.ReadLine());
        float soma = CalculaS(numeroDigitado);
        Console.WriteLine("o valor de s é:" + soma);
    }
    static float CalculaS(int numeroDigitado){
        int fator1 = 2, fator2 = 4;
        float soma = 0;

        for(int i = fator1; i <= numeroDigitado+3; fator1+=3){
            soma+= fator1/fator2;
            fator2++;
        }
        return soma;
    }
}