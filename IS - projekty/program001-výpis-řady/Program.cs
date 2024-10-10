using System;

class Vypis_rady{
    static void Main(){
        
        //chci aby se program opakoval po stisku klavesy a
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("********Výpis řady***********");
            Console.WriteLine("*****************************");
            Console.WriteLine("********Daniel Kolář*********");
            Console.WriteLine("*****************************\n"); //\n new line nebo console.writeline()
            Console.WriteLine();

            //vstup od uzivatele - TO-DO
            

            //logika pro vypis z rady - TO-DO


            //opakovani programu - TO-DO
            Console.WriteLine("pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}