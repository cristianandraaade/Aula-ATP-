using System;
    class Program{
        public static void Main(){
            int numeroDigitado=0, numerosDivisiveis3e9=0,numerosDivisiveis2e5=0;
            Console.WriteLine("Insira 10 números");
            for(int i =1; i <=10; i++){
                numeroDigitado=int.Parse(Console.ReadLine());
                Console.WriteLine(i);
                if (numeroDigitado % 2 == 0)&&(numeroDigitado % 5 == 0){
                    numerosDivisiveis2e5++;
                }
                else if(numeroDigitado % 3 == 0)&&(numeroDigitado % 9 == 0){
                    numerosDivisiveis3e9++;
                }
                else
                {
                    
                }
            }
        }
    }