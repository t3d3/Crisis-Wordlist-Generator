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

	using Crisis.Combinatorics;
	using Crisis.Graphic.Menu;
	using Crisis.Tools;
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Numerics;
	using System.Reflection;
	using System.Resources;

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


	        internal static void SetColorAsk()
	        {
	            Console.Write("[");
	            Console.ForegroundColor = ConsoleColor.DarkGreen;
	            Console.Write(" y ");
	            Console.ResetColor();
	            Console.Write("/");
	            Console.ForegroundColor = ConsoleColor.DarkGreen;
	            Console.Write(" n ");
	            Console.ResetColor();
	            Console.Write("]\n ");


	        }

	        private static void SetColorThemes()
	        {
	            Console.Write("\n");
	            Console.ForegroundColor = ConsoleColor.Green;
	            Console.Write(" [+] ");
	            Console.ResetColor();
	        }

	        internal static void SetColorThemes2()
	        {
	            
	            Console.ForegroundColor = ConsoleColor.Green;
	            Console.Write(" > ");
	            Console.ResetColor();
	        }

        /// <summary>
        /// Langs the text.
        /// </summary>
        /// <returns>The text.</returns>

	    internal ResourceManager Lang_Text()
        {            
            Error:
            int i = 0;


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

            while (true)
            {
                SetColorThemes();
                Console.Write("Language : ");

                try
                {
                    int language = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Assembly asm = Assembly.Load("crisis");
                    if (language == 2)
                    {
                        lang = new ResourceManager("Crisis.Core.Lang.fr-Fr", asm);
                        break;
                    }
                    else
                    {

                        lang = new ResourceManager("Crisis.Core.Lang.en-US", asm);
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n Choose language interface with number");
                    Console.ResetColor();
                    goto Error;
                }

            }
            Console.Clear();
            return lang;
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

        /// <summary>
        /// Navigation this instance.
        /// </summary>
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
        /// Selects the option.
        /// </summary>
        /// <returns>The option.</returns>
        /// <param name="dislayMainSubMain">Dislay main sub main.</param>
	        
	    internal int SelectOption(int dislayMainSubMain)
        {
            bool b = true;
            try
            {
                while (b)
                {
                    Console.Write("\n");
                    SetColorThemes();
                    Console.Write(lang.GetString("category"));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    for (int i = 1; i <= dislayMainSubMain; i++)
                    {
                        if (dislayMainSubMain == i | dislayMainSubMain == 77 | dislayMainSubMain == 88 | dislayMainSubMain == 99)
                        {	                            
                            b = false;
                        }
                        else if (dislayMainSubMain >= 100)
                        {
                            i = dislayMainSubMain;
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

        /// <summary>
        /// Interfaces the select charset.
        /// </summary>
        /// <returns>The select charset.</returns>
        /// <param name="lang">Lang.</param>

	    internal List<string> InterfaceSelectCharset(ResourceManager lang)
        {
            List<string> charsetSelecting = null;           

            while (true)
            {
                SetColorThemes();

                Console.Write(lang.GetString("charset"));

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string charsetName = Console.ReadLine();
                    Console.Write("\n");
                    Console.ResetColor();

                    if (!string.IsNullOrEmpty(charsetName))
                        charsetSelecting = Parameter.SelectPattern(new string[] { charsetName.Replace("\r", "") });

                    if (charsetSelecting != null)
                    {
                        if (charsetSelecting.Count >= 2)
                        {
                            break;
                        }                       
                    }
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Type the size of your charset");
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();
                }                
            }

            return charsetSelecting;
        }

        /// <summary>
        /// Typeses at generate.
        /// </summary>
        /// <returns>The at generate.</returns>

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


            while (true)
            {
                typesOfGeneration = SelectOption(5);
                if (typesOfGeneration <= 5)
                {
                    break;
                }
            }

            return typesOfGeneration;

        } //End Fonction

        /// <summary>
        /// Sizes the of world.
        /// </summary>
        /// <returns>The of world.</returns>
        /// <param name="charsetSelecting">Charset selecting.</param>
        /// <param name="numberOfChar">Number of char.</param>
        /// <param name="typesAtGenerate">Types at generate.</param>

	    internal byte SizeOfWorld(List<string> charsetSelecting, byte numberOfChar, int typesAtGenerate)
        {
            bool b = true;
            while (b)
            {
                try
                {

                    SetColorThemes();
                    Console.Write(lang.GetString("SizeOfWorld"));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    b = byte.TryParse(Console.ReadLine(), out numberOfChar);                                         
                    Console.ResetColor();

                    if (b)
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

        /// <summary>
        /// Repete character in Generate string
        /// </summary>
        /// <param name="repeat"></param>
        /// <returns></returns>

	    internal bool Repetition(bool repeat)
        {           

            while (true)
            {
                SetColorThemes();
                Console.Write(lang.GetString("Repetition"));
                SetColorAsk();

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo info = Console.ReadKey(true);
                    Console.ResetColor();

                    if (info.Key == ConsoleKey.Y)
                    {
                        repeat = true; // repeat character in methode combinaison
                        break; // close the while
                    }
                    if (info.Key == ConsoleKey.N)
                    {
                        repeat = false; // no repeat character in methode combinaison
                        break; // close the while
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

        /// <summary>
        /// Changes the startblock pattern.
        /// </summary>
        /// <returns>The startblock pattern.</returns>
        /// <param name="charsetSelecting">Charset selecting.</param>

	    internal List<string> ChangeStartblockPattern(List<string> charsetSelecting)
        {
            Utility obj = new Utility();

            while (true)
            {
                SetColorThemes();
                Console.Write(lang.GetString("ChangeStartblockPattern"));
                SetColorAsk();


                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo info = Console.ReadKey(true);
                    Console.ResetColor();

                    if (info.Key == ConsoleKey.Y)
                    {

                        Console.Write("   " + lang.GetString("ChangeStartblockPattern1"));

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string s = Console.ReadLine();
                        Console.ResetColor();

                        if (s.Length >= 2 | s != null)
                        {
                            obj.StartblockPattern(s, charsetSelecting);

                            break;
                        }
                    }
                    if (info.Key == ConsoleKey.N)
                    {
                        break;
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
        }// End Fonction

        /// <summary>
        /// Changes the endblock pattern.
        /// </summary>
        /// <returns>The endblock pattern.</returns>
        /// <param name="charsetSelecting">Charset selecting.</param>
        /// <param name="numberOfChar">Number of char.</param>

        internal List<string> ChangeEndblockPattern(List<string> charsetSelecting, byte numberOfChar)
        {
            Utility obj = new Utility();

            while (true)
            {
                SetColorThemes();
                Console.Write(lang.GetString("ChangeEndblockPattern"));
	                
                SetColorAsk();
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo info = Console.ReadKey(true);
                    Console.ResetColor();

                    if (info.Key == ConsoleKey.Y)
                    {

                        Console.Write(lang.GetString("ChangeEndblockPattern1"));

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string s = Console.ReadLine();
                        Console.ResetColor();

                        if (s.Length >= 2 | s != null)
                        {
                            obj.EndPattern(s, numberOfChar, charsetSelecting);
                            break;
                        }
                    }
                    if (info.Key == ConsoleKey.N)
                    {
                        break;
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

        /// <summary>
        /// Reverses the patern.
        /// </summary>
        /// <returns>The patern.</returns>
        /// <param name="charsetSelecting">Charset selecting.</param>

	    internal List<string> ReversePatern(List<string> charsetSelecting)
        {           

            while (true)
            {
                SetColorThemes();
                Console.Write(lang.GetString("ReversePatern"));

                SetColorAsk();

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    Console.ResetColor();

                    if (keyInfo.Key == ConsoleKey.N)
                    {
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.Y)
                    {
                        charsetSelecting.Reverse();
                        break;
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

        /// <summary>
        /// Mixs the patern.
        /// </summary>
        /// <returns>The patern.</returns>
        /// <param name="charsetSelecting">Charset selecting.</param>
        /// <param name="numberOfChar">Number of char.</param>

	    internal List<string> MixPatern(List<string> charsetSelecting, int numberOfChar)
        {

            while (true)
            {
                SetColorThemes();
                Console.Write(lang.GetString("MixPatern"));

                SetColorAsk();

                //string s = String.Empty;

                //for (int i = 0; i < charsetSelecting.Count; i++)
                //{
                //    s += charsetSelecting[i];
                //}
                //Console.Write("\n");
                //Console.WriteLine(lang.GetString("Before") +" : {0} ", s);

                //s = null;
                //List<string> tmp = new List<string>();
                //tmp = Utility.MixOrderList(charsetSelecting).Distinct().ToList();

                //for (int i = 0; i < tmp.Count; i++)
                //{
                //    s += tmp[i];
                //}

                //Console.WriteLine(lang.GetString("After") + " {0} ", s);

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    Console.ResetColor();

                    if (keyInfo.Key == ConsoleKey.N)
                    {
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.Y)
                    {
                        Utility tools = new Utility();
                        charsetSelecting = tools.MixOrderList(charsetSelecting);
                        break;
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


        /// <summary>
        /// Sizes the file.
        /// </summary>
        /// <returns>The file.</returns>
        /// <param name="saveFile">If set to <c>true</c> save file.</param>
        /// <param name="numberOfChar">Number of char.</param>
        /// <param name="typesAtGenerate">Types at generate.</param>
        /// <param name="numberOfAllCombination">Number of all combination.</param>

	    internal BigInteger SizeFile(bool saveFile, int numberOfChar, int typesAtGenerate, BigInteger numberOfAllCombination)
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
                        SetColorThemes();
                        Console.Write(lang.GetString("SizeFile"));
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        sizeFiles = Console.ReadLine();                        
                        Console.ResetColor();
	                        
                        int sizFilesInMB = 0;

                        if (Int32.TryParse(sizeFiles, out sizFilesInMB))
                        {
                            sizFilesInMB *= 1048576;
                            numberLine = info.CalculSizeFile(sizFilesInMB, numberOfChar, typesAtGenerate, numberOfAllCombination);
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


        /// <summary>
        /// Saves the charset in files text.
        /// </summary>
        /// <returns><c>true</c>, if charset in files text was saved, <c>false</c> otherwise.</returns>

	    internal bool SaveCharsetInFilesTxt()
        {
            bool b = true;
            bool saveFile = false;
            while (b)
            {
                try
                {
                    SetColorThemes();
                    Console.Write(lang.GetString("SaveCharsetInFilesTxt"));

                    SetColorAsk();                                                           

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

        /// <summary>
        /// Saves the charset in files zip.
        /// </summary>
        /// <returns><c>true</c>, if charset in files zip was saved, <c>false</c> otherwise.</returns>

	    internal bool SaveCharsetInFilesZip()
        {
            Error:
            bool b = true;
            bool zip = false;

            while (b)
            {
                try
                {
                    SetColorThemes();
                    Console.Write(lang.GetString("SaveCharsetInFilesZip"));

                    SetColorAsk();

                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);                   
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
                    goto Error;

                }
            }           
	        
            return zip;
        } // End Fonction

        /// <summary>
        /// Paths the of buckup files.
        /// </summary>
        /// <returns>The of buckup files.</returns>

	    internal string PathOfBuckupFiles()
        {  
            Error:
            string pathSaveFiles = null;

            while (true)
            {
                try
                {
                    SetColorThemes();
                    Console.Write(lang.GetString("PathOfBuckupFiles"));

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    pathSaveFiles = Console.ReadLine();                    
                    Console.ResetColor();

                    string controle = Path.GetFullPath(pathSaveFiles).ToString();
	                 
                    if (pathSaveFiles != String.Empty/* & pathBinCrisisDenie != controle*/)
                    {
                        SetColorThemes();
                        Console.Write(lang.GetString("PathOfBuckupFiles1") + " {0} ", controle);

                        SetColorAsk();

                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
	                        
                        Console.Write("\n");
                        Console.ResetColor();

                        if (keyInfo.Key == ConsoleKey.Y)
                        {
                            if (!System.IO.Directory.Exists(pathSaveFiles))
                                Directory.CreateDirectory(pathSaveFiles);
                            break;
                        }
                        else if (keyInfo.Key == ConsoleKey.N)
                        {                            
                            break;
                        }
                    }
	                    

                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                    goto Error;
                        
                }
            }

            return pathSaveFiles;
        } // End Fonction

        /// <summary>
        /// Menus the read file text.
        /// </summary>
        /// <returns>The read file text.</returns>

	    internal List<string> MenuReadFileTxt()
        {
            Error:
            bool b = true;
            List<string> charsetSelecting = new List<string>();

            try
            {				
                while (b)
                {
                    SetColorThemes();
                    Console.Write(lang.GetString("Patch"));

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string charsetName = Console.ReadLine().ToLower();
                    Console.ResetColor();
                    charsetSelecting = Utility.ReadFileTxt(charsetName, charsetSelecting);

                    if (charsetSelecting != null)
                    {
                        b = false;
                    }
                }
                return charsetSelecting;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", ex.Message);
                Console.ResetColor();
                goto Error;
            }
	            
	            
        }

	    internal static void PleaseWait()
        {
            Utility objHour = new Utility();
	            
            Console.Write("\n{0} : ", objHour.Hour());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(lang.GetString("Working") + "\n");
            Console.ResetColor();            
        }

	    internal static string ExtensionFileOutputPath(bool zip)
        {
            string extension = string.Empty;
            if (zip)
                extension = ".zip";
            else
                extension = "txt";

            return extension;
	            
        }

	        internal static void Instruction()
	        {
	            Console.Write("\n");
	            SetColorThemes();
	            
	            Console.WriteLine(lang.GetString("Instruction"));
	        }

	        internal List<string> ProfilsPersonPassword(List<string> charsetSelecting)
	        {
                Error:
	            try
	            {                
	                Console.Write("\n\n");
	                SetColorThemes2();
	                Console.Write("First Name : ");
	                string name = UserPasswordProfiler.CustomCharsetWord();                

	                SetColorThemes2();
	                Console.Write("Surname : ");
	                string surname = UserPasswordProfiler.CustomCharsetWord();                                 

	                charsetSelecting = UserPasswordProfiler.InitialPersonne(charsetSelecting, name, surname);


	                SetColorThemes2();
	                Console.Write("Nickname : ");
	                charsetSelecting.Add(UserPasswordProfiler.CustomCharsetWord());
	                
	                charsetSelecting = BirthdateMenu(charsetSelecting);

	            }
	            catch (Exception e)
	            {
	                Console.ForegroundColor = ConsoleColor.Red;
	                Console.WriteLine(" {0} \n", e.Message);
	                Console.ResetColor();
                    goto Error;
	            }

	            return charsetSelecting;
	        }

	        private List<string> ProfilsPersonChildPassword(List<string> charsetSelecting)
	        { 
                Error:
	            try
	            {
	                Console.Write("\n\n");
	                SetColorThemes2();
	                Console.Write("Child's name  ");
	                Console.Write("\n");
	                charsetSelecting = CustomWordMenu(charsetSelecting);

	                SetColorThemes2();
	                Console.Write("Child's nickname ");
	                Console.Write("\n");
	                charsetSelecting = CustomWordMenu(charsetSelecting);

	                charsetSelecting = BirthdateMenu(charsetSelecting);
	            }
	            catch (Exception e)
	            {
	                Console.ForegroundColor = ConsoleColor.Red;
	                Console.WriteLine(" {0} \n", e.Message);
	                Console.ResetColor();
                    goto Error;
	            }

	            return charsetSelecting;
	        }

	    private List<string> ProfilsPersonPartnePassword(List<string> charsetSelecting)
        {
            Error:
            try
            {
                Console.Write("\n\n");
                SetColorThemes2();
                Console.Write("Partners name: ");
                charsetSelecting.Add(UserPasswordProfiler.CustomCharsetWord());
                if (String.IsNullOrEmpty(charsetSelecting[charsetSelecting.Count - 1]))
                    charsetSelecting.RemoveAt(charsetSelecting.Count - 1);
                SetColorThemes2();
                Console.Write("Partners nickname: ");
                charsetSelecting.Add(UserPasswordProfiler.CustomCharsetWord());
                if (String.IsNullOrEmpty(charsetSelecting[charsetSelecting.Count - 1]))
                    charsetSelecting.RemoveAt(charsetSelecting.Count - 1);
                charsetSelecting = BirthdateMenu(charsetSelecting);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
                goto Error;
            }

            return charsetSelecting;
        }

	    internal List<string> PetNameAnimal(List<string> charsetSelecting)
        {
            Error:
            try
            {
                Console.Write("\n");
                SetColorThemes2();
                Console.Write("Pet's name : ");
                Console.Write("\n");
                charsetSelecting = CustomWordMenu(charsetSelecting);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
                goto Error;
            }

            return charsetSelecting;
        }

        internal static List<string> CustomWordMenu(List<string> charsetSelecting)
        {          
            
            try
            {
                while (true)
                {
                    Instruction();
                    ConsoleKeyInfo quit = Console.ReadKey();
                    if (quit.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
	                    
                    SetColorThemes();
                    Console.WriteLine(lang.GetString("EnterWorld"));
                    Console.Write("\n");
                    SetColorThemes2();
                    charsetSelecting.Add(UserPasswordProfiler.CustomCharsetWord());
                    if (String.IsNullOrEmpty(charsetSelecting[charsetSelecting.Count - 1]))
                        charsetSelecting.RemoveAt(charsetSelecting.Count - 1);
                   

                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
            }

            return charsetSelecting;
        }


	    private List<string> BirthdateMenu(List<string> charsetSelecting)
        {
            Error: 
            Instruction();
            try
            {
                SetColorThemes();
                Console.Write("Birthdate (DDMMYYYY): ");
                Console.Write("\n");

                ConsoleKeyInfo quit;
                quit = Console.ReadKey();

                while (quit.Key != ConsoleKey.Escape)
                {
                    SetColorThemes();
                    Console.WriteLine("Please enter the Birthdate ");

                    Console.Write("\n");
                    SetColorThemes2();
                    charsetSelecting = UserPasswordProfiler.BirthdatePerson(charsetSelecting);
                    if (String.IsNullOrEmpty(charsetSelecting[charsetSelecting.Count - 1]))
                        charsetSelecting.RemoveAt(charsetSelecting.Count - 1);

                    Console.WriteLine("\n" + lang.GetString("EnterOrEchap"));
                    Console.Write("\n");
                    quit = Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
                goto Error;
            }

            return charsetSelecting;

        }

	    internal List<string> CustomCharsetSpecialMenu(List<string> charsetSelecting)
        {            
            Error:                 
            try
            {
                 
                Console.Write("\n");
                SetColorThemes();

                Console.Write(lang.GetString("AddSpecialChar"));
                ConsoleKeyInfo yes = Console.ReadKey();

                if (yes.Key == ConsoleKey.Y)
                {
                    charsetSelecting = UserPasswordProfiler.CustomCharsetSpecial(charsetSelecting);
                }
            }
            catch (Exception e)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
                goto Error;

            }
            return charsetSelecting;
        }

	    internal List<string> CustomCharsetNumberMenu(List <string> charsetSelecting)
        {
            Error: 	                     

            try
            {
                SetColorThemes();
                Console.Write(lang.GetString("AddNumber"));
                ConsoleKeyInfo yes = Console.ReadKey();

                if (yes.Key == ConsoleKey.Y)
                    return   charsetSelecting = UserPasswordProfiler.CustomCharsetNumber(charsetSelecting);
	                                  
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
                goto Error;
            }

            return charsetSelecting;
        }

	    internal static List<string> CustomChartsetL33tSpeekMenu(List<string> charsetSelecting)
        {
            Error:
            try
            {
                 
                Console.Write("\n");
                SetColorThemes();
                Console.Write("Leet mode ? (i.e. leet = 1337) Y/[N]: ");
                ConsoleKeyInfo yes = Console.ReadKey();
                if (yes.Key == ConsoleKey.Y)
                {
                    TransformTextFiles obj = new TransformTextFiles();

                    int count = charsetSelecting.Count;

                    for (int i = 0; i < count; i++)
                    {
                        charsetSelecting.Add(obj.ConverterInLeetSpeak(charsetSelecting[i].ToString()));
                    }
                }
                return charsetSelecting;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
                goto Error;
            }


        }


	    internal List<string> CustomCharsetUpperMenu(List<string> charsetSelecting)
        {

            Error:
            try
            {                  
                Console.Write("\n");
                SetColorThemes();
                Console.Write("LOWERCASE TO UPPERCASE Y/[N]: ");

                ConsoleKeyInfo yes = Console.ReadKey();

                if (yes.Key == ConsoleKey.Y)
                    return charsetSelecting = UserPasswordProfiler.CustumCharsetUpperCase(charsetSelecting);               
                return charsetSelecting;          
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
                goto Error;
            }


        }

	    internal List<string> CustomCharsetLowerMenu(List<string> charsetSelecting)
        {
            Error:          

            try
            {
                Console.Write("\n");
                SetColorThemes();
                Console.Write("UPPERCASE TO LOWERCASE Y/[N]: ");
                ConsoleKeyInfo yes = Console.ReadKey();

                if (yes.Key == ConsoleKey.Y)
                    return charsetSelecting = UserPasswordProfiler.CustumCHarsetLowerCase(charsetSelecting);
	               
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
                goto Error;
            }

            return charsetSelecting;
	            
        }

        internal void DisplayCustomCharset(List<string> charsetSelecting)
        {
            Error:
            try
            {                
                Console.Write("\n");
                SetColorThemes();
                Console.Write("Do you want display custom charset ? Y/[N]: ");

                ConsoleKeyInfo yes = Console.ReadKey();

                if (yes.Key == ConsoleKey.Y)
                {
                    foreach (var item in charsetSelecting)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", ex.Message);
                Console.ResetColor();
                goto Error;
            }
        }
	        
	    internal List<string> AddWordlist(List<string> charsetSelecting)
        {
            Error:
            try
            {
                
                Console.Write("\n");
                SetColorThemes();
                Console.Write("Do you want to add your wordlist ? Y/[N]: ");

                ConsoleKeyInfo yes = Console.ReadKey();

                if (yes.Key == ConsoleKey.Y)
                {
                    this.MenuReadFileTxt();
                }

                return charsetSelecting;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", ex.Message);
                Console.ResetColor();
                goto Error;
            }
        }

	    internal List<string> AddWorldInList(List<string> charsetSelecting)
        {
            Error:
            try
            {                
                Console.Write("\n\n");
                SetColorThemes();
                Console.Write("Do you want to add some key words about the victim [i.e. actor,religion,color] ?");
                Console.Write("\n");
                return charsetSelecting = CustomWordMenu(charsetSelecting);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", ex.Message);
                Console.ResetColor();
                goto Error;
            }
	            
        }       

	    internal List<string> Company(List<string> charsetSelecting)
        {
            Error:
            try
            {
               
                Console.Write("\n");
                SetColorThemes2();
                Console.Write("Company name : ");
                Console.Write("\n");
                return charsetSelecting = CustomWordMenu(charsetSelecting);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", ex.Message);
                Console.ResetColor();
                goto Error;
            }
	            
        }

    

    

	        

	    internal List<string> UserPasswordProfilerCharset(List<string> charsetSelecting)
        {

            Console.Write("\n\n");
            SetColorThemes();
            Console.Write("Insert the informations about the victim to make a dictionary ");
            Console.Write("\n");
            SetColorThemes();
            Console.Write("If you don't know all the info, just hit escape when asked! ;)");

            try
            {
                charsetSelecting = ProfilsPersonPassword(charsetSelecting);           
                charsetSelecting = ProfilsPersonPartnePassword(charsetSelecting);
                // charsetSelecting = Utility.RemoveDuplicate(charsetSelecting); // Function bugger
                charsetSelecting = ProfilsPersonChildPassword(charsetSelecting);
                // charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);  // Function bugger
                charsetSelecting = PetNameAnimal(charsetSelecting);
                //charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);
                charsetSelecting = PetNameAnimal(charsetSelecting);
                //charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);
                charsetSelecting = Company(charsetSelecting);
                //charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);
                charsetSelecting = AddWorldInList(charsetSelecting);
                //charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);
                charsetSelecting = AddWordlist(charsetSelecting);
                //charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);
                charsetSelecting = CustomCharsetLowerMenu(charsetSelecting);
                //charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);
                charsetSelecting = CustomCharsetUpperMenu(charsetSelecting);
                //charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);
                charsetSelecting = CustomChartsetL33tSpeekMenu(charsetSelecting);
                //charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);
                charsetSelecting = CustomCharsetSpecialMenu(charsetSelecting);
                //charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);            
                charsetSelecting = CustomCharsetNumberMenu(charsetSelecting);
                //charsetSelecting = Utility.RemoveDuplicate(charsetSelecting);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", ex.Message);
                Console.ResetColor();	
            }
	            

            return charsetSelecting;
        }

	        
    } //End class
} // End Namespace
