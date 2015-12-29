//
//  Parameter.cs
//
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
               
        private int sizeCharset;

        private static int saveFile;
        public static int SaveFile
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

        private static int numberOfChar;
        public static int NumberOfChar
        {
            get { return Parameter.numberOfChar; }
            set { Parameter.numberOfChar = value; }
        }
        

        private static int numberLine = 1;

        public static int NumberLine
        {
            get { return Parameter.numberLine; }
            set { Parameter.numberLine = value; }
        }

        public Parameter()
        {
            
        }
        
        internal void TypesOfFileAtGenerate()
        {
                           
                bool b = true;

                Console.WriteLine("\n 1)\t Charset for Crunch");
                Console.WriteLine(" 2)\t Enumeration");
                Console.WriteLine(" 3)\t Random ");

                while (b)
                {
                    try
                    {
                        Console.Write("\n Type the number corresponding to the menu : ");
                        typesOfGeneration = int.Parse(Console.ReadLine().ToLower());

                        if (typesOfGeneration == 1 | typesOfGeneration == 2 | typesOfGeneration == 3)
                        {
                            b = false;
                            SubMenu.BooleanSubMenu = false;
                        }
                        else
                        {
                            Console.WriteLine("\n {0} does not exist", typesOfGeneration);
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
       
        internal void SizeOfWorld ()
        {                       
            bool b = false;
            while (b == false)
            {
                Console.Write("\n What is the size of your charset : ");

                try
                {
                    b = int.TryParse(Console.ReadLine().ToLower(), out sizeCharset);
                    numberOfChar = +sizeCharset;

                    if (sizeCharset < 2 | sizeCharset > 128)
                    {
                        Console.WriteLine(" Type a number between 2 and 128 please !");
                        b = false;
                    }
                    else if (typesOfGeneration == '1' | typesOfGeneration == '2')
                    {
                        if (sizeCharset > Charset.CharsetSelecting.Count)
                        {
                            Console.WriteLine(" The number of character is too large to generate\n a caratère chain without rehearsal");
                            b = false;
                        }
                        else if (sizeCharset == Charset.CharsetSelecting.Count)
                        {

                            Console.WriteLine(" The number of characters must be smaller for combinations without repetition");
                            b = false;
                        }
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(" Type the size of your charset\n {0} ",e.Message);
                    b = false;
                }
            }
        }

        internal void SaveCharsetInFilesTxt()
        {
            Console.WriteLine("\n 1) Yes");
            Console.WriteLine(" 2) No\n");            

            bool b = true;
            while (b)
            {
                try
                {
                    Console.Write(" Do you want to save the output to a file : ");
                    int.TryParse(Console.ReadLine().ToLower(), out saveFile); 
                    
                    if (saveFile == 1 | saveFile == 2)
                    {
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

            
                Statistical info = new Statistical();


                BigInteger numberCombination = info.CalculOfAllCombinaison();

                if (saveFile == 1)
                {
                    int outExeptionMemory = info.CalculSizeFile();
                    bool b1 = true;
                    string Howline = null;

                    while (b1)
                    {
                        try
                        {
                            Console.Write("\n How many line you want in a file ?  (Empty for default : {0}) : ", Parameter.NumberLine);

                            Howline = Console.ReadLine().ToLower();

                            if (int.Parse(Howline) > outExeptionMemory)
                            {
                                Console.WriteLine("\n Number of lines excessive.\n The number of lines is replaced by {0} = 400 Mo", outExeptionMemory);
                                numberLine = outExeptionMemory;
                                b1 = false;
                            }
                            else if (int.Parse(Howline) < 128)
                            {
                                Console.WriteLine("\n Type a number greater than 128 please !");
                                b1 = true;
                            }
                            else if (Howline != null)
                            {
                                numberLine = Int32.Parse(Howline);
                                b1 = false;
                            }

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n Number  of lines by default\n");
                            numberLine = outExeptionMemory;
                            b1 = false;
                        }
                    }

                    if (typesOfGeneration == 3)
                    {
                        bool b2 = true;

                        while (b2)
                        {
                            if ((UInt64)numberLine > numberCombination)
                            {
                                numberLine /= 2;
                                b2 = true;
                            }
                            else
                            {
                                b2 = false;
                            }
                        }
                    }
            }
        }
        // End Fonction

        internal void ReversePaterne()
        {
            
            char reverseListCharsetSelecting = 'n';
            bool b = true;
            while (b)
            {
                Console.Write("\n Want to reverse the pattern ? [ y / n ] : ");
                try
                {
                    reverseListCharsetSelecting = char.Parse(Console.ReadLine().ToLower());
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

        
// End Fonction

        
         
    }// End class
} // End Namespace
