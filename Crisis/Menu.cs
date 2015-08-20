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
        private char typesOFProcedure;
        private  char saveFileAsk;

        public Menu()
        {
        }



        public void MainMenu()
        {

            Console.WriteLine(" Crisis Wordlist Generator  by Teeknofil, ver: 1.0.2");
            Console.WriteLine(" Trouble: http://www.kali-linux.fr/forum/index.php");

            Console.WriteLine("\n N°\tDESCRIPTION \n");


            Console.WriteLine(" 1)\t HEXA");
            Console.WriteLine(" 2)\t NUMBER");
            Console.WriteLine(" 3)\t SPECIAL CHARACTER");
            Console.WriteLine(" 4)\t LATIN   CHARACTER UPPERCASE");
            Console.WriteLine(" 5)\t LATIN   CHARACTER LOWERCASE");
            Console.WriteLine(" 6)\t LATIN   CHARACTER UPPERCASE & LOWERCASE");
            Console.WriteLine(" 7)\t SWEDISH   CHARACTER UPPERCASE");
            Console.WriteLine(" 8)\t SWEDISH   CHARACTER LOWERCASE");
            Console.WriteLine(" 9)\t SWEDISH   CHARACTER UPPERCASE & LOWERCASE");



            while (booleanSubMenu)
            {
                try
                {

                    Console.Write(" \nWith what category you want to work : ");
                    dislayMainSubMain = int.Parse(Console.ReadLine());

                    Console.Write("\n");

                    if (dislayMainSubMain == 1) MenuHexa();
                    if (dislayMainSubMain == 2) MenNumeric();
                    if (dislayMainSubMain == 3) MenuSpecialCharacteres ();
                    if (dislayMainSubMain == 4) LatinCharacteUppercase();
                    if (dislayMainSubMain == 5) LatinCharacterLowercase();
                    if (dislayMainSubMain == 6) LatinCharacterUppercaseLowercase();
                    if (dislayMainSubMain == 7) SwddishCharacterUppercase();
                    if (dislayMainSubMain == 8) SwddishCharacterLowercase();
                    if (dislayMainSubMain == 9) SwddishCharacterLowercaseUppercase();
                
                } catch (FormatException)
                {
                    Console.Write("\n Enter the number corresponding to your choice !");
                } 
                
            }
        }

        private void ReturnMainMenu()
        {
            Console.Write(" 99\t\t\t\t Back to main menu\n\n");

            if (CharsetName == "99")
            {
                Console.Clear();
                Menu obj1 = new Menu();
                obj1.MainMenu();
            }
        }

        public void Parameter()
        {
            bool b = false;

            Console.WriteLine("\n 1)\t Charset Generator for Crunch without repetition");
            Console.WriteLine(" 2)\t Combination without repetition");
            Console.WriteLine(" 3)\t Random with repetition\n\n ");


            while (b == false)
            {
                try
                {
                    Console.Write(" Type the number corresponding to the menu : ");
                    b = char.TryParse(Console.ReadLine(), out typesOFProcedure);

                    if (typesOFProcedure == '1' | typesOFProcedure == '2' | typesOFProcedure == '3')
                    {
                        b = true;
                        TypesOfGeneration += typesOFProcedure;
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

            b = false;

            while (b == false)
            {
                Console.Write("\n What is the size of your charset : ");

                try
                {
                    b = int.TryParse(Console.ReadLine(), out sizeCharset);
                    NumberOfChar = +sizeCharset;

                    if (sizeCharset < 3 | sizeCharset > 128)
                    {
                        Console.WriteLine(" Type a number between 3 and 128 please !");
                        b = false;
                    }
                    else if (typesOFProcedure == '1' | typesOFProcedure == '2')
                    {
                        if (sizeCharset > CharsetSelecting.Count)
                        {
                            Console.WriteLine(" The number of character is too large to generate\n a caratère chain without rehearsal");
                            b = false;
                        }
                        else if (sizeCharset == CharsetSelecting.Count)
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

            Console.WriteLine("\n 1) Yes");
            Console.WriteLine(" 2) No\n");

            b = false;

            while (b == false)
            {
                try
                {
                    Console.Write(" Do you want to save the output to a file : ");

                    b = char.TryParse(Console.ReadLine(), out saveFileAsk);

                    if (saveFileAsk == '1' | saveFileAsk == '2')
                    {
                        b = true;
                        SaveFile += saveFileAsk;
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

        }// End Fonction

        public void Navigation ()
        {
            MainMenu();

            Parameter ();

            if (TypesOfGeneration == '1' || TypesOfGeneration == '2') {
                Charset ();
            } else {
                Wordlist ();
                Console.ReadKey ();
            }

        } // End Fonction
                                        

        private void MenuHexa()
        {         
            booleanSubMenu = false;

            while (BooleanType)
            {
                //hexa-lower
                Console.WriteLine("\n hex-lower\t\t\t0123456789abcdef");
                //hexa-upper
                Console.WriteLine(" hex-upper\t\t\t0123456789ABCDEF\n");

                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                CharsetName = Console.ReadLine();

                Hexa();
            }
        }

        private void MenNumeric()
        {
            booleanSubMenu = false;

            while (BooleanType)
            {
                //numeric  
                Console.WriteLine(" numeric\t\t\t0123456789");
                //numeric-space
                Console.WriteLine(" numeric-space\t\t\t0123456789 [space] \n");

                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                CharsetName = Console.ReadLine();

                Numeric();
            }

        }

        private void MenuSpecialCharacteres ()
        {
            booleanSubMenu = false;

            while (BooleanType)
            {
                //symbols14              
                Console.WriteLine(" symbols14\t\t\t!@#$%^&*()-_+=");
                //symbols14-space
                Console.WriteLine(" symbols14-space\t\t!@#$%^&*()-_+= [space]\n");

                //symbols-all                
                Console.WriteLine(" symbols-all\t\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/");
                //symbols-all-space

                Console.WriteLine(" symbols-all-space\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]\n");

                ReturnMainMenu();
                Console.Write(" Write the name corresponding to your choice : ");
                CharsetName = Console.ReadLine();

                Symbols();

            }
        }

        private void LatinCharacteUppercase()
        {
            booleanSubMenu = false;

            while (BooleanType)
            {
                //ualpha     
                Console.WriteLine(" ualpha\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ");
                //ualpha-space
                Console.WriteLine(" ualpha-space\n");

                //ualpha-numeric
                Console.WriteLine(" ualpha-numeric\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ");
                //ualpha-numeric-space
                Console.WriteLine(" ualpha-numeric-space\t\t0123456789\n");

                //ualpha-numeric-symbol14
                Console.WriteLine(" ualpha-numeric-symbol14\tABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
                //ualpha-numeric-symbol14-space
                Console.WriteLine(" ualpha-numeric-symbol14-space\t@#$%^&*()-_+=\n");

                //ualpha-numeric-all
                Console.WriteLine(" ualpha-numeric-all\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
                //ualpha-numeric-all-space
                Console.WriteLine(" ualpha-numeric-all-space\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");

                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                CharsetName = Console.ReadLine();

                Ualpha();

            }
        }

        private void LatinCharacterLowercase()
        {
            booleanSubMenu = false;

            while (BooleanType)
            {
                //lalpha
                Console.WriteLine(" lalpha\t\t\t\tabcdefghijklmnopqrstuvwxyz");
                //lalpha-space
                Console.WriteLine(" lalpha-space\n");
                //lalpha-numeric
                Console.WriteLine(" lalpha-numeric\t\t\tabcdefghijklmnopqrstuvwxyz");
                //lalpha-numeric-space
                Console.WriteLine(" lalpha-numeric-space\t\t0123456789\n");
                //lalpha-numeric-symbol14
                Console.WriteLine(" lalpha-numeric-symbol14\tabcdefghijklmnopqrstuvwxyz0123456789");
                //lalpha-numeric-symbol14-space
                Console.WriteLine(" lalpha-numeric-symbol14-space\t@#$%^&*()-_+= [space]\n");
                //lalpha-numeric-all
                Console.WriteLine(" lalpha-numeric-all\t\tabcdefghijklmnopqrstuvwxyz0123456789");
                //lalpha-numeric-all-space 
                Console.WriteLine(" lalpha-numeric-all-space \t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");

                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                CharsetName = Console.ReadLine();

                Lalpha();

            }
        }

        private void LatinCharacterUppercaseLowercase()
        {
            booleanSubMenu = false;

            while (BooleanType)
            {
                //mixalpha
                Console.WriteLine(" mixalpha\t\t\t  abcdefghijklmnopqrstuvwxyz");
                //mixalpha-space
                Console.WriteLine(" mixalpha-space\t\t\t  ABCDEFGHIJKLMNOPQRSTUVWXYZ\n");

                //mixalpha-numeric
                Console.WriteLine(" mixalpha-numeric\t\t  abcdefghijklmnopqrstuvwxyz");
                //mixalpha-numeric-space
                Console.WriteLine(" mixalpha-numeric-space\t\t  ABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t  0123456789\n");

                //mixalpha-numeric-symbol14
                Console.WriteLine(" mmixalpha-numeric-symbol14\t  abcdefghijklmnopqrstuvwxyz");
                //mixalpha-numeric-symbol14-space
                Console.WriteLine(" mixalpha-numeric-symbol14-space  ABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t  0123456789!@#$%^&*()-_+=\n");

                //mixalpha-numeric-all
                Console.WriteLine(" mixalpha-numeric-all\t\t  abcdefghijklmnopqrstuvwxyz");
                //mixalpha-numeric-all-space
                Console.WriteLine(" mixalpha-numeric-all-space\t  ABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t  0123456789!@#$%^&*()-_+=~`\n\t\t\t\t  []{}|\\:;\"'<>,.?/\n");
                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                CharsetName = Console.ReadLine();

                MixAlpha();

            }
        }

        private void SwddishCharacterUppercase()
        {
            booleanSubMenu = false;

            while (BooleanType)
            {
                //////////////////////////////////////////////////////////////////////////////////////////
                //                 SWEDISH CHAR  SUPPORT                                                // 
                /////////////////////////////////////////////////////////////////////////////////////////

                /////////////////////////
                //       Uppercase     //
                /////////////////////////

                //ualpha-sv
                Console.WriteLine(" ualpha-sv\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ");
                //ualpha-space-sv
                Console.WriteLine(" ualpha-space-sv\n");

                //ualpha-numeric-sv
                Console.WriteLine(" ualpha-numeric-sv\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
                //ualpha-numeric-space-sv
                Console.WriteLine(" ualpha-numeric-space-sv\n");

                //ualpha-numeric-symbol14-sv
                Console.WriteLine(" ualpha-numeric-symbol14-sv\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
                //ualpha-numeric-symbol14-space-sv
                Console.WriteLine(" ualpha-numeric-symbol14-space-sv\t@#$%^&*()-_+= [space]\n");

                //ualpha-numeric-all-sv
                Console.WriteLine(" ualpha-numeric-all-sv\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
                //ualpha-numeric-all-space-sv
                Console.WriteLine(" ualpha-numeric-all-space-sv\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");

                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                CharsetName = Console.ReadLine();

                Ualpha_sv();
            }
        }

        private void SwddishCharacterLowercase()
        {
            booleanSubMenu = false;

            while (BooleanType)
            {
                /////////////////////////
                // Lowercase           //
                /////////////////////////

                //lalpha-sv
                Console.WriteLine(" lalpha-sv\t\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
                //lalpha-space-sv
                Console.WriteLine(" lalpha-space-sv\n");

                //lalpha-numeric-sv
                Console.WriteLine(" lalpha-numeric-sv\t\t\tabcdefghijklmnopqrstuvwxyzåäö0");
                //lalpha-numeric-space-sv
                Console.WriteLine(" lalpha-numeric-space-sv\t\t123456789\n");

                //lalpha-numeric-symbol14-sv 
                Console.WriteLine(" lalpha-numeric-symbol14-sv\t\tabcdefghijklmnopqrstuvwxyzåäö0");
                //lalpha-numeric-symbol14-space-sv
                Console.WriteLine(" lalpha-numeric-symbol14-space-sv\t123456789!@#$%^&*()-_+=\n");

                //lalpha-numeric-all-sv
                Console.WriteLine(" lalpha-numeric-all-sv\t\t\tabcdefghijklmnopqrstuvwxyzåäö0");
                //lalpha-numeric-all-space-sv
                Console.WriteLine(" lalpha-numeric-all-space-sv\t\t123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/ [space]\n");

                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                CharsetName = Console.ReadLine();

                Lalpha_sv();
            }
        }

        private void SwddishCharacterLowercaseUppercase()
        {
            /////////////////////////
            // Mixcase             // 
            ////////////////////////



            booleanSubMenu = false;

            while (BooleanType)
            {
                //mixalpha-sv
                Console.WriteLine(" mixalpha-sv\t\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
                //mixalpha-space-sv
                Console.WriteLine(" mixalpha-space-sv\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n");

                //mixalpha-numeric-sv
                Console.WriteLine(" mixalpha-numeric-sv\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
                //mixalpha-numeric-space-sv
                Console.WriteLine(" mixalpha-numeric-space-sv\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789\n");

                //mixalpha-numeric-symbol14-sv
                Console.WriteLine(" mixalpha-numeric-symbol14-sv\t\tabcdefghijklmnopqrstuvwxyzåäö");
                //mixalpha-numeric-symbol14-space-sv
                Console.WriteLine(" mixalpha-numeric-symbol14-space-sv\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=\n");

                //mixalpha-numeric-all-sv
                Console.WriteLine(" mixalpha-numeric-all-sv\t\tabcdefghijklmnopqrstuvwxyzåäö");
                //mixalpha-numeric-all-space-sv
                Console.WriteLine(" mixalpha-numeric-all-space-sv\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/\n");


                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                CharsetName = Console.ReadLine();

                MixAlpha_sv();
            }
        }
         
    }// End class
} // End Namespace

