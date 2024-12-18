﻿using System;
using System.Collections.Concurrent;
using System.Formats.Asn1;
using System.Reflection;
using System.Threading.Tasks.Dataflow;

class Vypis_rady{
    static void Main(){
        
        //chci aby se program opakoval po stisku klavesy a
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("********** Obrazce **********");
            Console.WriteLine("*****************************");
            Console.WriteLine("******** Daniel Kolář *******");
            Console.WriteLine("*****************************\n"); //\n new line nebo console.writeline()
            Console.WriteLine();

            //vstup od uzivatele - lepsi varianta
            Console.Write("zadejte velikost vypsaneho obrazce: ");
            int velikost;
            while(!int.TryParse(Console.ReadLine(), out velikost)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu celé číslo: ");
            }

            if(velikost < 0){
                Console.WriteLine("Prosim zadejte kladnou hodnotu (velikost obrazce muze byt pouze kladna)");
                goto opakovani;
            }

            //System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));

            //vykreslovaní obrazců - Šachovnice
            Console.WriteLine("\nŠachovnice");
            for (int i = 0; i < velikost; i++){
                for (int j = 0; j < velikost; j++){
                    if ((i + j) % 2 == 0){ //vypisuju jenom sude souradnice
                        Console.Write("* ");
                    } else Console.Write("  ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(10));
                }
            Console.WriteLine();
            }

            Console.WriteLine("\n\n=====================================");
            Console.WriteLine("===========Další obrázek=============");
            Console.WriteLine("=====================================\n\n");

            //vykreslení obrazců - kříž
            Console.WriteLine("\nKříž");
            for (int i = 0; i < velikost; i++){
                for (int j = 0; j < velikost; j++){
                    if(i == 0 || i == velikost - 1 || j == 0 || j == velikost - 1){ //okraj
                        Console.Write("* ");
                    } else if(i == velikost / 2 || j == velikost / 2){ //kriz
                        Console.Write("* ");
                    } else Console.Write("  ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(10));
                }
            Console.WriteLine();
            }

            Console.WriteLine("\n\n=====================================");
            Console.WriteLine("===========Další obrázek=============");
            Console.WriteLine("=====================================\n\n");

            //vykreslení obrazců - pismeno Z
            Console.WriteLine("\nPismeno Z");
            for(int i = 0; i < velikost + 1; i++){
                for(int j = 0; j < velikost + 1; j++){
                    if(Math.Abs(i - velikost) + Math.Abs(j - velikost) == velikost){ //diagonala
                        Console.Write("* ");
                    } else if(i == 0 || i == velikost){ //vyrsek a spodek
                        Console.Write("* ");
                    } else Console.Write("  ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(10));
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n=====================================");
            Console.WriteLine("===========Další obrázek=============");
            Console.WriteLine("=====================================\n\n");

            //vykreslení obrazců - N
            Console.WriteLine("\nPismeno N");
            for(int i = 0; i < velikost; i++){
                for(int j = 0; j < velikost; j++){
                    if(i == j){
                        Console.Write("* ");
                    } else if(j == 0 || j == velikost-1){
                        Console.Write("* ");
                    } else Console.Write("  ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(10));
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n=====================================");
            Console.WriteLine("===========Další obrázek=============");
            Console.WriteLine("=====================================\n\n");
            
            //vykreslení obrazců - hvezda
            Console.WriteLine("\nhvezda");
            for(int i = 0; i < velikost + 1; i++){
                for(int j = 0; j < velikost + 1; j++){
                    if(i == j){ //diagonaly
                        Console.Write("* ");
                    } else if(i == velikost / 2 || j == velikost / 2){
                        Console.Write("* ");
                    } else if(Math.Abs(i - velikost) + Math.Abs(j - velikost) == velikost){
                        Console.Write("* ");
                    } else Console.Write("  ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(10));
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n=====================================");
            Console.WriteLine("=====================================");
            Console.WriteLine("=====================================\n\n");

            

            //opakovaní programu
            opakovani:
                Console.WriteLine("\n\npro opakovani programu stisknete klavesu a");
                again = Console.ReadLine();
        }
    }
}