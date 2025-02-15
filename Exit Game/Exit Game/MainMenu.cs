using System;
using System.Diagnostics.Metrics;
using System.Threading;
using Text_adventures;

class MainMenu
{
    static void Main()
    {
        Console.Title = "𝐌𝐀𝐌𝐄𝐃 𝐗 𝐄𝐍𝐃𝐄𝐑 [REINCARNATED AS A POWERFULL WARRIOR]";

        string rasse = "";
        string ability = "";


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
███╗░░░███╗░█████╗░███╗░░░███╗███████╗██████╗░	██╗░░██╗	███████╗███╗░░██╗██████╗░███████╗██████╗░
████╗░████║██╔══██╗████╗░████║██╔════╝██╔══██╗	╚██╗██╔╝	██╔════╝████╗░██║██╔══██╗██╔════╝██╔══██╗
██╔████╔██║███████║██╔████╔██║█████╗░░██║░░██║	░╚███╔╝░	█████╗░░██╔██╗██║██║░░██║█████╗░░██████╔╝
██║╚██╔╝██║██╔══██║██║╚██╔╝██║██╔══╝░░██║░░██║	░██╔██╗░	██╔══╝░░██║╚████║██║░░██║██╔══╝░░██╔══██╗
██║░╚═╝░██║██║░░██║██║░╚═╝░██║███████╗██████╔╝	██╔╝╚██╗	███████╗██║░╚███║██████╔╝███████╗██║░░██║
╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═════╝░	╚═╝░░╚═╝	╚══════╝╚═╝░░╚══╝╚═════╝░╚══════╝╚═╝░░╚═╝
");

        Thread.Sleep(1000);
        Console.Clear();


        Console.WriteLine("wähle deine Rasse.");
        Console.WriteLine("(1) ELF");
        Console.WriteLine("(2) DEMI");
        Console.WriteLine("(3) MENSCH");
        Console.WriteLine("(4) GOBLIN");
        string eingabe = Console.ReadLine();

        switch (eingabe)
        {
            case "1":
                rasse = "Elf";
                break;
            case "2":
                rasse = "Demi";
                break;
            case "3":
                rasse = "Mensch";
                break;
            case "4":
                rasse = "Goblin";
                break;
        }
        Console.WriteLine($"Deine Rasse ist nun {rasse}");
        Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine("wähle deine ability");
        Console.WriteLine("(1) Feuer");
        Console.WriteLine("(2) Blitz");
        Console.WriteLine("(3) Erde");
        Console.WriteLine("(4) Wasser");
        string eing = Console.ReadLine();
        switch (eing)
        {
            case "1":
                ability = "Feuer";
                break;
            case "2":
                ability = "Blitz";
                break;
            case "3":
                ability = "Erde";
                break;
            case "4":
                ability = "Wasser";
                break;
        }
        Console.WriteLine($"Deine Ability ist nun {ability}");
        Thread.Sleep(3000);
        Console.ResetColor();


        while (true)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║      MAIN MENU                 ║");
            Console.WriteLine("╠════════════════════════════════╣");
            Console.WriteLine("║  (1) Story Starten             ║");
            Console.WriteLine("║  (2) Level                     ║");
            Console.WriteLine("║  (3) Stats                     ║");
            Console.WriteLine("║  (4) Exit                      ║");
            Console.WriteLine("║                                ║");
            Console.WriteLine("╚════════════════════════════════╝");
            Console.WriteLine($"Rasse: {rasse} Ability: {ability}");

            Console.ResetColor();
            Console.Write("Deine Wahl: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                StoryFunktion.StartStory();
            }
            else if (input == "2")
            {
                LevelFunktion.LevelSystem();
            }
            else if (input == "3")
            {
            }
            else if (input == "4")
            {
                ExitFunktion.Exit();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nUngültige Eingabe! Bitte erneut versuchen.");
                Console.ResetColor();
            }
        }
    }
}