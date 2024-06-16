using System;
class Exercicio6
{
    public void Run()
    {
        double[] temperaturasOutubro = { 22.5, 23.7, 24.2, 33.3, 34.5, 17.8, 18.5, 19.1, 23.3, 32.6, 31.7, 33.1, 24.7, 28.4, 31.6, 16.1, 32.3, 24.6, 25,
        33, 31, 35, 38, 39, 36, 33, 31, 32, 26, 27, 31 };
        double mediaTemperaturas =0, menorTemperatura = 0, maiorTemperatura = 0;
        int diasMaiorMedia =0;
        menorTemperatura = verificaTemperatura(temperaturasOutubro,menorTemperatura, ref maiorTemperatura);
        mediaTemperaturas = calculaMedia(temperaturasOutubro);
        diasMaiorMedia = verificaMaiorMedia(temperaturasOutubro, mediaTemperaturas);
        Console.WriteLine("A menor temperatura foi {0}", menorTemperatura);
        Console.WriteLine("A maior temperatura foi {0}", maiorTemperatura);
        Console.WriteLine("A media das temperaturas foi {0}", mediaTemperaturas);
        Console.WriteLine("O número dos dias que a temperatura foi maior que a media foi {0}", diasMaiorMedia);
    }
    static double verificaTemperatura(double[] temperaturasOutubro, double menorTemperatura, ref double maiorTemperatura){
        menorTemperatura = temperaturasOutubro[0];
        maiorTemperatura = temperaturasOutubro[0];
        for(int i = 1; i < temperaturasOutubro.Length; i++){
            if(menorTemperatura > temperaturasOutubro[i]){
                menorTemperatura = temperaturasOutubro[i];
            }
            if(maiorTemperatura < temperaturasOutubro[i]){
                maiorTemperatura = temperaturasOutubro[i];
            }
        }
        return menorTemperatura;
    }
    static double calculaMedia(double[] temperaturasOutubro){
        double soma = 0;
        for(int i = 0; i < temperaturasOutubro.Length; i++){
            soma+=temperaturasOutubro[i];
        }
        return soma/(double)31;
    }
    static int verificaMaiorMedia(double[] temperaturasOutubro, double mediaTemperaturas){
        int cont = 0;
        for(int i=0; i < temperaturasOutubro.Length; i++){
            if(temperaturasOutubro[i] < mediaTemperaturas){
                cont++;
            }
        }
        return cont;
    }
}