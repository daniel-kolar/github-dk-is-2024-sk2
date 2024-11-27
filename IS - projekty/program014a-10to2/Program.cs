using System;
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
            Console.Write("zadejte celé číslo, které chcete převest do binárního soustavy: ");
            int decimalNumber;
            while(!int.TryParse(Console.ReadLine(), out decimalNumber)){
                Console.WriteLine("Nezadali jste cele cislo. Zadejte znovu celé číslo, které chcete převest do binárního soustavy: ");
            }

            //jenom teoreticky "nacrt" jak to asi bude fungovat
            int[] binary = new int[decimalNumber];

            if(decimalNumber / 2 == 0){
                binary [0] += 0;
            }
            if(decimalNumber / 2 != 0){
                binary[0] += 1;
            }

            Console.Write("{0} v binární soustavě je: ", decimalNumber);
            Console.Write("{0} ", binary[0]);


            /* jen pro ukazku a testovani
            string binary = "101010";
            int number = Convert.ToInt32(binary, 2);
            Console.WriteLine(number);*/

            //opakovani programu - TO-DO
            Console.WriteLine("pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}