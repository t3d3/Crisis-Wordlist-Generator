//  Author:
//       Teeknofil <teeknofil@gmail.com>
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace crisis
{
    public class SubMenu : Property
    {

        private static bool booleanSubMenu;

        public static bool BooleanSubMenu
        {
            get { return SubMenu.booleanSubMenu; }
            set { SubMenu.booleanSubMenu = value; }
        }
        
        public SubMenu()
        {
            booleanSubMenu = true;
        }


        internal void GenericMenuSelectCharset()
        {
            Command run = new Command(true);
            while (Charset.BooleanType)
            {
                Console.Write(" Write the name corresponding to your choice : ");
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor();

                string[] args = new string[] { Charset.CharsetName };
                run.FunctionPattern(args);
            }
        }

        internal void MenuReadFileTxt()
        {
            while (Charset.BooleanType)
            {
                Console.Write(" Enter the name and path of your file : ");
                Charset.CharsetName = Console.ReadLine().ToLower();
                Charset.ReadFileTxt();
            }
        }

        internal void MenuCustom()
        {
            while (Charset.BooleanType)
            {                
                Console.Write(" Write your custom pattern : ");
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string s = Console.ReadLine();
                Console.ResetColor();                              

                if (s.Length > 1 & s != null)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        Charset.CharsetSelecting.Add(s[i].ToString());
                    }

                    Charset.BooleanType = false;
                    MainMenu.BooleanCategoryMenu = false;
                   
                }
                else
                {
                     Charset.BooleanType = true;
                }
            }
        }

        internal void DonwloadMenu()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Crisis Wordlist Generator  by Teeknofil, version : 1.1.2 \n");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();

            Console.WriteLine(" \tDESCRIPTION \n");
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine("\t 1337");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t LATIN\t");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t CUSTOM");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t SPECIAL");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t SWEDISH");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t CYRILLIC");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t SYLLABLE FR");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t ROUTER\\BOX WIFI");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 88) ");
            Console.ResetColor();

            Console.WriteLine("\t RETURN");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" 99)");
            Console.ResetColor();

            Console.WriteLine("\t EXIT ");

            Console.ResetColor();

            booleanSubMenu = true;
            while (booleanSubMenu)
            {
                try
                {
                    //Charset.BooleanType = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" Type a number to download a wordlist : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;

                    if (dislayMainSubMain == i++)
                    {
                        
                    }
                    
                    if (dislayMainSubMain == i++)
                        
                    
                    
                    // EXIT
                    if (dislayMainSubMain == i++)
                        Environment.Exit(0);
                    if (dislayMainSubMain == 88)
                    {
                        MainMenu obj = new MainMenu();
                        new Thread(obj.Menu).Start();
                        break;
                    }
                    if (dislayMainSubMain == 99)
                        Environment.Exit(0);

                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Enter the number corresponding !");
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();
                }
            }
        }
       
    }
}
