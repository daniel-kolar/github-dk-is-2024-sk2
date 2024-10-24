using System;
using System.Collections.Concurrent;
using System.Reflection;

class Vypis_rady{
    static void Main(){
        
        //chci aby se program opakoval po stisku klavesy a
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("*************************************************");
            Console.WriteLine("******** Generátor pseudonáhodných čísel ********");
            Console.WriteLine("*************************************************");
            Console.WriteLine("**************** Daniel Kolář *******************");
            Console.WriteLine("***********************************************\n"); //\n new line nebo console.writeline()
            Console.WriteLine();

            //vstup od uzivatele - lepsi varianta
            Console.Write("zadejte pocet generovanych cisel (cele cislo): "); //obecny ukladani pro neznama data jsou dobre vyuzit arrays(pole)
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu první celé číslo řady: ");
            }

            Console.Write("zadejte dolni mez (cele cislo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu první celé číslo řady: ");
            }

            Console.Write("zadejte horni mez (cele cislo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu první celé číslo řady: ");
            }

            //kontrola vstupu uzivatele
            Console.WriteLine("\n\n=====================");
            Console.WriteLine("Uživatelův vstup:");
            Console.WriteLine("Pocet cisel: {0}; dolni mez: {1}; horni mez: {2}", n, dm, hm);
            Console.WriteLine("=====================\n\n");

            //deklarace array(pole) - vic suplicku pro data, ktery maji svoje indexy
            int[] myArray = new int[n]; //UZITECNE - nauc se to (vis, ze ti pole nikdy nesli)
            
            //priprava pro generovani nahodnych cisel
            Random randomNumber = new Random();

            Console.WriteLine("náhodna cisla: ");

            int kladne = 0;
            int zaporne = 0;
            int nuly = 0;
            int suda = 0;
            int licha = 0;

            for(int i = 0; i < n; i++){
                myArray[i] = randomNumber.Next(dm, hm + 1); //generator
                Console.Write("{0}; ", myArray[i]);

                //rozhodovani jestli je cislo kladne, zaporne nebo nula
                /*if(myArray[i] > 0) //neoptimalni reseni
                    kladne++;
                if(myArray[i] < 0)
                    zaporne++;
                if(myArray[i] == 0)
                    nuly++;*/


                //rozhodovani jestli je cislo kladne, zaporne nebo nula
                if(myArray[i] > 0) //optimalni reseni
                    kladne++;
                else if(myArray[i] < 0)
                    zaporne++;
                else
                    nuly++;

                //rozhodovani sudosti nebo lichosti
                if(myArray[i] % 2 == 0)
                    suda++;
                else licha++;
            }

            Console.WriteLine("\n\npocet kladnych cisel: {0} ", kladne);
            Console.WriteLine("pocet zapornych cisel: {0} ", zaporne);
            Console.WriteLine("nulova cisel: {0}", nuly);
            Console.WriteLine("\n\npocet sudych cisel: {0} ", suda);
            Console.WriteLine("pocet lichych cisel: {0} ", licha);


            //opakovani programu - TO-DO
            Console.WriteLine("\n\npro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}