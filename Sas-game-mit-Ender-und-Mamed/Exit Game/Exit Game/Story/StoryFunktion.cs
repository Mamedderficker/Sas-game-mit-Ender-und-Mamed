using System;
using System.Security.Principal;
using System.Threading;
using Text_adventures.Story;

namespace Text_adventures.Story

{
    class StoryFunktion
    {

        static string playerName = "Held";
        static string klasse = "";
        static string grimoar = "Unbekannt";

        public static void StartStory(ref bool SkipStart)
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            if (SkipStart == false)
            {
                SkipStart = true;
                Console.WriteLine(SkipStart);
                Console.WriteLine("??? : 'Ah... deine Seele ist endlich hier angekommen.'");
                Thread.Sleep(2000);
                Console.WriteLine("??? : 'Willkommen in der Zwischenwelt, sterblicher Wanderer.'");
                Thread.Sleep(2000);
                Console.ResetColor();

                Console.Write("Gott: 'Sag mir, wie lautet dein Name?' ");
                playerName = Console.ReadLine();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Gott: 'Also, {playerName}, du bist gestorben, aber ich gebe dir eine zweite Chance.'");
                Console.WriteLine("Gott: 'Wähle deine neue Bestimmung in der anderen Welt!'");
                Console.WriteLine("1) Krieger 🗡️");
                Console.WriteLine("2) Magier 🔥");
                Console.ResetColor();
                Console.Write("Deine Wahl: ");
                string wahl = Console.ReadLine();

                if (wahl == "1")
                {
                    klasse = "Krieger";
                    Console.WriteLine("\nGott: 'Du wirst als mächtiger Krieger mit übernatürlicher Stärke wiedergeboren!'");
                }
                else
                {
                    klasse = "Magier";
                    Console.WriteLine("\nGott: 'Du wirst als legendärer Magier mit der Fähigkeit, die Elemente zu beherrschen, wiedergeboren!'");
                }

                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Gott: 'Jetzt geh... und werde der stärkste Kämpfer der Welt!'");
                Console.WriteLine("*Dein Körper wird von magischem Licht umhüllt...*");
                Thread.Sleep(4000);
                Console.Clear();

                // Reinkarnation
                Console.WriteLine($"*Du wachst auf in einer dunklen Gasse, dein Herz schlägt schnell...*");
                Console.WriteLine($"*Du bist nun ein 18-jähriger {klasse}, bereit für dein Abenteuer!*");
                Thread.Sleep(3000);

                // Laden mit dem Grimoar
                Console.WriteLine("\nDu siehst einen alten, geheimnisvollen Laden vor dir...");
                Console.WriteLine("Ein alter Mann mit silbernen Haaren steht in der Tür.");
                Console.WriteLine("Alter Mann: 'Ahh... du hast das Schicksal in deinen Augen. Komm rein, junger Abenteurer!'");
                Thread.Sleep(3000);

                Console.WriteLine("\nDu trittst ein und siehst ein leuchtendes Buch auf einem Podest...");
                Console.WriteLine("Der Alte: 'Dies ist ein doppel-S Grimoar... eine Legende unter den Magiern und Kriegern.'");
                Console.Write("Nimmst du das Grimoar an? (ja/nein): ");
                string grimoarWahl = Console.ReadLine().ToLower();

                if (grimoarWahl == "ja")
                {
                    grimoar = "Doppel-S Grimoar";
                    Console.WriteLine("\n*Ein mächtiges Leuchten umgibt dich!*");
                    Console.WriteLine("Der Alte: 'Hah! Du hast dein Schicksal akzeptiert!'");
                }
                else
                {
                    Console.WriteLine("\nDer Alte: 'Nun, dann wird dein Weg schwerer sein...'");
                }
                Thread.Sleep(3000);
                Console.Clear();
                OpenWorld();


            }
            else
            {
                OpenWorld();
            }





        }

        static void OpenWorld()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n🌍 Du stehst in einer belebten Stadt. Was möchtest du tun?");
                Console.WriteLine("1) Zur Gilde gehen 🏰");
                Console.WriteLine("2) Die Wildnis erkunden 🌲");
                Console.WriteLine("3) Einen Kampf bestreiten ⚔️");
                Console.WriteLine("4) Dialog mit einer mysteriösen Person führen 🗣️");
                Console.WriteLine("5) Level System");
                Console.WriteLine("6) Stats Verwalten");
                Console.WriteLine("7) Gilde Verwalten");
                Console.WriteLine("8) Beenden ❌");
                Console.ResetColor();
                Console.Write("Deine Wahl: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\n🏰 Du betrittst die große Gildenhalle...");
                        Console.WriteLine("Ein starker Krieger kommt auf dich zu.");
                        Console.WriteLine("Krieger: 'Bist du hier, um der stärkste Kämpfer zu werden?'");
                        Console.WriteLine($"1) 'Ja, ich werde der stärkste {klasse} dieser Welt!'");
                        Console.WriteLine("2) 'Nein, ich bin nur neugierig...'");
                        Console.Write("Antwort: ");
                        string gildenAntwort = Console.ReadLine();
                        if (gildenAntwort == "1") Console.WriteLine("\nKrieger: 'Dann trainiere hart!'");
                        else Console.WriteLine("\nKrieger: 'Hah, du wirst deine Meinung noch ändern!'");
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n🌲 Du betrittst die Wildnis und hörst ein Brüllen...");
                        Console.WriteLine("Ein Goblin springt aus den Büschen!");
                        Console.WriteLine("Was tust du?");
                        Console.WriteLine("1) Kämpfen ⚔️");
                        Console.WriteLine("2) Wegrennen 🏃");
                        Console.Write("Wahl: ");
                        string kampfWahl = Console.ReadLine();
                        if (kampfWahl == "1") Console.WriteLine("\n💥 Du besiegst den Goblin mit Leichtigkeit!");
                        else Console.WriteLine("\n🏃 Du rennst schnell weg und entkommst!");
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("\n⚔️ Ein Herausforderer erscheint! Ein Elf mit einem magischen Schwert.");
                        Console.WriteLine("Elf: 'Lass uns sehen, was du kannst!'");
                        Console.WriteLine($"💥 Du kämpfst gegen den Elf mit deiner Kraft als {klasse}!");
                        Console.WriteLine("*Nach einem epischen Duell siegst du!*");
                        break;

                    case "4":
                        MysteryPersonFunktion.StoryMysteryPerson();
                        break;
                    case "5":
                        LevelFunktion.LevelSystem();
                        break;
                    case "6":

                        break;
                    case "7":
                        Console.Clear();
                        GildeFunktion.GildeVerwalten();
                        break;

                    case "8":
                        Console.WriteLine("\nDanke für's Spielen! Bis zum nächsten Abenteuer! 🏹🔥");
                        return;

                    default:
                        Console.WriteLine("\nUngültige Eingabe. Versuche es erneut.");
                        break;
                }

                Thread.Sleep(3000);
                Console.Clear();
                LevelFunktion.LevelSystem();
            }
        }
    }
}
