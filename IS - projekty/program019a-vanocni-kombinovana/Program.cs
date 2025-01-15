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

            int minimum = 0;
            int maximum = 0;
            int soucetCisel = 0;

            Console.WriteLine("náhodna cisla: ");

            for(int i = 0; i < n; i++){
                myArray[i] = randomNumber.Next(dm, hm + 1);
                soucetCisel += myArray[i];
                Console.Write("{0}, ", myArray[i]);
                if(myArray[i] < minimum){
                    minimum = myArray[i];
                } else if (myArray[i] > maximum){
                    maximum = myArray[i];
                }
            }
            int prumerPole = soucetCisel / n;
            int zbytekPole = soucetCisel % n;
            Console.WriteLine("\n\nMaximum a minimum {0}, {1}", maximum, minimum);
            Console.WriteLine("\nSoucet vsech cisel v poli je: {0}", soucetCisel);
            Console.WriteLine("\nPrumer pole je: {0}", prumerPole);
            Console.WriteLine("\nZbytek po deleni pole je: {0}", zbytekPole);

            Stopwatch myStopwatch = new Stopwatch();

            // Inicializace proměnných
            int maxValue = 0;
            List<int> maxIndices = new List<int>();

            // Procházení pole
            for (int i = 0; i < n; i++)
            {
                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                    maxIndices.Clear();
                    maxIndices.Add(i);
                }
                else if (myArray[i] == maxValue)
                {
                    maxIndices.Add(i);
                }
            }

            // Výstup
            Console.WriteLine("\n\nPozice největšího čísla v poli:");
            foreach (int index in maxIndices)
            {
                Console.Write("{0}, ", index);
            }
            
            //COMB SORT
            int gap = n;
            bool swappedComb = true;

            myStopwatch.Reset();
            myStopwatch.Start();
            while(gap != 1 || swappedComb){
                gap = (int)(gap / 1.3);
                if (gap < 1) gap = 1;
                swappedComb = false;

                for(int i = 0; i < n - gap; i++){
                    if(myArray[i] < myArray[i + gap]){
                        int tmp = myArray [i];
                        myArray[i] = myArray[i + gap];
                        myArray[i + gap] = tmp;
                        swappedComb = true;
                    }
                }
            }
            myStopwatch.Start();

            Console.WriteLine("\n\nSeřazené pole pomocí Comb Sort: ");
            for(int i = 0; i < n; i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine("\nČas Comb Sort: {0}", myStopwatch.Elapsed);
            
            //INSERTION SORT
            myStopwatch.Start();
            for(int i = 1; i < n - 1; i++){
                int tmp = myArray[i];
                int j = i - 1;
                while(j >= 0 && tmp > myArray[j]){
                    myArray[j + 1] = myArray[j];
                    j--;
                }
                myArray[j + 1] = tmp;
            }
            myStopwatch.Stop();
            Console.WriteLine("\n\nSeřazené pole pomocí Insertion Sort:");
            for(int i = 0; i < n; i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine("\nČas Insertion Sort: {0}", myStopwatch.Elapsed);

            //nalezeni 3. nejvetsich cisel v poli
            int first = 0;
            int second = 0;
            int third = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = myArray[i];

                // Ignorovat duplicity
                if (currentNumber == first || currentNumber == second || currentNumber == third)
                    continue;

                if (currentNumber > first)
                {
                    third = second;
                    second = first;
                    first = currentNumber;
                }
                else if (currentNumber > second)
                {
                    third = second;
                    second = currentNumber;
                }
                else if (currentNumber > third)
                {
                    third = currentNumber;
                }
            }

            Console.WriteLine("\n\nPrvní tři největší čísla (bez duplicit):");
            Console.WriteLine("První: {0}, Druhé: {1}, Třetí: {2}", first, second, third);


            //KRESLENI STROMU
            Console.WriteLine("\n\nKreslený strom: ");
            for(int i = 0; i <= prumerPole; i++){
                for(int j = 0; j <= i; j++){
                    Console.Write("* ");    
                }
            }

            //opakovani programu - TO-DO
            Console.WriteLine("\n\npro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}