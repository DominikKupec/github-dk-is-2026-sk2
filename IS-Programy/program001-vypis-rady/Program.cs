//jednořádkový komentář

/* toto
    je
    víceřádkový
    komentář
*/


//jako první si přpravýme smyčku pro opakování programu.

 string again = "a";
 //ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávaní "a" tak i "A"
while (again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("**********************************************************");
    Console.WriteLine("************************vypis rady************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("***********************Dominik Kupec**********************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("**********************************************************");
    
    //vstup počáteční hodnoty - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());
    
    //vstup počáteční hodnoty - správně řešený
    Console.Write("Zadejte první číslo řady(celé číslo): ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první číslo řady znovu (celé číslo): ");
    }


    //vstup koncové hodnoty - správně řešený
    Console.Write("Zadejte poslední číslo řady(celé číslo): ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte poslední číslo řady znovu (celé číslo): ");
    }


    //vstup diference s kontrolou kladné hodnoty
    Console.Write("Zadejte diferenci (kladné celé číslo): "); 
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Diference musí být kladné celé číslo! Zadejte diferenci znovu (kladné celé číslo): ");
    }


    // rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("================================");
    //vypis zadaných hodnot pod sebou
    //Console.WriteLine($"Prvni číslo: {first}");
    //Console.WriteLine($"Poslední číslo: {last}");
    //Console.WriteLine($"Diference(krok): {step}");
    
    
    //vypis zadaných hodnot do jednoho řádku
    Console.WriteLine($"První číslo: {first}; Poslední číslo: {last}; Diference(krok): {step}");
    Console.WriteLine("================================");
    Console.WriteLine();

    //jádro algoritmu pro výpis řady
    Console.WriteLine("Výpis číselné řady: ");
    
    if(first <= last)
    {
        int current = first;
        while(current <= last){
            //čísla řady vypsaná pod sebou
            Console.WriteLine(current);
            //čísla řady vypsaná vedle sebe
            Console.Write($"{current};");
            //current = current + step;
            // předchozí řádek lze napsat stručněji
            current += step;

        }  

    }
    else
    {
        Console.WriteLine("Řadu nelze vypsat!");
        Console.WriteLine("První číslo je větší než poslední.");
        Console.WriteLine("Tento program umí vypsat pouze vzestuupnou řadu (od menšího k většímu).");

    }


    //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesu programu ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete spustit program znovu? ");
    again = Console.ReadLine() ?? "";
}
