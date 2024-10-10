using System;

class Vypis_rady{
    static void Main(){
        
        //chci aby se program opakoval po stisku klavesy a
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("******** Výpis řady *********");
            Console.WriteLine("*****************************");
            Console.WriteLine("******** Daniel Kolář *******");
            Console.WriteLine("*****************************\n"); //\n new line nebo console.writeline()
            Console.WriteLine();

            //vstup od uzivatele - spatna varianta
                //Console.Write("zadejte prvni cislo rady: ");
                //int first = int.Parse(Console.ReadLine());

            //vstup od uzivatele - lepsi varianta
            Console.Write("zadejte první celé číslo řady: ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu první celé číslo řady: ");
            }

            Console.Write("zadejte posledni celé číslo řady: ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu posledni celé číslo řady: ");
            }

            Console.Write("zadejte diferenci (cele cislo) řady: ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu  diferenci (cele cislo) řady: ");
            }

            //vypis uzivatelskeho vstupu
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine("Prvni cislo řady: {0}", first);
            Console.WriteLine("Posledni cislo řady: {0}", last);
            Console.WriteLine("Difirence: {0}", step);
            Console.WriteLine();


            //logika pro vypis z rady - TO-DO


            //opakovani programu - TO-DO
            Console.WriteLine("pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}