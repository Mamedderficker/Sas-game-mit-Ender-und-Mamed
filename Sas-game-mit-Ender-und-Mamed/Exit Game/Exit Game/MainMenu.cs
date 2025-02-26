using System;
using System.Diagnostics.Metrics;
using System.Threading;
using Text_adventures.Story;
using Text_adventures;
using System.Net.NetworkInformation;

class MainMenu

{
    static void Main()
    {
        bool SkipStart = false;
        Console.Title = "𝐌𝐀𝐌𝐄𝐃 𝐗 𝐄𝐍𝐃𝐄𝐑 [REINCARNATED AS A POWERFULL WARRIOR]";

        string rasse = "";
        string ability = "";
        string eingabe = "";


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

        do
        {
            Console.WriteLine("Wähle deine Rasse.");
            Console.WriteLine("(1) ELF");
            Console.WriteLine("(2) DEMI");
            Console.WriteLine("(3) MENSCH");
            Console.WriteLine("(4) GOBLIN");

            eingabe = Console.ReadLine();

            if (eingabe == "1" || eingabe == "2" || eingabe == "3" || eingabe == "4")
            {
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
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ungültige Eingabe!");
            }

        } while (true);

        Console.WriteLine($"Du hast {rasse} gewählt!");

        Console.WriteLine($"Deine Rasse ist nun {rasse}");
        Thread.Sleep(2000);
        Console.Clear();

        do
        {
            Console.Clear(); // Löscht die Konsole bei jeder Eingabe, um eine saubere Darstellung zu haben

            Console.WriteLine("Wähle deine Ability:");
            Console.WriteLine("(1) Feuer");
            Console.WriteLine("(2) Blitz");
            Console.WriteLine("(3) Erde");
            Console.WriteLine("(4) Wasser");

            string eing = Console.ReadLine();

            if (eing == "1")
            {
                ability = "Feuer";
                break;
            }
            else if (eing == "2")
            {
                ability = "Blitz";
                break;
            }
            else if (eing == "3")
            {
                ability = "Erde";
                break;
            }
            else if (eing == "4")
            {
                ability = "Wasser";
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ungültige Eingabe! Bitte wähle eine der angegebenen Zahlen (1-4).");
                Thread.Sleep(1000);
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
                Console.WriteLine("║  (2) Exit                      ║");
                Console.WriteLine("║                                ║");
                Console.WriteLine("╚════════════════════════════════╝");
                Console.WriteLine($"Rasse: {rasse} Ability: {ability}");

                Console.ResetColor();
                Console.Write("Deine Wahl: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    StoryFunktion.StartStory(ref SkipStart);
                }
                else if (input == "2")
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
        } while (true);
    }
}
