using System;
using System.Collections.Concurrent;
using System.Reflection;

class Obdelnik{
    static void Main(){
        
        //chci aby se program opakoval po stisku klavesy a
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("********* Obdelnik **********");
            Console.WriteLine("*****************************");
            Console.WriteLine("******** Daniel Kolář *******");
            Console.WriteLine("*****************************\n"); //\n new line nebo console.writeline()
            Console.WriteLine();

            //vstup od uzivatele - spatna varianta
                //Console.Write("zadejte prvni cislo rady: ");
                //int first = int.Parse(Console.ReadLine());

            //vstup od uzivatele - lepsi varianta
            Console.Write("zadejte sirku obrazce (cele cislo): ");
            int sirka;
            while(!int.TryParse(Console.ReadLine(), out sirka)){
                Console.WriteLine("Nezadali jste sirku obdelniku. Zadejte znovu sirku obdelniku: ");
            }

            Console.Write("zadejte delku obrazce (cele cislo): ");
            int delka;
            while(!int.TryParse(Console.ReadLine(), out delka)){
                Console.WriteLine("Nezadali jste delku obdelniku. Zadejte znovu delka obdelniku: ");
            }
            Console.WriteLine();
            for(int i = 1; i <= delka; i++){
                for(int j = 1; j <= sirka; j++){
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                }
            Console.WriteLine();
            }
            Console.WriteLine();

            /*int j = 1; - while ukazka v porovnani s for
            while(j <= 10){
                Console.WriteLine("*");
                j++;
            }*/


            int obsah = sirka * delka;
            Console.WriteLine("\nobsah obdelniku se stranami {0} a {1} je {2}", sirka, delka, obsah);

            //opakovani programu - TO-DO
            Console.WriteLine("pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}