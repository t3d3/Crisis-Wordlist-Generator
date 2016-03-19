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
    public class MainMenu
    {
        private static bool booleanMainMenu;
        public static bool BooleanMainMenu
        {
            get { return MainMenu.booleanMainMenu; }
            set { MainMenu.booleanMainMenu = value; }
        }

        private static bool booleanCategoryMenu;
        public static bool BooleanCategoryMenu
        {
            get { return MainMenu.booleanCategoryMenu; }
            set { MainMenu.booleanCategoryMenu = value; }
        }
        

        public MainMenu()
        {
        }
        

        internal  void Start()
        {           
            Console.WriteLine("\n Hacking US   : hackforums.net ");
            Console.WriteLine(" Trouble US   : forums.kali.org"); 
            Console.WriteLine(" Hacking FR   : hackademics.fr");
            Console.WriteLine(" Trouble FR   : kali-linux.fr/forum");
            Console.WriteLine(" Hacking Wifi : crack-wifi.com/forum\n");        
        }

        public static void Version()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Crisis Wordlist Generator  by Teeknofil, version : 1.1.2 \n");
            Console.ResetColor();
        }

        public void Menu()
        {
            Version();

            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t CRISIS CLIENT/SERVER BRUTE FORCER");            

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t CREATE WORDLIST BRUTE FORCER ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t TRANSFORMING WORDLIST NO JUTSU");
        
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine("\t DOWNLOAD WORDLIST NO JUTSU \t");

            

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 99)");
            Console.ResetColor();

            Console.WriteLine("\t EXIT ");

            booleanMainMenu = true;

            while (booleanMainMenu)
            {
                try
                {
                    //Charset.BooleanType = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;

                    if (dislayMainSubMain == ++i)
                    {
                    }
                    if (dislayMainSubMain == ++i)
                    {
                        LocalBruteForcerWordlistMenu();
                        Property.TypeOfProcess = 2;
                    }
                    //TRANSFORMING WORDLIST NO JUTSU
                    if (dislayMainSubMain == ++i)
                    {
                        TransformWordlistMenu();                        
                        Property.TypeOfProcess = 3;
                    } 
                    if (dislayMainSubMain == ++i)
                    {
                        //SubMenu obj = new SubMenu();
                        //obj.DonwloadMenu();
                    }                        
                    // EXIT
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

        internal static void CrisisMenuNetwork()
        {
            Version();

            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine("\t CRISIS SERVER BRUTE FORCER");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t CRISIS CLIENT BRUTE FORCER\t");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();           

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 88 ");
            Console.ResetColor();

            Console.WriteLine("\t RETURN");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" 99)");
            Console.ResetColor();

            Console.WriteLine("\t EXIT ");


            booleanCategoryMenu = true;
            while (booleanCategoryMenu)
            {
                try
                {
                    //Charset.BooleanType = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;

                    if (dislayMainSubMain == ++i)
                        booleanCategoryMenu = false; // tmp variable
                    Property.TypesOfGeneration = 9;
                    if (dislayMainSubMain == ++i)

                        // EXIT
                        if (dislayMainSubMain == 88)
                        {
                            MainMenu obj = new MainMenu();
                            new Thread(obj.Menu).Start();
                            BooleanMainMenu = true;
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

        internal static void LocalBruteForcerWordlistMenu()
        {
            Version();            
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();
            
            Console.WriteLine(" \tDESCRIPTION \n");
            int i = 0;

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

            booleanCategoryMenu = true;
            while (booleanCategoryMenu)
            {
                try
                {
                    //Charset.BooleanType = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");                    
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;
                                        
                    //LATIN    CHARACTER
                    if (dislayMainSubMain == i++)
                       SubMenu.LatinMenu();
                    //CUSTOM    CHARACTER
                    if (dislayMainSubMain == i++)
                    {
                        SubMenu objSubMenu = new SubMenu();
                        objSubMenu.MenuCustom();
                        MenuParameter config = new MenuParameter();
                        config.TypesOfFileAtGenerate();
                    }
                    //SPECIAL
                    if (dislayMainSubMain == i++)
                        SubMenu.SpecialMenu();
                    // SWEDISH    CHARACTER    
                    if (dislayMainSubMain == i++)
                        SubMenu.SwedishMenu();
                    // CYRILLIC    CHARACTER    
                    if (dislayMainSubMain == i++)
                        SubMenu.CyrillicMenu();
                    // SYLLABLE  CHARACTER
                    if (dislayMainSubMain == i++)
                        SubMenu.SyllableMenu();
                    if (dislayMainSubMain == i++)
                        SubMenu.WifiMenu();   
                    // EXIT
                    if (dislayMainSubMain == i++)                    
                        Environment.Exit(0);
                    if (dislayMainSubMain == 88)
                    {
                        MainMenu obj = new MainMenu();
                        new Thread(obj.Menu).Start();
                        BooleanMainMenu = true;
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

        internal static void TransformWordlistMenu()
        {
            Version();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();

            Console.WriteLine(" \tDESCRIPTION \n");
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine("\t LEET SPEAK");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t LOWERCASE TO UPPERCASE\t");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t UPPERCASE TO LOWERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
                       
            Console.WriteLine(" \t AUTOMATIC CHARACTER  LOWERCASE <=> UPPERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 88) ");
            Console.ResetColor();

            Console.WriteLine("\t RETURN");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" 99)");
            Console.ResetColor();

            Console.WriteLine("\t EXIT ");

            Console.ResetColor();

            booleanCategoryMenu = true;
            while (booleanCategoryMenu)
            {
                try
                {
                    //Charset.BooleanType = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;

                    //LEET SPEAK
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuLeetSpeakPrint();
                        Property.TypesOfTransforming = 1;
                        booleanCategoryMenu = false;
                    }
                    // LOWERCASE TO UPPERCASE
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuLowercaseToUppercasePrint();
                        Property.TypesOfTransforming = 2;
                        booleanCategoryMenu = false;
                    }
                    // UPPERCASE TO LOWERCASE
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuUppercaseToLowercasePrint();
                        Property.TypesOfTransforming = 3;
                        booleanCategoryMenu = false;
                    }                    
                    // AUTOMATIC CHARACTER  LOWERCASE <=> UPPERCASE
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuAutoUppercaseLowercasePrint();
                        Property.TypesOfTransforming = 4;
                        booleanCategoryMenu = false;
                    }                                   
                    if (dislayMainSubMain == 88)
                    {
                        MainMenu obj = new MainMenu();
                        new Thread(obj.Menu).Start();
                        BooleanMainMenu = true;
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

        internal void DonwloadMenu()
        {
            Version();


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

            //booleanSubMenu = true;
            while (SubMenu.BooleanSubMenu)
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



    } // End class
}// End class namespace
