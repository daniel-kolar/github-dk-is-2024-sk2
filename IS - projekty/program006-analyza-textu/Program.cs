﻿using System;
using System.Collections.Concurrent;
using System.Net.Security;
using System.Reflection;

class Vypis_rady{
    static void Main(){
        
        //chci aby se program opakoval po stisku klavesy a
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("******** Analyza textu *********");
            Console.WriteLine("*****************************");
            Console.WriteLine("******** Daniel Kolář *******");
            Console.WriteLine("*****************************\n"); //\n new line nebo console.writeline()
            Console.WriteLine();

            //vstup od uzivatele - lepsi varianta
            Console.Write("\nZadejte text pro analyzu: ");
            string myText = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(myText); //vypise zadany text
            Console.WriteLine(myText[0]); //vypise prvni char textu
            Console.WriteLine(myText.Length); //vypise delku textu
            Console.WriteLine(myText[myText.Length-1]); //vypise posledni char

            int pocetSamohlasky = 0;
            int pocetSouhlasky = 0;
            int pocetCislice = 0;
            int pocetZnaky = 0;


            //TO-DO: opravit + dodelat domaci ukol
            /*foreach(char znak in myText){
                if(souhlasky.Contains(znak)){
                    pocetSouhlasky++;
                } else if (samohlasky.Contains(znak)){
                    pocetSamohlasky++;
                } else if (cislice.Contains(znak)){
                    pocetCislice++;
                } else pocetZnaky++;
            }*/

            
            Console.WriteLine("\n\nPocet samohlasek: [0]", pocetSamohlasky);
            Console.WriteLine("\n\nPocet souhlasek: [0]", pocetSouhlasky);
            Console.WriteLine("\n\nPocet samohlasek: [0]", pocetCislice);
            Console.WriteLine("\n\nPocet samohlasek: [0]", pocetZnaky);


            //opakovani programu - TO-DO
            Console.WriteLine("pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}