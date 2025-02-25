using System;
using System.Threading;

namespace Exit_Game.Story
{
    class LevelFunktion
    {
        static int level = 1;
        static int xp = 0;
        static int xpNextLevel = 100;

        public static void LevelSystem()
        {
            while (true) // Schleife für das Level-System Menü
            {
                Console.Clear();
                Console.WriteLine("═══════════════════════════════");
                Console.WriteLine("       LEVEL-SYSTEM");
                Console.WriteLine("═══════════════════════════════");
                Console.WriteLine($"Aktuelles Level: {level}");
                Console.WriteLine($"Erfahrungspunkte: {xp}/{xpNextLevel}");
                Console.WriteLine("\n(1) XP durch Training sammeln");
                Console.WriteLine("(2) Zurück zum Hauptmenü");
                Console.Write("\nDeine Wahl: ");

                string eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    int xpGain = new Random().Next(20, 50);
                    xp += xpGain;
                    Console.WriteLine($"\n🔥 Du hast {xpGain} XP erhalten!");

                    // Level Up Check nach jeder XP Erhöhung
                    while (xp >= xpNextLevel)
                    {
                        xp -= xpNextLevel;
                        level++;
                        xpNextLevel += 50;
                        Console.WriteLine($"🎉 Level Up! Du bist jetzt Level {level}!");
                    }

                    Console.WriteLine("\nDrücke eine beliebige Taste, um weiterzumachen...");
                    Console.ReadKey();
                }
                else if (eingabe == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nZurück zum Hauptmenü...");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nUngültige Eingabe! Bitte erneut versuchen.");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
