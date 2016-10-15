using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;

namespace Crisis.Graphic.Menu
{
    public class Character
    {
        private static ResourceManager lang;
        
        public Character()
        {
           
        }

        public Character(ResourceManager _lang)
        {
            lang = _lang;            
        }
                           

        internal static void LatinMenu()
        {
            Interface.HeaderMenu();
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t LATIN\t    CHARACTER LOWERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t LATIN\t    CHARACTER UPPERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t LATIN\t    CHARACTER UPPERCASE & LOWERCASE");
            Interface.Navigation();

        }

        internal static void SpecialMenu()
        {
            Interface.HeaderMenu();
            int i = 0;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t HEXA");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t NUMBER");           

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t SPECIAL CHARACTER");

            Interface.Navigation();
        }

        internal static  void SwedishMenu()
        {
            Interface.HeaderMenu();
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t SWEDISH    CHARACTER LOWERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t SWEDISH    CHARACTER UPPERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t SWEDISH    CHARACTER UPPERCASE & LOWERCASE");

            Interface.Navigation();
        }

        internal static void CyrillicMenu()
        {

            Interface.HeaderMenu();

            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t CYRILLIC    CHARACTER LOWERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t CYRILLIC    CHARACTER UPPERCASE");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t CYRILLIC    CHARACTER UPPERCASE & LOWERCASE");

            Interface.Navigation();

        }

        internal static void SyllableMenu()
        {

            Interface.HeaderMenu();
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t SYLLABLE   CHARACTER LOWERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t SYLLABLE   CHARACTER UPPERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t SYLLABLE   CHARACTER UPPERCASE & LOWERCASE");

            Interface.Navigation();

        }

        internal static void WifiMenu(ResourceManager lang)
        {
            Interface.HeaderMenu();
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ",++i);
            Console.ResetColor();
            Console.WriteLine(" \tBOX ADSL SFR ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \tBOX ADSL LIVEBOX ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 88) ");
            Console.ResetColor();
            Console.WriteLine("\t " + lang.GetString("_return"));


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" 99)");
            Console.ResetColor();
            Console.WriteLine("\t " + lang.GetString("exit"));
            Console.ResetColor();
           
        }
        
    }
}
