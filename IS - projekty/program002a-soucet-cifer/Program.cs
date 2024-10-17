using System;
using System.Collections.Concurrent;
using System.Reflection;

class Vypis_rady{
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
            Console.WriteLine("============================");
            Console.WriteLine("uzivatel zadal: {0}", number);
            Console.WriteLine("============================\n\n");

            int suma = 0; //iteracni suma inicializuju jako neutralni treba s scitanim 0
            int numberBackup = number;
            int digit;
            int soucin = 1;

            //pokud je cislo zaporne zmenim ho na kladne
            if(number < 0){
                number = - number;
            }

            while(number >= 10){
                digit = number % 10; //operator modulo(%) 123/10 = 12 a 3 - urceni zbytku po deleni cisle
                number = (number - digit) / 10;
                Console.WriteLine("Digit je {0}", digit);
                suma = suma + digit;
                soucin = soucin * digit;
            }
            Console.WriteLine("Digit je {0}", number);
            suma = suma + number;
            soucin = soucin * number;

            Console.WriteLine("\n\nSoucet cifer cisla {0} je {1}", numberBackup, suma);
            Console.WriteLine("Soucit cifer cisla {0} je {1}\n\n", numberBackup, soucin);

            //opakovani programu - TO-DO
            Console.WriteLine("pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}