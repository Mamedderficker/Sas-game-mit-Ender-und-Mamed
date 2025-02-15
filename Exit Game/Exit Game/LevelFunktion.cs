using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventures
{
    class LevelFunktion
    {
        static int level = 1;
        static int xp = 0;
        static int xpNextLevel = 100;

        public static void LevelSystem()
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
                Console.WriteLine($"🔥 Du hast {xpGain} XP erhalten!");

                if (xp >= xpNextLevel)
                {
                    xp -= xpNextLevel;
                    level++;
                    xpNextLevel += 50;
                    Console.WriteLine($"🎉 Level Up! Du bist jetzt Level {level}!");
                }
            }
            Thread.Sleep(2000);
        }

    }
}


