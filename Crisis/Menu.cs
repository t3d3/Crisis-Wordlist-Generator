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

            Console.WriteLine(" Crisis Wordlist Generator  by Teeknofil, version : 1.0.5");
            Console.WriteLine(" Thanks WarLocG for the debugging et fix bug");
            Console.WriteLine(" Trouble: http://www.kali-linux.fr/forum/index.php");

            Console.WriteLine("\n N°\tDESCRIPTION \n");
            int i = 0;
            do
            {
                Console.WriteLine(" {0})\t HEXA", i++);
                Console.WriteLine(" {0})\t NUMBER", i++);
                Console.WriteLine(" {0})\t SPECIAL CHARACTER", i++);

                Console.WriteLine(" {0})\t SYLLABLE   CHARACTER UPPERCASE", i++);
                Console.WriteLine(" {0})\t SYLLABLE   CHARACTER LOWERCASE", i++);
                Console.WriteLine(" {0})\t SYLLABLE   CHARACTER UPPERCASE & LOWERCASE", i++);

                Console.WriteLine(" {0})\t LATIN   CHARACTER UPPERCASE", i++);
                Console.WriteLine(" {0})\t LATIN   CHARACTER LOWERCASE", i++);
                Console.WriteLine(" {0})\t LATIN   CHARACTER UPPERCASE & LOWERCASE", i++);

                Console.WriteLine(" {0})\t SWEDISH   CHARACTER UPPERCASE", i++);
                Console.WriteLine(" {0})\t SWEDISH   CHARACTER LOWERCASE", i++);
                Console.WriteLine(" {0})\t SWEDISH   CHARACTER UPPERCASE & LOWERCASE", i++);
            } while(i < 1);


            while (booleanSubMenu)
            {
                try
                {
                    Console.Write("\n");
                    Console.Write(" \nWith what category you want to work : ");
                    dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    i = 0;

                    if (dislayMainSubMain == i++) MenuHexa();
                    if (dislayMainSubMain == i++) MenuNumeric();
                    if (dislayMainSubMain == i++) MenuSpecialCharacteres ();

                    if (dislayMainSubMain == i++) SyllableCharacteUppercase();
                    if (dislayMainSubMain == i++) SyllableCharacterLowercase();
                    if (dislayMainSubMain == i++) SyllableCharacterUppercaseLowercase();


                    if (dislayMainSubMain == i++) LatinCharacteUppercase();
                    if (dislayMainSubMain == i++) LatinCharacterLowercase();
                    if (dislayMainSubMain == i++) LatinCharacterUppercaseLowercase();

                    if (dislayMainSubMain == i++) SwddishCharacterUppercase();
                    if (dislayMainSubMain == i++) SwddishCharacterLowercase();
                    if (dislayMainSubMain == i++) SwddishCharacterLowercaseUppercase();

                } 
                catch (FormatException)
                {
                    Console.Write("\n Enter the number corresponding to your choice !");
                }                
            }
        }

        private void ReturnMainMenu()
        {
            Console.Write(" 99\t\t\t\t Back to main menu\n\n");

            if (Charset.CharsetName == "99")
            {
                Charset.CharsetName =  null;
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

            if (TypesOfGeneration == '1' || TypesOfGeneration == '2') 
            {
                CharsetCrunch ();
            } 
            else 
            {
                Wordlist ();
                Console.ReadKey ();
            }

        } // End Fonction

        public void MenuSfrNeufBoxPrint()
        {
            Console.WriteLine("\n sfr0\t\t\t\tabcdefghijklmnopqrs0");
            Console.WriteLine(" sfr1\t\t\t\tabcdefghijklmnopqrs1");
            Console.WriteLine(" sfr2\t\t\t\tabcdefghijklmnopqrs2");
            Console.WriteLine(" sfr3\t\t\t\tabcdefghijklmnopqrs3");
            Console.WriteLine(" sfr4\t\t\t\tabcdefghijklmnopqrs4");
            Console.WriteLine(" sfr5\t\t\t\tabcdefghijklmnopqrs5");
            Console.WriteLine(" sfr6\t\t\t\tabcdefghijklmnopqrs6");
            Console.WriteLine(" sfr7\t\t\t\tabcdefghijklmnopqrs7");
            Console.WriteLine(" sfr8\t\t\t\tabcdefghijklmnopqrs8");
            Console.WriteLine(" sfr9\t\t\t\tabcdefghijklmnopqrs9\n");
        }
                                        
        public void MenuHexaPrint()
        {
            //hexa-lower
            Console.WriteLine("\n hex-lower\t\t\t0123456789abcdef");
            //hexa-upper
            Console.WriteLine(" hex-upper\t\t\t0123456789ABCDEF\n");
        }
        public void MenuHexa()
        {         
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuHexaPrint();
                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Hexa();
            }
        }

        public void MenuNumericPrint()
        {
            //numeric  
            Console.WriteLine(" numeric\t\t\t0123456789");
            //numeric-space
            Console.WriteLine(" numeric-space\t\t\t0123456789 [space] \n");
        }

        public void MenuNumeric()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuNumericPrint();
                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Numeric();
            }

        }

        public void MenuSpecialCharacteresPrint()
        {
            //symbols14              
            Console.WriteLine(" symbols14\t\t\t!@#$%^&*()-_+=");
            //symbols14-space
            Console.WriteLine(" symbols14-space\t\t!@#$%^&*()-_+= [space]\n");

            //symbols-all                
            Console.WriteLine(" symbols-all\t\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/");
            //symbols-all-space
            Console.WriteLine(" symbols-all-space\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]\n");
        }

        private void MenuSpecialCharacteres ()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                MenuSpecialCharacteresPrint();

                ReturnMainMenu();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Symbols();

            }
        }
        public void SyllableCharacteUppercasePrint()
        {
            //usyllable     
            Console.WriteLine(" usyllable\t\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-space
            Console.WriteLine(" usyllable-space\n");

            //ualpha-numeric
            Console.WriteLine(" ualpha-numeric\t\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-numeric-space
            Console.WriteLine(" usyllable-numeric-space\t\t0123456789\n");

            //ulsyllable-numeric-symbol14
            Console.WriteLine(" usyllable-numeric-symbol14\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-numeric-symbol14-space
            Console.WriteLine(" usyllable-numeric-symbol14-space\t0123456789t@#$%^&*()-_+=\n");

            //usyllable-numeric-all
            Console.WriteLine(" usyllable-numeric-all\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-numeric-all-space
            Console.WriteLine(" usyllable-numeric-all-space\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:\n\t\t\t\t\t;\"'<>,.?/\n");
        }

        private void SyllableCharacteUppercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                SyllableCharacteUppercasePrint();

                ReturnMainMenu();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Usyllable_fr();
            }
        }

        public void SyllableCharacterLowercasePrint()
        {
            //lsyllable     
            Console.WriteLine(" lsyllable\t\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //lsyllable-space
            Console.WriteLine(" lsyllable-space\n");

            //lalpha-numeric
            Console.WriteLine(" lalpha-numeric\t\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //lsyllable-numeric-space
            Console.WriteLine(" lsyllable-numeric-space\t\t0123456789\n");

            //lsyllable-numeric-symbol14
            Console.WriteLine(" lsyllable-numeric-symbol14\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //usyllable-numeric-symbol14-space
            Console.WriteLine(" lsyllable-numeric-symbol14-space\t0123456789t@#$%^&*()-_+=\n");

            //lsyllable-numeric-all
            Console.WriteLine(" lsyllable-numeric-all\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //lsyllable-numeric-all-space
            Console.WriteLine(" lsyllable-numeric-all-space\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:\n\t\t\t\t\t;\"'<>,.?/\n");
        }

         private void SyllableCharacterLowercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                SyllableCharacterLowercasePrint();

                ReturnMainMenu();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Lsyllable_fr();
            }    
        }

        public void SyllableCharacterUppercaseLowercasePrint()
        {
            //mixsyllable     
            Console.WriteLine(" mixsyllable\t\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-space
            Console.WriteLine(" mixsyllable-space\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n");

            //mixalpha-numeric
            Console.WriteLine(" mixalpha-numeric\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-numeric-space
            Console.WriteLine(" mixsyllable-numeric-space\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n\t\t\t\t\t0123456789\n");

            //mixsyllable-numeric-symbol14
            Console.WriteLine(" mixsyllable-numeric-symbol14\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-numeric-symbol14-space
            Console.WriteLine(" mixsyllable-numeric-symbol14-space\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n\t\t\t\t\t0123456789t@#$%^&*()-_+=\n");

            //mixsyllable-numeric-all
            Console.WriteLine(" mixsyllable-numeric-all\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-numeric-all-space
            Console.WriteLine(" mixsyllable-numeric-all-space\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:\n\t\t\t\t\t;\"'<>,.?/\n");
        }

        private void SyllableCharacterUppercaseLowercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
               
                SyllableCharacterUppercaseLowercasePrint();
                ReturnMainMenu();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Symbols();
            }
        }

        public void  LatinCharacteUppercasePrint()
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
        }


        private void LatinCharacteUppercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
               
                LatinCharacteUppercasePrint();
                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Ualpha();

            }
        }
        public void LatinCharacterLowercasePrint()
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
        }

        private void LatinCharacterLowercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                LatinCharacterLowercasePrint();

                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Lalpha();

            }
        }

        public void LatinCharacterUppercaseLowercasePrint()
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
        }

        private void LatinCharacterUppercaseLowercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                LatinCharacterUppercaseLowercasePrint();
                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.MixAlpha();

            }
        }

        public void SwddishCharacterUppercasePrint()
        {
            //////////////////////////////////////////////////////////////////////////////////////////
            //                 SWEDISH CHAR  SUPPORT                                                // 
            /////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////
            //       Uppercase     //
            /////////////////////////

            //ualpha-sv
            Console.WriteLine(" sv-ualpha\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ");
            //ualpha-space-sv
            Console.WriteLine(" sv-ualpha-space\n");

            //ualpha-numeric-sv
            Console.WriteLine(" sv-ualpha-numeric\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
            //ualpha-numeric-space-sv
            Console.WriteLine(" sv-ualpha-numeric-space\n");

            //ualpha-numeric-symbol14-sv
            Console.WriteLine(" sv-ualpha-numeric-symbol14\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
            //ualpha-numeric-symbol14-space-sv
            Console.WriteLine(" sv-ualpha-numeric-symbol14-space\t@#$%^&*()-_+= [space]\n");

            //ualpha-numeric-all-sv
            Console.WriteLine(" sv-ualpha-numeric-all\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
            //ualpha-numeric-all-space-sv
            Console.WriteLine(" sv-ualpha-numeric-all-space\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");

        }

        private void SwddishCharacterUppercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                SwddishCharacterUppercasePrint();
                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Ualpha_sv();
            }
        }

        public void SwddishCharacterLowercasePrint()
        {
            /////////////////////////
            // Lowercase           //
            /////////////////////////

            //lalpha-sv
            Console.WriteLine(" sv-lalpha\t\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //lalpha-space-sv
            Console.WriteLine(" sv-lalpha-space\n");

            //lalpha-numeric-sv
            Console.WriteLine(" sv-lalpha-numeric\t\t\tabcdefghijklmnopqrstuvwxyzåäö0");
            //lalpha-numeric-space-sv
            Console.WriteLine(" sv-lalpha-numeric-space\t\t123456789\n");

            //lalpha-numeric-symbol14-sv 
            Console.WriteLine(" sv-lalpha-numeric-symbol14\t\tabcdefghijklmnopqrstuvwxyzåäö0");
            //lalpha-numeric-symbol14-space-sv
            Console.WriteLine(" sv-lalpha-numeric-symbol14-space\t123456789!@#$%^&*()-_+=\n");

            //lalpha-numeric-all-sv
            Console.WriteLine(" sv-lalpha-numeric-all-sv\t\t\tabcdefghijklmnopqrstuvwxyzåäö0");
            //lalpha-numeric-all-space-sv
            Console.WriteLine(" sv-lalpha-numeric-all-space\t\t123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/ [space]\n");
        }

        private void SwddishCharacterLowercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                SwddishCharacterLowercasePrint();

                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.Lalpha_sv();
            }
        }

        public void SwddishCharacterLowercaseUppercasePrint()
        {
            /////////////////////////
            // Mixcase             // 
            ////////////////////////

            //mixalpha-sv
            Console.WriteLine(" sv-mixalpha-sv\t\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-space-sv
            Console.WriteLine(" sv-mixalpha-space\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n");

            //mixalpha-numeric-sv
            Console.WriteLine(" sv-mixalpha-numeric\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-numeric-space-sv
            Console.WriteLine(" sv-mixalpha-numeric-space\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789\n");

            //mixalpha-numeric-symbol14-sv
            Console.WriteLine(" sv-mixalpha-numeric-symbol14\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-numeric-symbol14-space-sv
            Console.WriteLine(" sv-mixalpha-numeric-symbol14-space\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=\n");

            //mixalpha-numeric-all-sv
            Console.WriteLine(" sv-mixalpha-numeric-all\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-numeric-all-space-sv
            Console.WriteLine(" sv-mixalpha-numeric-all-space\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/\n");

        }

        private void SwddishCharacterLowercaseUppercase()
        {
            booleanSubMenu = false;

            while (Charset.BooleanType)
            {
                SwddishCharacterLowercaseUppercasePrint();
                ReturnMainMenu();

                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();

                Charset.MixAlpha_sv();
            }
        }
         
    }// End class
} // End Namespace

