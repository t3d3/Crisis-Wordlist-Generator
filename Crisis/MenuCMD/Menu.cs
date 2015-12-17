//
//  Menu.cs
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

namespace crisis
{
    public class Menu : Generate 
    {
        private int dislayMainSubMain;
        private bool booleanSubMenu = true;
        private int sizeCharset;
        private int typesOFProcedure;
        private  int saveFileAsk;

        public Menu()
        {
        }

        public void Navigation ()
        {
            MainMenu();
            TypesOfFileAtGenerate();

            if (typesOFProcedure == 0 || typesOFProcedure == 1)
            {
                SizeOfWorld();
                SaveCharsetInFilesTxt();
                CharsetCrunch();
            } else if (typesOFProcedure == 2)
            {
                SizeOfWorld();
                SaveCharsetInFilesTxt();
                Wordlist();
                Console.ReadKey();
            } 
            else if (typesOFProcedure == 3)
            {
                SaveCharsetInFilesTxt();
                L33tSpeek();
            }

        } // End Fonction

        public void MainMenu()
        {

            Console.WriteLine(" Crisis Wordlist Generator  by Teeknofil, version : 1.0.7");
            Console.WriteLine(" Thanks WarLocG for the debugging et fix bug");
            Console.WriteLine(" FAQ:  www.crack-wifi.com/forum/index.php");
            Console.WriteLine(" Trouble: http://www.kali-linux.fr/forum/index.php");

            Console.WriteLine("\n N°\tDESCRIPTION \n");
            int i = 0;
            
            Console.WriteLine(" {0})\t HEXA", i++);
            Console.WriteLine(" {0})\t NUMBER", i++);
            Console.WriteLine(" {0})\t LEET\t SPEAK", i++);
            Console.WriteLine(" {0})\t SPECIAL CHARACTER", i++);
                
            Console.WriteLine(" {0})\t LATIN\t    CHARACTER UPPERCASE", i++);
            Console.WriteLine(" {0})\t LATIN\t    CHARACTER LOWERCASE", i++);
            Console.WriteLine(" {0})\t LATIN\t    CHARACTER UPPERCASE & LOWERCASE", i++);                                

            Console.WriteLine(" {0})\t SWEDISH    CHARACTER UPPERCASE", i++);
            Console.WriteLine(" {0})\t SWEDISH    CHARACTER LOWERCASE", i++);
            Console.WriteLine(" {0})\t SWEDISH    CHARACTER UPPERCASE & LOWERCASE", i++);
                
            Console.WriteLine(" {0})\t SYLLABLE   CHARACTER UPPERCASE", i++);
            Console.WriteLine(" {0})\t SYLLABLE   CHARACTER LOWERCASE", i++);
            Console.WriteLine(" {0})\t SYLLABLE   CHARACTER UPPERCASE & LOWERCASE", i++);


            while (booleanSubMenu)
            {
                try
                {
                    Console.Write("\n");
                    Console.Write(" \nWith what category you want to work : ");
                    dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    i = 0;

                    if (dislayMainSubMain == i++)
                        MenuHexa();
                    if (dislayMainSubMain == i++)
                        MenuNumeric();
                    if (dislayMainSubMain == i++)
                        MenuLeetSpeak();
                    if (dislayMainSubMain == i++)
                        MenuSpecialCharacteres();
                    //LATIN    CHARACTER
                    if (dislayMainSubMain == i++)
                        LatinCharacteUppercase();
                    if (dislayMainSubMain == i++)
                        LatinCharacterLowercase();
                    if (dislayMainSubMain == i++)
                        LatinCharacterUppercaseLowercase();                                       
                    // SWEDISH    CHARACTER    
                    if (dislayMainSubMain == i++)
                        SwddishCharacterUppercase();
                    if (dislayMainSubMain == i++)
                        SwddishCharacterLowercase();
                    if (dislayMainSubMain == i++)
                        SwddishCharacterLowercaseUppercase();
                    //SYLLABLE   CHARACTER
                    if (dislayMainSubMain == i++)
                        SyllableCharacteUppercase();
                    if (dislayMainSubMain == i++)
                        SyllableCharacterLowercase();
                    if (dislayMainSubMain == i++)
                        SyllableCharacterUppercaseLowercase();

                } 
                catch (FormatException)
                {
                    Console.Write("\n Enter the number corresponding to your choice !");
                }                
            }
        }

