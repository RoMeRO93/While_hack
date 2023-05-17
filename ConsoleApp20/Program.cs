using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numar1;
        double numar2;
        int numar3;
       int x;
        numar1 = 30;
        numar2 = 5;
        numar3 = 20;

        if ((numar1 == 10 && numar2 == 2) || numar3 == 20)
        {
            // acest code
            Console.WriteLine("ADEVARAT");
        }
        else
        {
            Console.WriteLine("FALS");
        }
        while (numar1 < 20)
        { Console.WriteLine(numar1);
            numar1 = numar1 + 3;
            Console.WriteLine(numar1);
        }
        for (int i = 0; i < numar2; i++)
        { Console.WriteLine(i);
        }
        x = 0;
        Console.WriteLine("Acum ruleaza WHILE:");
        while (x< numar2)
        { Console.WriteLine(x);
           x= x + 1; 
            for (int contor = 0; x<20 ; contor++)  
                Console.Write(contor);
        }
        Console.WriteLine("TERMINAT");
    }
    
}
