using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public class MainMenu
    {
        private static bool booleanCategoryMenu = true;
        

        public MainMenu()
        {

        }

        public static void Navigation()
        {

            Algorithme Function = new Algorithme();
            MainMenu menu = new MainMenu();
            Parameter config = new Parameter();
            Statistical info = new Statistical();

            menu.start();
            menu.Menu();

            if (Parameter.TypesOfGeneration == 1 || Parameter.TypesOfGeneration == 2)
            {
                config.ReversePaterne();
                config.SizeOfWorld();
                config.SaveCharsetInFilesTxt();
                info.StatiscalInfoSize();
                Function.EnumerationPrint();
                Parameter.TypesOfGeneration = 0;
            }
            else if (Parameter.TypesOfGeneration == 3)
            {
                config.SizeOfWorld();
                config.SaveCharsetInFilesTxt();
                info.StatiscalInfoSize();
                Function.RamdonPrint();
                Parameter.TypesOfGeneration = 0;
            }
            else if (Parameter.TypesOfGeneration == 4)
            {
                config.SaveCharsetInFilesTxt();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n This work, please wait\n");
                Console.ResetColor();
                Function.L33tSpeek();
                Parameter.TypesOfGeneration = 0;
            }

        } // End Fonction

        internal void start()
        {                        
            Console.WriteLine(" Hack Wifi  : http://www.crack-wifi.com/forum/index.php");           
            Console.WriteLine(" Hacking FR : http://hackademics.fr/");            
            Console.WriteLine(" Trouble FR : http://www.kali-linux.fr/forum/index.php");                       
            Console.WriteLine(" Trouble US : http://http://forums.kali.org/");                       
            Console.WriteLine(" Hacking US : http://hackforums.net/index.php");            
        }

        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Crisis Wordlist Generator  by Teeknofil, version : 1.0.9\n");
            Console.ResetColor();
            
            Console.WriteLine("\n N°\tDESCRIPTION \n");
            int i = 0;
            Console.WriteLine(" {0})\t 1337", i++);
            Console.WriteLine(" {0})\t LATIN\t", i++);
            Console.WriteLine(" {0})\t SPECIAL", i++);            
            Console.WriteLine(" {0})\t SWEDISH", i++);
            Console.WriteLine(" {0})\t SYLLABLE FR", i++);
            Console.WriteLine("\n {0})\t EXIT ", i++);

            SubMenu obj1 = new SubMenu();

            booleanCategoryMenu = true;
            while (booleanCategoryMenu)
            {
                try
                {
                    Charset.BooleanType = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");                    
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    int dislayMainSubMain = int.Parse(Console.ReadLine().ToLower());
                    Console.Write("\n");
                    i = 0;

                    if (dislayMainSubMain == i++)
                        obj1.MenuLeetSpeak();                   
                    //LATIN    CHARACTER
                    if (dislayMainSubMain == i++)
                        LatinMenu();
                    //SPECIAL
                    if (dislayMainSubMain == i++)
                        SpecialMenu();
                    // SWEDISH    CHARACTER    
                    if (dislayMainSubMain == i++)
                        SwedishMenu();
                    // SYLLABLE  CHARACTER
                    if (dislayMainSubMain == i++)
                        SyllableMenu();                    
                    // EXIT
                    if (dislayMainSubMain == i++)                    
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

        internal static void LatinMenu()
        {
            SubMenu obj2 = new SubMenu();
            booleanCategoryMenu = false;
            Parameter config = new Parameter();

            Console.WriteLine("\n N°\tDESCRIPTION \n");
            int i = 0;

            Console.WriteLine(" {0})\t LATIN\t    CHARACTER LOWERCASE", i++);
            Console.WriteLine(" {0})\t LATIN\t    CHARACTER UPPERCASE", i++);
            Console.WriteLine(" {0})\t LATIN\t    CHARACTER UPPERCASE & LOWERCASE", i++);
            Console.WriteLine("\n {0})\t RETURN\t    MAIN MENU", i++);
            
            SubMenu.BooleanSubMenu = true;
            while (SubMenu.BooleanSubMenu)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    int dislayMainSubMain = int.Parse(Console.ReadLine().ToLower());
                    Console.Write("\n");
                    i = 0;

                    //LATIN    CHARACTER
                    if (dislayMainSubMain == i++)
                    {
                        obj2.LatinCharacterLowercase();
                        config.TypesOfFileAtGenerate();
                    } 
                    else if (dislayMainSubMain == i++)
                    {
                        obj2.LatinCharacteUppercase();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        obj2.LatinCharacterUppercaseLowercase();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        SubMenu.BooleanSubMenu = true;
                        MainMenu.Navigation();
                    }
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

        internal static void SpecialMenu()
        {
            SubMenu obj1 = new SubMenu();
            booleanCategoryMenu = false;
            Parameter config = new Parameter();
            Console.WriteLine("\n N°\tDESCRIPTION \n");
            int i = 0;

            Console.WriteLine(" {0})\t HEXA", i++);            
            Console.WriteLine(" {0})\t NUMBER", i++);
            Console.WriteLine(" {0})\t SPECIAL CHARACTER", i++);            
            Console.WriteLine("\n {0})\t RETURN  MAIN MENU", i++);

            SubMenu.BooleanSubMenu = true;
            while (SubMenu.BooleanSubMenu)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    int dislayMainSubMain = int.Parse(Console.ReadLine().ToLower());
                    Console.Write("\n");
                    i = 0;

                    if (dislayMainSubMain == i++)
                    {
                        obj1.MenuHexa();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        obj1.MenuNumeric();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        obj1.MenuSpecialCharacteres();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        MainMenu.Navigation(); 
                    }

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
        

        public static void SwedishMenu()
        {
            SubMenu obj3 = new SubMenu();
            booleanCategoryMenu = false;
            Parameter config = new Parameter();
            Console.WriteLine("\n N°\tDESCRIPTION \n");
            int i = 0;
            
            Console.WriteLine(" {0})\t SWEDISH    CHARACTER LOWERCASE", i++);
            Console.WriteLine(" {0})\t SWEDISH    CHARACTER UPPERCASE", i++);
            Console.WriteLine(" {0})\t SWEDISH    CHARACTER UPPERCASE & LOWERCASE", i++);
            Console.WriteLine("\n {0})\t RETURN\t    MAIN MENU", i++);

            SubMenu.BooleanSubMenu = true;
            while (SubMenu.BooleanSubMenu)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    int dislayMainSubMain = int.Parse(Console.ReadLine().ToLower());
                    Console.Write("\n");
                    i = 0;


                    // SWEDISH    CHARACTER
                    if (dislayMainSubMain == i++)
                    {
                        obj3.SwddishCharacterLowercase();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        obj3.SwddishCharacterUppercase();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        obj3.SwddishCharacterLowercaseUppercase();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        MainMenu.Navigation(); 
                    }

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

        public static void SyllableMenu()
        {
            SubMenu obj4 = new  SubMenu();
            booleanCategoryMenu = false;
            Parameter config = new Parameter();
            
            Console.WriteLine("\n N°\tDESCRIPTION \n");
            int i = 0;

            Console.WriteLine(" {0})\t SYLLABLE   CHARACTER LOWERCASE", i++);
            Console.WriteLine(" {0})\t SYLLABLE   CHARACTER UPPERCASE", i++);            
            Console.WriteLine(" {0})\t SYLLABLE   CHARACTER UPPERCASE & LOWERCASE", i++);
            Console.WriteLine("\n {0})\t RETURN     MAIN MENU", i++);
            Console.ResetColor();

            SubMenu.BooleanSubMenu = true;
            while (SubMenu.BooleanSubMenu)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    int dislayMainSubMain = int.Parse(Console.ReadLine().ToLower());
                    Console.Write("\n");
                    i = 0;
                    
                    //        SYLLABLE   CHARACTER
                    if (dislayMainSubMain == i++)
                    {
                        obj4.SyllableCharacterLowercase();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        obj4.SyllableCharacteUppercase();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        obj4.SyllableCharacterUppercaseLowercase();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        MainMenu.Navigation(); 
                    }
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
