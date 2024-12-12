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

            for(int i = 0; i < n; i++){ //generace pole
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

            Console.WriteLine("\n\nSerazene pole pomoci Insertion sort:");
            for(int i = 0; i < n; i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine("\n\nCas Insertion sort: {0} ms", myStopwatch.Elapsed);


           
            //SHAKER SORT
            myStopwatch.Reset();
            myStopwatch.Start();

            bool swapped = true;
            int start = 0;
            int end = n - 1;

            while(swapped == true){
                swapped = false; //reset pro pripad, ze se nic nezmění
                for(int i = start; i < end; i++){ //projizdim od zdola nahoru stejne jako v selection sortu(bubblesort)
                    if(myArray[i] < myArray[i + 1]){
                        int tmp = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = tmp;
                        swapped = true;
                    }
                }

                if(swapped == false) break; //pokud se nic neprohodi, tak je pole uz serazene
                swapped = false; //reset pro dalsi fazi
                end--; //konec zmensim o jednu protoze posledni prvek je uz serazen

                for(int i = end; i > start; i--){ //projizdim od zhora dolu
                    if(myArray[i - 1] < myArray[i]){
                        int tmp = myArray[i - 1];
                        myArray[i - 1] = myArray[i];
                        myArray[i] = tmp;
                        swapped = true;
                    }
                }
                start++; //zacatek posunu o jednu dolu, protoze prvni prvek je uz serazen
            }
            myStopwatch.Stop();
            Console.WriteLine("\n\nSerazene pole pomoci Shaker sort:");
            for(int i = 0; i < n; i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine("\n\nCas Shaker sort: {0} ms", myStopwatch.Elapsed);


            //COMB SORT
            myStopwatch.Reset();
            myStopwatch.Start();

            int gap = n; //zacatek rozdilu
            bool swappedComb = true;

            while(gap != 1 || swappedComb){ //zmensuju gap
                gap = (int)(gap / 1.3);
                if(gap < 1) gap = 1; //gap nesmí byt menší než 1
                swappedComb = false;

                for(int i = 0; i < n - gap; i++){ //projizdim od zdola nahoru
                    if(myArray[i] < myArray[i + gap]){
                        int tmp = myArray[i];
                        myArray[i] = myArray[i + gap];
                        myArray[i + gap] = tmp;
                        swappedComb = true;
                    }
                }
            }
            myStopwatch.Stop();

            Console.WriteLine("\n\nSeřazené pole pomocí Comb sort:");
            for(int i = 0; i < n; i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine("\n\nCas Comb sort: {0}", myStopwatch.Elapsed);


            //SHELL SORT
            myStopwatch.Reset();
            myStopwatch.Start();
            
            int gapShell = n / 2; //inicializace gapu, zacne s polovinou pole

            while(gap > 0){ //dokud je gap vetsi jak 0, tak sortuju
                for (int i = gapShell; i < n; i++){ //pro kazdy prvek v poli od gapu do konce
                    int tmp = myArray[i];
                    int j;
                
                for(j = i; j >= gapShell && myArray[j - gapShell] < tmp; j -= gapShell){ //posunu prvky, ktere jsou vetsi nez tmp, na jednu pozici doprava
                    myArray[j] = myArray[j - gapShell];
                } 
                myArray[j] = tmp; //nastav tmp na j-te pozici
                }
                gapShell = gapShell / 2; //zmensuju gap
                break;
            }
            myStopwatch.Stop();

            Console.WriteLine("\n\nSerazene pole pomoci Shell sort: ");
            for (int i = 0; i < n; i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine("\n\nCas Shell sort: {0}", myStopwatch.Elapsed);


            //opakovani programu - TO-DO
            Console.WriteLine("\n\npro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}