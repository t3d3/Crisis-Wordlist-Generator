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
using System.Numerics;

namespace crisis
{
    public class Parameter  
    {
        private bool b;

        private static bool saveFile;
        public static bool SaveFile
        {
            get { return Parameter.saveFile; }
            set { Parameter.saveFile = value; }
        }
        
        private static int typesOfGeneration;
        public static int TypesOfGeneration
        {
            get { return Parameter.typesOfGeneration; }
            set { Parameter.typesOfGeneration = value; }
        }

        private static byte numberOfChar;

        public static byte NumberOfChar
        {
            get { return Parameter.numberOfChar; }
            set { Parameter.numberOfChar = value; }
        }

        private static BigInteger numberLine;
        public static BigInteger NumberLine
        {
            get { return Parameter.numberLine; }
            set { Parameter.numberLine = value; }
        }

        private static bool withoutOrWithRepetition;
        public static bool WithoutOrWithRepetition
        {
            get { return Parameter.withoutOrWithRepetition; }
            set { Parameter.withoutOrWithRepetition = value; }
        }

        private static bool booleanZip;
        public static bool BooleanZip
        {
            get { return Parameter.booleanZip; }
            set { Parameter.booleanZip = value; }
        }

        private static byte iExtension;

        public static byte IExtension
        {
            get { return Parameter.iExtension; }
            set { Parameter.iExtension = value; }
        }

        public Parameter()
        {
            numberLine = 1;
            iExtension = 0;
            b = true;
            withoutOrWithRepetition = false;
            saveFile = false;
            booleanZip = false;
        }


        internal void TypesOfFileAtGenerate()
        {
            byte i = 1;
            b = true;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t Charset for Crunch");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t Combinations");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t Random ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t Variations ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t Permutations");
            

