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

            int interval_0_25 = 0;
            int interval_25_50 = 0;
            int interval_50_75 = 0;
            int interval_75_100 = 0;

            for(int i = 0; i < n; i++){
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0}, ", myArray[i]);

                if(myArray[i]<= (0.25 * hm)){
                    interval_0_25++;
                }
                else if(myArray[i] <= (0.5 * hm)){
                    interval_25_50++;
                }
                else if(myArray[i] <= (0.75 * hm)){
                    interval_50_75++;
                } 
                else interval_75_100++;
            }

            Console.WriteLine("\n\nPocet cisel v intervalu <{0} ; {1}>: {2}", dm, 0.25*hm, interval_0_25);
            Console.WriteLine("Pocet cisel v intervalu <{0} ; {1}>: {2}", 0.25 * hm + 1, 0.5 * hm, interval_25_50);
            Console.WriteLine("Pocet cisel v intervalu <{0} ; {1}>: {2}", 0.5 * hm + 1, 0.75 * hm, interval_50_75);
            Console.WriteLine("Pocet cisel v intervalu <{0} ; {1}>: {2}", 0.75 * hm + 1, hm, interval_75_100);

            Console.WriteLine("\nSoucet intervalu je: {0}", interval_0_25 + interval_25_50+interval_50_75+interval_75_100);

            //opakovani programu - TO-DO
            Console.WriteLine("\n\npro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}