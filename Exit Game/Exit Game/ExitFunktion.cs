using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Text_adventures
{
    class ExitFunktion
    {
 
        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Willst du das Menu schließen ?");
            Console.WriteLine("(1) Ja");
            Console.WriteLine("(2) Nein");
 
            Console.Write("Deine Wahl: ");
            string input = Console.ReadLine();
 
            if (input == "1")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nSpiel wird beendet...");
                Console.ResetColor();
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (input == "2")
            {
                Console.Clear();
                return;
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