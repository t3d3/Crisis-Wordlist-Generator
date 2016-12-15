//  Author:
//       Teeknofil <teeknofil.dev@gmail.com>
//
//  Copyright (c) 2015 Teeknofil
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
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
                           

        internal  void LatinMenu()
        {
            Interface.HeaderMenu();
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t LATIN\t    "+ lang.GetString("CHARACTERLOWERCASE"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t LATIN\t    " + lang.GetString("CHARACTERUPPERCASE"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t LATIN\t    " + lang.GetString("CHARACTERUPPERCASELOWERCASE"));
            Interface.Navigation();

        }

        internal  void SpecialMenu()
        {
            Interface.HeaderMenu();
            int i = 0;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\tHEXA");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0})", ++i);
            Console.ResetColor();
            Console.WriteLine("\t"+ lang.GetString("NUMBER"));           

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0})", ++i);
            Console.ResetColor(); 
            Console.WriteLine("\t" + lang.GetString("SPECIAL"));

            
        }

        internal   void SwedishMenu()
        {
            Interface.HeaderMenu();
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t" + lang.GetString("swedish") + "    " + lang.GetString("CHARACTERLOWERCASE"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t" + lang.GetString("swedish") + "    " + lang.GetString("CHARACTERUPPERCASE"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t" + lang.GetString("swedish") + "    "+ lang.GetString("CHARACTERUPPERCASELOWERCASE"));

            
        }

        internal  void CyrillicMenu()
        {

            Interface.HeaderMenu();

            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t " + lang.GetString("CYRILLIC") + "    " + lang.GetString("CHARACTERLOWERCASE"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t " + lang.GetString("CYRILLIC") + "    " + lang.GetString("CHARACTERUPPERCASE"));


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t " + lang.GetString("CYRILLIC") + "    " + lang.GetString("CHARACTERUPPERCASELOWERCASE"));

            

        }

        internal  void SyllableMenu()
        {

            Interface.HeaderMenu();
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t " + lang.GetString("syllable_fr") + "    " + lang.GetString("CHARACTERLOWERCASE"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t " + lang.GetString("syllable_fr") + "    " + lang.GetString("CHARACTERUPPERCASE"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t " + lang.GetString("syllable_fr") + "    " + lang.GetString("CHARACTERUPPERCASELOWERCASE"));

           
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

        public static void MenuLeetSpeakPrint()
        {
            Console.WriteLine("\n leet speak\t\t\t 1337 5p34k\n");
        }
        public static void MenuLowercaseToUppercasePrint()
        {
            Console.WriteLine(" hello world\t\t\t HELLO WORLD\n");
        }

        public static void MenuUppercaseToLowercasePrint()
        {
            Console.WriteLine(" HELLO WORLD\t\t\t hello world\n");
        }

        public static void MenuCharLowercaseToUppercasePrint()
        {
            Console.WriteLine(" Hello World\t\t\t hELLO wORLD\n");
        }

        public static void MenuCharUppercaseToLowercasePrint()
        {
            Console.WriteLine(" Hello World\t\t\t hello world\n");
        }

        public static void MenuAutoUppercaseLowercasePrint()
        {
            Console.WriteLine(" HellO WorlD\t\t\t hELLo wORLd \n");
        }
    }
}
