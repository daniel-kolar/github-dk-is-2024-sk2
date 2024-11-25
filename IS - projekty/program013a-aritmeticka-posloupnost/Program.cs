using System;
using System.Collections.Concurrent;
using System.Reflection;

class Vypis_rady{
    static void Main(){
        
        //chci aby se program opakoval po stisku klavesy a
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("******** Výpis řady *********");
            Console.WriteLine("*****************************");
            Console.WriteLine("******** Daniel Kolář *******");
            Console.WriteLine("*****************************\n"); //\n new line nebo console.writeline()
            Console.WriteLine();

            //vstup od uzivatele - lepsi varianta
            Console.Write("Zadejte počet čísel v celé řadě: ");
            int pocetPrvku;
            while(!int.TryParse(Console.ReadLine(), out pocetPrvku)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu počet čísel v celé řadě: ");
            }

            Console.WriteLine("Zadejte diferenci (rozdíl mezi dvěma po sobě jdoucími prvky): ");
            int diference;
            while(!int.TryParse(Console.ReadLine(), out diference)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu diferenci");
            }

            Console.WriteLine("Zadejte první prvek řady: ");
            int prvniPrvek;
            while(!int.TryParse(Console.ReadLine(), out prvniPrvek)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu prvni prvek řady: ");
            }

            //vypočet členů aritmetické posloupnosti
            //algoritmus programu
            int soucetPrvku = 0;
            int[] posloupnost = new int[pocetPrvku];
            for (int i = 0; i < pocetPrvku; i++){
                posloupnost[i] = prvniPrvek + (i * diference);
                soucetPrvku += posloupnost[i];
            }

            //vypis vysledku
            Console.WriteLine("\nPosloupnost: ");
            for(int i = 0; i < pocetPrvku; i++){
                Console.Write("{0}, ", posloupnost[i]);
            }
            Console.WriteLine("\nSoučet prvků = {0}", soucetPrvku);

            //opakovani programu - TO-DO
            Console.WriteLine("pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}