using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Resources;
using Crisis.Charset;
using Crisis.Graphic.Menu;
using Crisis.Tools;
using System.Numerics;

namespace Crisis.Graphic
{
    class Interface
    {
        private static ResourceManager lang;

        public Interface ()
        {

        }

        public Interface(ResourceManager _lang)
        {
            lang = _lang;
        }


        

        public ResourceManager Lang_Text()
        {            
            int i = 0;
            bool b = true;

            Console.Clear();

            Main.Version();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t en-US");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t fr-FR\t");
            Console.ResetColor();

            while (b)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[+] ");
                Console.ResetColor();
                Console.Write("Language : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                try
                {
                    int language = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Assembly asm = Assembly.Load("crisis");
                    if (language == 2)
                    {
                        lang = new ResourceManager("Crisis.Core.Lang.fr-Fr", asm);
                        b = false;
                    }
                    else
                    {

                        lang = new ResourceManager("Crisis.Core.Lang.en-US", asm);
                        b = false;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n Choose language interface with number");
                    Console.ResetColor();
                }

            }
            Console.Clear();
            return lang;
        }

        internal void Start()
        {
            Console.WriteLine("\n Hacking US   : hackforums.net ");
            Console.WriteLine(" Trouble US   : forums.kali.org");
            Console.WriteLine(" Hacking FR   : hackademics.fr");
            Console.WriteLine(" Trouble FR   : kali-linux.fr/forum");
            Console.WriteLine(" Hacking Wifi : crack-wifi.com/forum\n");
        }

        /// <summary>
        /// Header the options in the menu
        /// </summary>
        internal static void HeaderMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();
            Console.WriteLine(" \tDESCRIPTION \n");
        }

