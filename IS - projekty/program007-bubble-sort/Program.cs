using System;
using System.Collections.Concurrent;
using System.Diagnostics; // pouzivame pro Stopwatch()
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
            int[] myArray = new int[n];     //UZITECNE - nauc se to (vis, ze ti pole nikdy nesli)
            
            //priprava pro generovani nahodnych cisel
            Random randomNumber = new Random();

            Console.WriteLine("náhodna cisla: ");

            for(int i = 0; i < n; i++){
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0}, ", myArray[i]);
            }
            //stopky pro casovani naseho algoritmu - jak rychle to srovnani provede
            Stopwatch myStopwatch = new Stopwatch();

            //pocet srovnani a zmen
            int numberCompare = 0;
            int numberChange = 0;

            myStopwatch.Start();    //stopky zapinam

            //algoritmus pro Bubblesort
            for (int i = 0; i < n-1; i++){      //for pro projiti vsech prvku generovanyho pole
                for(int j = 0; j < n-i-1; j++){     //for pro porovnani prvků v generovanym poli
                    numberCompare++;        //pocet porovnani --> kolikrat se cisla v poli porovnaji
                    if(myArray[j] < myArray[j+1]){      //samotny porovnavani prvku
                        int tmp = myArray[j];       //int tmp je temporal number, ktery existuje jenom a pouze pro tento algoritmus. Po provedeni zanika
                        myArray[j] = myArray[j+1];
                        myArray[j+1] = tmp;
                        numberChange++;     //pocet zmen --> kolikrat se cisla vymeni
                    }
                }
            }

            myStopwatch.Stop();     //stopky vypinam

            Console.WriteLine("\n\n\nSeřazené pole čísel");
            for(int i = 0; i < n; i++){
                Console.Write("{0}, ", myArray[i]);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\nČas potřebný na seřazení pole pomocí BubbleSort: {0}", myStopwatch.Elapsed);     //vypsani casu
            Console.WriteLine("Počet porovnaní: {0}", numberCompare);
            Console.WriteLine("Počet změn: {0}", numberChange);
            Console.ResetColor();


            //opakovani programu - TO-DO
            Console.WriteLine("\n\npro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}