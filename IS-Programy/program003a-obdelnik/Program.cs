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
    
    
    //vstup počáteční hodnoty - správně řešený
    Console.Write("Zadejte šířku obrazce(celé číslo): ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo! Zadejte šířku obrazce znovu (celé číslo): ");
    }


    //vstup koncové hodnoty - správně řešený
    Console.ResetColor();
    Console.Write("Zadejte výšku obrazce(celé číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo! Zadejte výšku obrazce znovu (celé číslo): ");
    }
    Console.ResetColor();
    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
        }
        Console.WriteLine();
    }


    // rekapitulace zadaných hodnot 
    Console.WriteLine();
    Console.WriteLine("================================");

    
    //vypis zadaných hodnot do jednoho řádku
    Console.WriteLine($"šířka: {width}; výška: {height}; ");
    Console.WriteLine("================================");
    

    //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesu programu ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete spustit program znovu? ");
    again = Console.ReadLine() ?? "";
}