        internal static void Navigation()
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 77) ");
            Console.ResetColor();
            Console.Write("\t " + lang.GetString("_return"));
            //_return
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 88) ");
            Console.ResetColor();
            Console.Write("\t " + lang.GetString("ReturnMainMenu"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 99)");
            Console.ResetColor();
            Console.Write("\t " + lang.GetString("exit"));
            Console.ResetColor();
            Console.Write("\n");
        }

        /// <summary>
        /// Select option in the mene
        /// </summary>
        /// <param name="lang"></param>
        /// <returns></returns>
        internal int SelectOption()
        {
            bool b = true;
            int dislayMainSubMain = 0;

            try
            {
                while (b)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(lang.GetString("category"));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    for (int i = 1; i <= dislayMainSubMain; i++)
                    {
                        if (dislayMainSubMain == i | dislayMainSubMain == 77 | dislayMainSubMain == 88 | dislayMainSubMain == 99)
                        {
                            b = false;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n {0} \n", e.Message);
                Console.ResetColor();
            }

            return dislayMainSubMain;
        }


        internal List<string> InterfaceSelectCharset(ResourceManager lang)
        {
            List<string> charsetSelecting = null;

            bool b = true;

            while (b)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[+] ");
                Console.ResetColor();

                Console.Write(lang.GetString("charset"));

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string charsetName = Console.ReadLine().ToLower();
                Console.ResetColor();

                Parameter charset = new Parameter();
                charsetSelecting = charset.SelectPattern(new string[] { charsetName });

                if (charsetSelecting != null)
                {
                    b = false;
                }
            }

            return charsetSelecting;
        }


        internal int TypesAtGenerate()
        {
            byte i = 0;
                       
            int typesOfGeneration = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t {0}", lang.GetString("PatternforCrunch"));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t {0}", lang.GetString("Increment"));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t {0}", lang.GetString("Random"));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t Variations ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine(" \t Permutations");          
           

            return typesOfGeneration = SelectOption();

        } //End Fonction

        internal byte SizeOfWorld(List<string> charsetSelecting, byte numberOfChar, int typesAtGenerate)
        {
            bool b = true;
            while (b)
            {
                try
                {                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write("What is the size of your charset : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    b = byte.TryParse(Console.ReadLine(), out numberOfChar);                                         
                    Console.ResetColor();

                    if (numberOfChar >= charsetSelecting.Count & typesAtGenerate != 3)
                    {
                        b = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n The number of character is too large to generate\n a caratère chain");
                        Console.ResetColor();
                    }
                    else
                    {
                        b = false;
                    }

                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Type the size of your charset");
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();

                    b = true;
                }
            }

            return numberOfChar;

        } // End Fonction

        internal bool Repetition(bool repeat)
        {
            bool b = true;

            while (b)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[+] ");
                Console.ResetColor();
                Console.Write("Would you a repeating of character ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" n ");
                Console.ResetColor();
                Console.Write("]\n ");

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo info = Console.ReadKey(true);
                    Console.ResetColor();

                    if (info.Key == ConsoleKey.Y)
                    {
                        repeat = true; // repeat character in methode combinaison
                        b = false; // close the while
                    }
                    if (info.Key == ConsoleKey.N)
                    {
                        repeat = false; // no repeat character in methode combinaison
                        b = false; // close the while
                    }
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                }
            }

            return repeat;

        } // End Fonction

        internal List<string> ChangeStartblockPattern(List<string> charsetSelecting)
        {
            Utility obj = new Utility();
            bool b = true;

            while (b)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[+] ");
                Console.ResetColor();
                Console.Write("Do you want to specify a starting chain ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" n ");
                Console.ResetColor();
                Console.Write("]\n ");


                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo info = Console.ReadKey(true);
                    Console.ResetColor();

                    if (info.Key == ConsoleKey.Y)
                    {

                        Console.Write("\n Write the starting string : ");

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string s = Console.ReadLine();
                        Console.ResetColor();

                        if (s.Length >= 2 | s != null)
                        {
                            obj.StartblockPattern(s, charsetSelecting);

                            b = false;
                        }
                    }
                    if (info.Key == ConsoleKey.N)
                    {
                        b = false;
                    }
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                }
            }

            return charsetSelecting;
        } // End Fonction

        internal List<string> ChangeEndblockPattern(List<string> charsetSelecting, byte numberOfChar)
        {
            Utility obj = new Utility();
            bool b = true;

            while (b)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[+] ");
                Console.ResetColor();
                Console.Write("Do you want to specify a ending chain ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" n ");
                Console.ResetColor();
                Console.Write("] ");
                Console.Write("\n");
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo info = Console.ReadKey(true);
                    Console.ResetColor();

                    if (info.Key == ConsoleKey.Y)
                    {

                        Console.Write("\n Write the end string : ");

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string s = Console.ReadLine();
                        Console.ResetColor();

                        if (s.Length >= 2 | s != null)
                        {
                            obj.EndPattern(s, numberOfChar, charsetSelecting);
                            b = false;
                        }
                    }
                    if (info.Key == ConsoleKey.N)
                    {
                        b = false;
                    }
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                }
            }

            return charsetSelecting;

        } // End Fonction

        internal List<string> ReversePatern(List<string> charsetSelecting)
        {
            bool b = true;

            while (b)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[+] ");
                Console.ResetColor();
                Console.Write("Want to reverse the pattern ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" n ");
                Console.ResetColor();
                Console.Write("] ");
                Console.Write("\n");

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    Console.ResetColor();

                    if (keyInfo.Key == ConsoleKey.N)
                    {
                        b = false;
                    }
                    else if (keyInfo.Key == ConsoleKey.Y)
                    {
                        charsetSelecting.Reverse();
                        b = false;
                    }
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                }

            }

            return charsetSelecting;

        } // End Fonction 


        internal BigInteger sizeFile(bool saveFile, int numberOfChar, int typesAtGenerate, BigInteger numberOfAllCombination)
        {
            Statistical info = new Statistical();
            bool b = true;
            string sizeFiles = null;
            BigInteger numberLine = 0;

            if (saveFile)
            {
                while (b)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n[+] ");
                        Console.ResetColor();
                        Console.Write("What size should a save file in MB : ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        sizeFiles = Console.ReadLine();                        
                        Console.ResetColor();
                        
                        int sizFilesInMB = 0;

                        if (Int32.TryParse(sizeFiles, out sizFilesInMB))
                        {
                            sizFilesInMB *= 1048576;
                            numberLine = info.CalculSizeFile(sizFilesInMB,numberOfChar, typesAtGenerate, numberOfAllCombination);
                            b = false;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n {0} \n", e.Message);
                        Console.ResetColor();
                    }
                }
            }
            return numberLine;
        }

        internal bool SaveCharsetInFilesTxt(int numberOfChar, int typesAtGenerate, BigInteger numberOfAllCombination)
        {
            bool b = true;
            bool saveFile = false;
            while (b)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write("Do you want to save the output to a file [");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" y ");
                    Console.ResetColor();
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" n ");
                    Console.ResetColor();
                    Console.Write("]\n ");


                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    ConsoleKeyInfo info = Console.ReadKey(true);

                    Console.ResetColor();

                    if (info.Key == ConsoleKey.N)
                    {                        
                        b = false;
                    }
                    else if (info.Key == ConsoleKey.Y)
                    {
                        saveFile = true;
                        b = false;
                    }
                    else
                    {
                        b = true;
                    }

                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                    b = true;
                }
            }          

            return saveFile;

        } // End Fonction


        internal bool SaveCharsetInFilesZip()
        {
            bool b = true;
            bool zip = false;

            while (b)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write("You want to compress them into zip file [ ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" y ");
                    Console.ResetColor();
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" n ");
                    Console.ResetColor();
                    Console.Write("] ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    Console.Write("\n");
                    Console.ResetColor();

                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        zip = true;
                        b = false;
                    }
                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        zip = false;
                        b = false;
                    }

                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                }
            }           
        
        return zip;
    } // End Fonction



    } //End class
} // End Namespace