            while (b)
            {
                try
                {
                    Console.Write("\n Type the number corresponding to the menu : ");
                    
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    typesOfGeneration = int.Parse(Console.ReadLine().ToLower());
                    Console.ResetColor();

                    if (typesOfGeneration == 1 | typesOfGeneration == 2 | typesOfGeneration == 3 | typesOfGeneration == 4 | typesOfGeneration == 5)
                    {
                        b = false;
                        SubMenu.BooleanSubMenu = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n {0} does not exist", typesOfGeneration);
                        Console.ResetColor();                        
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

        } //End Fonction

        internal void SizeOfWorld()
        {
            b = true;
            while (b)
            {
                Console.Write("\n What is the size of your charset : ");
                numberOfChar = byte.Parse(Console.ReadLine());

                try
                {
                    if (typesOfGeneration == '1' | typesOfGeneration == '2')
                    {
                        if (numberOfChar > Charset.CharsetSelecting.Count)
                        {
                            Console.WriteLine(" The number of character is too large to generate\n a caratère chain without rehearsal");
                            b = false;
                        }
                        else if (numberOfChar == Charset.CharsetSelecting.Count)
                        {
                            Console.WriteLine(" The number of characters must be smaller for combinations without repetition");
                            b = false;
                        }
                    }
                    else if (numberOfChar != 0)
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
        } // End Fonction

        internal void Repetition()
        {
            b = true;
            char asKwithoutOrWithRepetition = 'n';

            while (b)
            {
                Console.Write("\n Would you a repeating of character ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" n ");
                Console.ResetColor();
                Console.Write("] : ");

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    asKwithoutOrWithRepetition = char.Parse(Console.ReadLine());
                    Console.ResetColor();

                    if (asKwithoutOrWithRepetition == 'y')
                    {
                        withoutOrWithRepetition = true;
                        b = false;
                    }
                    if (asKwithoutOrWithRepetition == 'n')
                    {
                        withoutOrWithRepetition = false;
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
        } // End Fonction

        internal void ChangeStartblockPattern()
        {
            Tools obj = new Tools();
            b = true;
            char asKChangeStartblockPattern = 'n';

            while (b)
            {
                Console.Write("\n Do you want to specify a starting chain ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" n ");
                Console.ResetColor();
                Console.Write("] : ");

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    asKChangeStartblockPattern = char.Parse(Console.ReadLine());
                    Console.ResetColor();

                    if (asKChangeStartblockPattern == 'y')
                    {

                        Console.Write("\n Write the starting string : ");

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string s = Console.ReadLine();
                        Console.ResetColor();

                        if (s.Length >= 2 | s != null)
                        {
                            obj.StartblockPattern(s);

                            b = false;
                        }                       
                    }
                    if (asKChangeStartblockPattern == 'n')
                    {
                        withoutOrWithRepetition = false;
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
        } // End Fonction

        internal void ChangeEndblockPattern()
        {
            Tools obj = new Tools();
            b = true;
            char asKChangeEndblockPattern = 'n';

            while (b)
            {
                Console.Write("\n Do you want to specify a ending chain ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" n ");
                Console.ResetColor();
                Console.Write("] : ");

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    asKChangeEndblockPattern = char.Parse(Console.ReadLine());
                    Console.ResetColor();

                    if (asKChangeEndblockPattern == 'y')
                    {

                        Console.Write("\n Write the end string : ");

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string s = Console.ReadLine();
                        Console.ResetColor();

                        if (s.Length >= 2 | s != null)
                        {
                            obj.EndPattern(s);
                            b = false;
                        }
                    }
                    if (asKChangeEndblockPattern == 'n')
                    {
                        withoutOrWithRepetition = false;
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
        } // End Fonction

        internal void SaveCharsetInFilesTxt()
        {
            char askSaveFile = 'n';
            b = true;

            while (b)
            {
                try
                {
                    Console.Write("\n Do you want to save the output to a file [");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" y ");
                    Console.ResetColor();
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" n ");
                    Console.ResetColor();
                    Console.Write("] : ");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    askSaveFile = char.Parse(Console.ReadLine().ToLower());
                    Console.ResetColor();

                    if (askSaveFile == 'n')
                    {
                        SaveFile = false;
                        b = false;
                    }                   
                     else if (askSaveFile == 'y')	
                    {
                        SaveFile = true;
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


            if (saveFile)
            {
                Statistical info = new Statistical();
                b = true;
                string sizeFiles = null;

                while (b)
                {
                    try
                    {
                        Console.Write("\n What size should a save file in MB : ");
                        sizeFiles = Console.ReadLine();
                        int sizFilesInMB = 0;

                        if (Int32.TryParse(sizeFiles, out sizFilesInMB))
                        {
                            sizFilesInMB *= 1048576;
                            Statistical.DefaultSizeFileInOctet = sizFilesInMB;
                            info.CalculSizeFile();
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

                b = true;

                while (b)
                {
                    try
                    {
                        Console.Write("\n You want to compress them into zip file [ ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" y ");
                        Console.ResetColor();
                        Console.Write("/");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" n ");
                        Console.ResetColor();
                        Console.Write("] : ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        char zip = char.Parse(Console.ReadLine());
                        Console.ResetColor();

                        if (zip == 'y')
                        {
                            iExtension = 1;
                            booleanZip = true;
                            b = false;
                        }
                        else if (zip == 'n')
                        {
                            iExtension = 0;
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
        }
        // End Fonction

        internal void ReversePaterne()
        {
            char reverseListCharsetSelecting = 'n';
            b = true;

            while (b)
            {
                
                Console.Write("\n Want to reverse the pattern ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen; 
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen; 
                Console.Write(" n ");
                Console.ResetColor();                
                Console.Write("] : ");
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen; 
                    reverseListCharsetSelecting = char.Parse(Console.ReadLine().ToLower());
                    Console.ResetColor(); 

                    if (reverseListCharsetSelecting.ToString().ToLower() == "n")
                    {
                        b = false;
                    }
                    else if (reverseListCharsetSelecting.ToString().ToLower() == "y")
                    {
                        Charset.CharsetSelecting.Reverse();
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
        } // End Fonction       


        
    }// End class
} // End Namespace
