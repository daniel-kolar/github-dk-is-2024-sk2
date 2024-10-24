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
            Console.WriteLine("*** Pravouhly trojuhelnik ***");
            Console.WriteLine("*****************************");
            Console.WriteLine("******** Daniel Kolář *******");
            Console.WriteLine("*****************************\n"); //\n new line nebo console.writeline()
            Console.WriteLine();

            //vstup od uzivatele - spatna varianta
                //Console.Write("zadejte prvni cislo rady: ");
                //int first = int.Parse(Console.ReadLine());

            //vstup od uzivatele - lepsi varianta
            Console.Write("zadejte delku strany odvesny pravouhleho trojuhelniku (cele cislo): ");
            int odvesna;
            while(!int.TryParse(Console.ReadLine(), out odvesna)){
                Console.WriteLine("Nezadali jste delku strany odvesny pravouhleho trojuhelniku. Zadejte znovu delku strany odvesny pravouhleho trojuhelniku: ");
            }

            Console.WriteLine();
            for(int i = 1; i <= odvesna; i++){
                for(int j = 1; j <= i; j++){
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                }
                Console.WriteLine();
            }
            


    
            //opakovani programu - TO-DO
            Console.WriteLine("pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}