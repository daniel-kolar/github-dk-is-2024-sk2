using System;
using System.Diagnostics;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*********************************");
            Console.WriteLine("******** Výpočet PI a ln 2 ********");
            Console.WriteLine("**********************************");
            Console.WriteLine("********* Daniel Kolář **********");
            Console.WriteLine("*********************************");
            Console.WriteLine();

            Console.Write("Zadejte přesnost (reálné číslo - čím menší hodnota, tím přesnější): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)) {
                Console.Write("Nezadali jste reálné číslo správně, zadejte přesnost znovu: ");
            }

            //π
            double i = 1;
            double piCtvrt = 1;
            double znamenko = 1;

            while((1 / i) >= presnost){
                i = i + 2;
                znamenko = -znamenko;
                piCtvrt = piCtvrt + znamenko * (1 / i);

                if(znamenko == 1){
                    Console.WriteLine("+1/{0}; hodnota PI = {1}", i, 4 * piCtvrt);
                } else {
                    Console.WriteLine("-1/{0}; hodnota PI = {1}", i, 4 * piCtvrt);
                }
            }

            Console.WriteLine("Hodnota PI = {0}", 4 * piCtvrt);
            //Console.WriteLine("Hodnota PI = {0:f4}", 4 * piCtvrt);


            //Ln (2)
            double j = 1;
            double ln2 = 1;
            double znamenko2 = 1;

            while((1 / j) >= presnost){
                j++;
                znamenko2 = - znamenko2;
                ln2 = ln2 + znamenko2 * (1 / j);

                if(znamenko2 == 1){
                    Console.WriteLine("+1/{0}; hodnota ln(2) = {1}", j, ln2);
                } else {
                    Console.WriteLine("-1/{0}; hodnota ln(2) = {1}", j, ln2);
                }
            }

            Console.WriteLine("Hodnota ln(2) = {0}", ln2);


            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();

        }

    }
}    