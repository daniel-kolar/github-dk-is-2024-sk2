﻿using System;
using System.Collections.Concurrent;
using System.Reflection;

class Vypis_rady{
    static void Main(){
        
        //chci aby se program opakoval po stisku klavesy a
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("******** Převod do binaru *********");
            Console.WriteLine("**********************************");
            Console.WriteLine("********** Daniel Kolář **********");
            Console.WriteLine("**********************************\n"); //\n new line nebo console.writeline()
            Console.WriteLine();

            //vstup od uzivatele - lepsi varianta
            Console.Write("zadejte celé číslo, které chcete převest do vámi zadané soustavy: ");
            int decimalNumber;
            while(!int.TryParse(Console.ReadLine(), out decimalNumber)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu celé číslo, které chcete převest do binárního soustavy: ");
            }

            Console.Write("Zadejte soustavu do které chcete převádět: ");
            int baseNumber;
            while(!int.TryParse(Console.ReadLine(), out baseNumber)){
                Console.WriteLine("Nezadali jste cele cislo soustavy. Zadejte znovu cele cislo soustavy: ");
            }

            Console.Write("{0} v/ve {1} soustavě je: ", decimalNumber, baseNumber);

            //Prevod do binarni soustavy a ulozeni do pole
            int [] anyArray = new int[100]; //pole pro 100 bitů
            int index = 0;

            if(decimalNumber == 0){
                anyArray[index++] = 0;
            } else{
                while(decimalNumber > 0){
                    anyArray[index++] = decimalNumber % baseNumber; //přídání zbytku z dělení na začátek
                    decimalNumber /= baseNumber; //dělení čísla 2                
               }
           }

            for(int i = index - 1; i >= 0; i--){ //vypis pole pozpatku
                Console.Write(anyArray[i]);
                if(baseNumber == 2){
                    if(i % 4 == 0){
                        Console.Write(" ");
                    }
                } else if(i % 3 == 0){
                    Console.Write(" ");
                }    
            } 
            


            /* jen pro ukazku a testovani
            string binary = "101010";
            int number = Convert.ToInt32(binary, 2);
            Console.WriteLine(number);*/

            //opakovani programu - TO-DO
            Console.WriteLine("\n\npro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}