string opakovani = "a";

  while (opakovani == "a")
  {
    Console.Clear();
    Console.WriteLine("******************************");  
    Console.WriteLine("** Zápočtový test IS **");
    Console.WriteLine("** 14.1.2025 **");
    Console.WriteLine("** Daniel Kolář **");
    Console.WriteLine("******************************");  
    
    Console.Write("\nKolik chcete generovat náhodných čísel? ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n))
      Console.Write("Zadejte znovu počet generovaných čísel: ");

    Console.Write("Zadejte dolní mez intervalu: ");
    int dm;
    while(!int.TryParse(Console.ReadLine(), out dm))
      Console.Write("Zadejte znovu dolní mez intervalu:");

    Console.Write("Zadejte horní mez intervalu: ");
    int hm;
    while(!int.TryParse(Console.ReadLine(), out hm))
      Console.Write("Zadejte znovu horní mez intervalu:");

    Console.WriteLine("\n\nPočet čísel={0}; dolní mez={1}; horní mez={2}",n,dm,hm);

    int[] myArray = new int[n];  

    Random randomNumber = new Random();  

    int soucetCisel = 0;
    int maximum = 0;
    int minimum = 0;

    for(int i=0;i<n;i++)
      {
        myArray[i] = randomNumber.Next(dm, hm+1);
        soucetCisel += myArray[i];
        Console.Write("{0}; ", myArray[i]);
        if(myArray[i] < minimum){
            minimum = myArray[i];
        } else if (myArray[i] > maximum){
            maximum = myArray[i];
            }
      }

      Console.WriteLine("\n\nMaximum: {0}", maximum);
      Console.WriteLine("Minimum: {0}", minimum);


      //MAXIMA A MINIMA A POLOHY  
      int maxValue = 0;
      List<int> maxIndices = new List<int>();

      for(int i = 0; i < n; i++){
        if (myArray[i] > maxValue) {
            maxValue = myArray[i];
            maxIndices.Clear();
            maxIndices.Add(i);
      } else if (myArray[i] == maxValue) {
            maxIndices.Add(i);
        }
      }
      Console.WriteLine("\nPozice maxima v Poli:");
      foreach (int index in maxIndices){
        Console.Write("{0}, ", index);
      }

      int minValue = 0;
      List<int> minIndices = new List<int>();

      for(int i = 0; i < n; i++){
        if (myArray[i] < minValue) {
            minValue = myArray[i];
            minIndices.Clear();
            minIndices.Add(i);
      } else if (myArray[i] == minValue) {
            minIndices.Add(i);
        }
      }
      Console.WriteLine("\nPozice minima v Poli:");
      foreach (int index in minIndices){
        Console.Write("{0}, ", index);
      }

    /*
    //SHELL SORT
    int gap = n / 2;
    while(gap > 0){
        for (int i = gap; i < n; i++) {
            int temp = myArray[i];
            int j;
            for (j = i; j > gap && myArray[j - gap] < temp; j-=gap){
                myArray[j] = myArray[j - gap];
            }
            myArray[i] = temp;
        }
        gap = gap / 2;
        break;
    }*/

    //bubblesort
    for(int i = 0; i < n - 1; i++){
        for (int j = 0; j < n - i - 1; j++){
            if (myArray[j] < myArray[j + 1]) {
                int temp = myArray[j];
                myArray[j] = myArray[j+1];
                myArray[j+1] = temp;
            }
        }
    }

    //3. cisla
    int first = 0;
    int second = 0;
    int third = 0;
    int forth = 0;
    int fifth = 0;

    for(int i = 0; i < n; i++){
        int currentNum = myArray[i];
        if(currentNum == first || currentNum == second || currentNum == third || currentNum == forth || currentNum == fifth){
            continue;
        }
        if (currentNum > first){
            fifth = forth;
            forth = third;
            third = second;
            second = first;
            first = currentNum;
        } else if (currentNum > second){
            fifth = forth;
            forth = third;
            third = second;
            second = currentNum;
        } else if (currentNum > third){
            fifth = forth;
            forth = third;
            third = currentNum;
        } else if (currentNum > forth){
            fifth = forth;
            forth = currentNum;
        } else if (currentNum > fifth){
            fifth = currentNum;
        }
    }

    Console.WriteLine("\n\nPrvni cislo: {0}", first);
    Console.WriteLine("Druhe cislo: {0}", second);
    Console.WriteLine("Treti cislo: {0}", third);
    Console.WriteLine("Ctvrte cislo: {0}", forth);
    Console.WriteLine("Pate cislo: {0}", fifth);

    Console.WriteLine("\n\nseřazene pole pomoci shellsort:");
    for(int i = 0; i < n; i++){
        Console.Write("{0}, ", myArray[i]);
    }

    //soucet a soucin cifer u maxima
    if(first > 0){
        int sum = 0;
        int product = 1;
        int max = first;
        while(max > 0){
            int digit = max % 10;
            sum += digit;
            product *= digit;
            max /= 10;
        }
        //vypsani soucet a soucin cifer u maxima
    Console.WriteLine("\n\nSoucet cifer u maxima: {0}", sum);
    Console.WriteLine("Soucin cifer u maxima: {0}", product);
    } else {
        Console.WriteLine("Nejvetsi cislo v rade je 0.");
    }

    //aritmeticka posloupnost - vypis prvku a soucet zobrazenych prvku (prvni prvek = druhe nejvetsi cislo, diference = pate nejvetsi cislo, pocet prvku = 10)
    int[] sequence = new int[10];
    int count = 0;
    int diff = fifth;
    int secondMax = second;
    int soucetPrvku = second;
    sequence[0] = secondMax;
    for(int i = 1; i < 10; i++){
        sequence[i] = sequence[i - 1] + diff;
        count++;
        soucetPrvku += sequence[i];
    }

    //vypis aritmeticke posloupnosti a souctu jejich prvku
    Console.WriteLine("\n\nAritmeticka posloupnost: ");
    for(int i = 0; i < 10; i++){
        Console.Write("{0}, ", sequence[i]);
    }
    Console.WriteLine("\nSoucet prvku v posloupnosti: {0}", soucetPrvku);

    //vykresleni castecne vyplneneho (skoro) čtverce - výška = třetí největší číslo řady; nad úhlopříčkou bude čtverec vyplněný, pod úhlopříčkou bude čtverec částěčně vyplněný nebude. Okraje budou taky vyplněny
    int height = third;
    Console.WriteLine("\n\nCastecne vyplnene ctverce:");
    for(int i = 0; i < height; i++){
        for(int j = 0; j < height; j++){
            /*if(i == j || i == 0 || i == height - 1 || j == 0 || j == height - 1){
                Console.Write(" * ");
            } */
            if(i == j){
                Console.Write(" * ");
            } else if (i == 0 || j == 0){
                Console.Write("* ");
            } else if (i == height - 1 || j == height - 1){
                Console.Write("* ");
            }
            else{
                if(i < j){
                    Console.Write("0 ");
                }
                else{
                    Console.Write("  ");
                }
            }
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(10));
        }
        Console.WriteLine();
    }


    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    opakovani=Console.ReadLine();
  
  }