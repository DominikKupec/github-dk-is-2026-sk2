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
    Console.WriteLine("**********************Ciferný součet**********************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("***********************Dominik Kupec**********************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("**********************************************************");
    
    
    //vstup počáteční hodnoty - správně řešený
    Console.Write("zadejte celé číslo: ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte celé číslo znovu; ");
    }


    //vstup koncové hodnoty - správně řešený
  

    // rekapitulace zadaných hodnot 
    Console.WriteLine();
    Console.WriteLine("================================");

    
    //vypis zadaných hodnot do jednoho řádku
    Console.WriteLine($"První číslo: {number};");
    Console.WriteLine("================================");
    Console.WriteLine();
    
    // 1. příprava pomocných proměnných pro výpočet
    int numberBackup = number; //záloha původního čísla pro závěrečný výpis 
    int sum = 0;               //neutrální hodnotou pro sčítání je 0 
    int digit;  
    int soucin = 1;               //proměnná pro uložení právě zpracovávané číslice

    // 2. ošetření záporných čísel (znaménko nemá vliv na součet cifer)
    if (number < 0)
    {
        number = -number;
    }

    // 3. zvláštní případ
    if (number == 0)
    {
        sum = 0;
    }
    else
    {
        
        Console.WriteLine("průběh rozkladu čísla na jednotlivé číslice (z prava do leva)");

        // jádro problému - matematiký rozklad čísla pomocí cyklu
        while (number > 0)
        {
           for (; number > 0; number = number / 10){ 
            //operátoru % se říká modulo a slouží k určení zbytku po celočíselném dělení
            digit = number % 10;  //modulo 10 nám získá poslední číslici
            sum = sum + digit;    //přičtení číslice k celkovému součtu
            
            soucin = soucin * digit;

           // Console.WriteLine($"aktuální číslice (zbytek): {digit}");
           // Console.WriteLine($"číslo po odříznutí aktuální číslice: {number}");
           // Console.WriteLine($"aktuální hodnota ciferného součtu: {sum}");
        }  
        }  
    }

    // 5. výpis výsledků
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine($"Ciferný součet čísla {numberBackup} je: {sum}");
    Console.WriteLine($"Součin číslic čísla {numberBackup} je: {soucin}");
    Console.WriteLine("================================");
    Console.WriteLine();

    
        //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesu programu ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete spustit program znovu? ");
    again = Console.ReadLine() ?? "";
}
