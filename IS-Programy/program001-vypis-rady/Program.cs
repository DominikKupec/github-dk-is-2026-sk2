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
    


    //Dotaz na opakování
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter");
    Console.WriteLine("Jakoukoliv jinou klávesu programu ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete spustit program znovu? ");
    again = Console.ReadLine() ?? "";
}
