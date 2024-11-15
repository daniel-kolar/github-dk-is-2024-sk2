using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;

class Vypis_rady{
    static void Main(){
        
        //chci aby se program opakoval po stisku klavesy a
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("*************************************************");
            Console.WriteLine("**************** Radici metody ******************");
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

            for(int i = 0; i < n; i++){
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0}, ", myArray[i]);
            }

            
            
            //RADICI METODY
            Console.WriteLine("\n\n=====================");
            Stopwatch myStopwatch = new Stopwatch();
            

            //SELECTION SORT

            int biggestNum = 0;
            myStopwatch.Start();
            for(int i = 0; i < n; i++){ //prochazim pole
                biggestNum = i; //nejvetsi cislo je prvni(nulty prvek)
                for(int j = i + 1; j < n; j++){ //prochazim zbytek pole, pokud najdu prvek vetsi/mensi nez prvni tak ho nahradim
                    if(myArray[j] > myArray[biggestNum]){
                        biggestNum = j;
                    }
                }
                int tmp = myArray[i]; //vymena prvků
                myArray[i] = myArray[biggestNum];
                myArray[biggestNum] = tmp;
            }
            myStopwatch.Stop();

            Console.WriteLine("\n\nSerazene pole pomoci Selection sort: ");
            for(int i = 0; i < n; i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine("\n\nCas Selection sort: {0} ms", myStopwatch.Elapsed);



            //INSERTION SORT

            myStopwatch.Reset();
            myStopwatch.Start();
            for(int i = 0; i < n - 1; i++){
                int j = i + 1;
                int tmp = myArray[j];
                while(j > 0 && tmp > myArray[j - 1]){
                    myArray[j] = myArray[j - 1];
                    j--;
                }
                myArray[j] = tmp;
            }
            myStopwatch.Stop();

            Console.WriteLine("\n\nSerazene pole pomoci Insertion sort:");
            for(int i = 0; i < n; i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine("\n\nCas Selection sort: {0} ms", myStopwatch.Elapsed);



            //SHAKER SORT



            //opakovani programu - TO-DO
            Console.WriteLine("\n\npro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}