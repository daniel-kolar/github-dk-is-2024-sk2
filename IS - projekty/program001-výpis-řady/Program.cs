using System;

class Vypis_rady{
    static void Main(){
        int prvni = 1;
        int posledni = 10;
        int krok = 2;

        for (int i = prvni; i <= posledni; i += krok){
            Console.WriteLine(i);
        }
    }
}