        public void TypesOfFileAtGenerate()
        {
            if (typesOfGeneration == 3)
            {
                typesOfGeneration += typesOFProcedure;
            } 
            else
            {
                bool b = false;

                Console.WriteLine("\n 0)\t Charset Generator for Crunch without repetition");
                Console.WriteLine(" 1)\t Combination without repetition");
                Console.WriteLine(" 2)\t Random with repetition\n\n ");

                while (b == false)
                {
                    try
                    {
                        Console.Write(" Type the number corresponding to the menu : ");
                        b = int.TryParse(Console.ReadLine(), out typesOFProcedure);

                        if (typesOFProcedure == 0 | typesOFProcedure == 1 | typesOFProcedure == 2)
                        {
                            b = true;
                            typesOfGeneration += typesOFProcedure;
                        }
                        else
                        {
                            b = false;
                        }

                    }
                    catch (FormatException)
                    {
                        b = false;
                    }
                }
            }
        } //End Fonction
       
        public void SizeOfWorld ()
        {
            bool b = false;

            while (b == false)
            {
                Console.Write("\n What is the size of your charset : ");

                try
                {
                    b = int.TryParse(Console.ReadLine(), out sizeCharset);
                    NumberOfChar = +sizeCharset;

                    if (sizeCharset < 2 | sizeCharset > 128)
                    {
                        Console.WriteLine(" Type a number between 2 and 128 please !");
                        b = false;
                    }
                    else if (typesOFProcedure == '1' | typesOFProcedure == '2')
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
                catch (FormatException)
                {
                    Console.WriteLine(" Type the size of your charset ");
                    b = false;
                }
            }
        }

        public void SaveCharsetInFilesTxt()
        {          
            
            Console.WriteLine("\n 1) Yes");
            Console.WriteLine(" 2) No\n");
            

            bool b = true;
            while (b)
            {
                try
                {
                    Console.Write(" Do you want to save the output to a file : ");
                    int.TryParse(Console.ReadLine(), out saveFileAsk); 
                    
                    if (saveFileAsk == 1 | saveFileAsk == 2)
                    {
                        b = false;
                        SaveFile += saveFileAsk;                 
                        
                    }                    
                     else
                    {
                        b = true;
                    }

                } 
                catch (FormatException)
                {
                    b = true;
                }
            }
        }
        // End Fonction
        

        private void ReturnMainMenu()
        {
            Console.Write(" 99\t\t\t\t Back to main menu\n\n");

            if (Charset.CharsetName == "99")
            {
                Charset.CharsetName =  null;                
                Menu obj1 = new Menu();
                obj1.MainMenu();
            }
        }
// End Fonction

        public void MenuHexa()
        {         
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.MenuHexaPrint(); 
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Hexa();
            }
        }

        public void MenuNumeric()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.MenuNumericPrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Numeric();
            }
        }

        private void MenuLeetSpeak()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.MenuLeetSpeakPrint();               
                Console.Write(" Enter the path to the txt file : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.ReadFileTxt();
                typesOFProcedure = '4';
            }
        }

       
        private void MenuSpecialCharacteres ()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.MenuSpecialCharacteresPrint();              
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Symbols();
            }
        }
       
        private void SyllableCharacteUppercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.SyllableCharacteUppercasePrint();                
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Usyllable_fr();
            }
        }        

         private void SyllableCharacterLowercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.SyllableCharacterLowercasePrint();               
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();
                Charset.Lsyllable_fr();
            }    
        }
        
        private void SyllableCharacterUppercaseLowercase()
        {
            booleanSubMenu = false;
            while (Charset.BooleanType)
            {
               
                MenuDisplayCharset.SyllableCharacterUppercaseLowercasePrint();               
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Symbols();
            }
        }

        private void LatinCharacteUppercase()
        {
            booleanSubMenu = false;
            while (Charset.BooleanType)
            {               
                MenuDisplayCharset.LatinCharacteUppercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Ualpha();

            }
        }
  
        private void LatinCharacterLowercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.LatinCharacterLowercasePrint();               

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();
                Charset.Lalpha();
            }
        }

       
        private void LatinCharacterUppercaseLowercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.LatinCharacterUppercaseLowercasePrint();             

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.MixAlpha();

            }
        }     

        private void SwddishCharacterUppercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.SwddishCharacterUppercasePrint();               

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Ualpha_sv();
            }
        }       

        private void SwddishCharacterLowercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.SwddishCharacterLowercasePrint();              

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Lalpha_sv();
            }
        }


        private void SwddishCharacterLowercaseUppercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuDisplayCharset.SwddishCharacterLowercaseUppercasePrint();               

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.MixAlpha_sv();
            }
        }
         
    }// End class
} // End Namespace
