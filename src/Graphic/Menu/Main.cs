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
    class Main
    {
        private static ResourceManager lang;

        public Main(ResourceManager _lang)
        {
            lang = _lang;         
        }
		/// <summary>
		/// Version of software.
		/// </summary>
        public static void Version()
        {
		Console.ResetColor();
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine("===========================================================");
		Console.WriteLine(" Crisis Wordlist Generator  by Teeknofil | [Version]: 1.1.5");
		Console.WriteLine("===========================================================");
		Console.WriteLine(" [Web]: https://github.com/teeknofil/Crisis-Wordlist-Generator");
		Console.WriteLine("===========================================================");
		Console.WriteLine(" [Twitter]: @teeknofile");
		Console.WriteLine("===========================================================");
		Console.WriteLine(" Bitcoin : 1FKVkfLajBLCzNxskKLg5y9aeTe26AEyxr");
		Console.WriteLine("===========================================================");
		Console.ResetColor();
        }        

       
        /// <summary>
        /// Main menu
        /// </summary>
        /// <param name="lang"></param>
        /// <returns></returns>
        internal void Menu()
        {
            Version();
            Interface.HeaderMenu();           

            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            
            Console.WriteLine("\t "+ lang.GetString("WIFI"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t " + lang.GetString("createWordlist"));

            

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t "+lang.GetString("transformWordlist"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t "+lang.GetString("profiler"));

          
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 99)");
            Console.ResetColor();

            Console.WriteLine("\t " + lang.GetString("exit"));
                        
        }
        /// <summary>
        /// Display menu who allow create wordlist
        /// </summary>
        /// <param name="lang"></param>
        /// <returns></returns>

        internal void LocalBruteForcerMenu()
        {
            Version();
            Interface.HeaderMenu();
            
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t LATIN\t");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t SPECIAL");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t "+lang.GetString("swedish"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t "+lang.GetString("cyrillic"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t "+lang.GetString("syllable_fr"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t "+ lang.GetString("CUSTOM"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 88) ");
            Console.ResetColor();
            Console.WriteLine("\t "+lang.GetString("_return"));


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" 99)");
            Console.ResetColor();
            Console.WriteLine("\t " + lang.GetString("exit"));
            Console.ResetColor();
            
        }  // End Function

        internal void TransformWordlist()
        {
            Version();
            Interface.HeaderMenu();

            int i = 0;
                      
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine("\t Leet Speak");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t Lowercase To Uppercase\t");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t Uppercase To Lowercase");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t Automatic Character  Lowercase <=> Uppercase");

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

