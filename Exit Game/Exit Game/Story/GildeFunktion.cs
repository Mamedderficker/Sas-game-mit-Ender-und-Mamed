using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exit_Game.Story
{
    class GildeFunktion
    {
        static string gildenName = "";
        static bool istInGilde = false;

        public static void GildeVerwalten()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════");
            Console.WriteLine("       GILDEN-MANAGEMENT");
            Console.WriteLine("═══════════════════════════════");

            if (istInGilde)
            {
                Console.WriteLine($"Du bist Mitglied der Gilde: {gildenName}");
                Console.WriteLine("(1) Gilde verlassen");
            }
            else
            {
                Console.WriteLine("(1) Neue Gilde gründen");
                Console.WriteLine("(2) Einer bestehenden Gilde beitreten");
            }
            Console.WriteLine("(3) Zurück zum Hauptmenü");
            Console.Write("\nDeine Wahl: ");

            string eingabe = Console.ReadLine();

            if (eingabe == "1" && !istInGilde)
            {
                Console.Write("Gib den Namen deiner neuen Gilde ein: ");
                gildenName = Console.ReadLine();
                istInGilde = true;
                Console.WriteLine($"🎉 Du hast die Gilde '{gildenName}' gegründet!");
            }
            else if (eingabe == "2" && !istInGilde)
            {
                Console.WriteLine("🔍 Du suchst nach einer Gilde...");
                Thread.Sleep(2000);
                string[] gildenListe = { "Königsritter", "Drachenjäger", "Magierbund", "Dunkle Garde" };
                gildenName = gildenListe[new Random().Next(gildenListe.Length)];
                istInGilde = true;
                Console.WriteLine($"✅ Du bist jetzt Mitglied der Gilde: {gildenName}!");
            }
            else if (eingabe == "1" && istInGilde)
            {
                Console.WriteLine($"🚪 Du hast die Gilde '{gildenName}' verlassen.");
                istInGilde = false;
                gildenName = "";
            }

            Thread.Sleep(2000);
        }

    }
}
