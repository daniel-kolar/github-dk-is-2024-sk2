using System;
using System.Collections.Concurrent;
using System.Reflection;

class Soucin_cifer{
    static void Main(){
        
        //chci aby se program opakoval po stisku klavesy a
        string again = "a";
        while(again == "a"){
            //Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("*** Součet a součin cifer ***");
            Console.WriteLine("*****************************");
            Console.WriteLine("******** Daniel Kolář *******");
            Console.WriteLine("*****************************\n"); //\n new line nebo console.writeline()
            Console.WriteLine();

            //vstup od uzivatele - spatna varianta
                //Console.Write("zadejte prvni cislo rady: ");
                //int first = int.Parse(Console.ReadLine());

            //vstup od uzivatele - lepsi varianta
            Console.Write("zadejte cele cislo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte celé číslo: ");
            }

            //kontrola vstupni hodnoty
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine("uzivatel zadal: {0}", number);
            Console.WriteLine("============================\n\n"); 
            
            //ciferny soucet
            int result = number.ToString().Sum(c => c - '0');
            Console.Write("ciferny soucet zadaneho cisla je {0}\n", result);

            //opakovani programu - TO-DO
            Console.WriteLine("pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}