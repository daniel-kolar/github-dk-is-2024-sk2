using System;

class Vypis_rady{
    static void Main(){
        Console.WriteLine("zadej 1. cislo: ");
        int prvni = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("zadej cislo vetsi nez 1.: ");
        int posledni = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("zadej cislo, ktere chces pricist: ");
        int krok = Convert.ToInt32(Console.ReadLine());
        /*int prvni = 1;
        int posledni = 10;
        int krok = 2;*/

        for (int i = prvni; i <= posledni; i += krok){
            Console.WriteLine(i);
        }
    }
}