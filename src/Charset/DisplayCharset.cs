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
    public class DisplayCharset
    {
        public DisplayCharset()
        {
        }


        public static void MenuLeetSpeakPrint()
        {
            Console.WriteLine(" leet speak\t\t\t 1337 5p34k\n");
            Console.Write(" Enter the name and path of your file : ");
        }

        public static void SfrPrint()
        {
            Console.WriteLine("\n #### SFR BOX ADSL FR");
            Console.WriteLine("\n Rétroingénierie du 31/12/2015 qui permet de générer des clés WPA authentiques\n à partir du véritable algorithme implanter dans une box SFR\n");
            Console.WriteLine(" Version du Firmware\t\t\t: NB6V-MAIN-R3.4.5");
            Console.WriteLine(" Octet de l'adresse MAC\t\t\t: 24:95:04:??:??:??\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sfr");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\t-_0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t\tabcdefghijklmnopqrstuvwxyz\n");
        }

        public static void LiveboxPrint()
        {
            Console.WriteLine("\n #### Livebox BOX ADSL FR");
            Console.WriteLine("\n Algorithme à partir de crack-wifi.com/forum/topic-5559-retravailler-des-cle-livebox.html\n qui permet de générer des clés WPA pour une Livebox Sagem\n");
            Console.WriteLine(" Construteur\t\t\t\t: SAGEM COMMUNICATION");
            Console.WriteLine(" Octet de l'adresse MAC\t\t\t: 00:19:70:??:??:??\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" livebox-sagem");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t1234679ACDEF\n");
        }

        public static void MenuHexaPrint()
        {
            Console.WriteLine("\n #### Hexa \n");
            //hexa-lower
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n hex-lower");
            Console.ResetColor();
            Console.WriteLine("\n  \t\t\t\t\t0123456789abcdef");
            //hexa-upper
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" hex-upper");
            Console.ResetColor();
            Console.WriteLine(" \t\t\t\t\t0123456789ABCDEF\n");
        }
        
        public static void MenuNumericPrint()
        {
            
            Console.WriteLine("\n #### Numeric\n");
            
            //numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" numeric");
            Console.ResetColor();
            Console.WriteLine(" \t\t\t\t0123456789");
            
            //numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t0123456789 [space] \n");
        }
        
        
       

        public static void MenuSpecialCharacteresPrint()
        {
            Console.WriteLine("\n #### Symbols \n");
            //symbols14
            Console.ForegroundColor = ConsoleColor.DarkGreen;  
            Console.Write(" symbols14");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t!@#$%^&*()-_+=");
            //symbols14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" symbols14-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t!@#$%^&*()-_+= [space]\n");
            //symbols-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;    
            Console.Write(" symbols-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/");
            //symbols-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" symbols-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]\n");
        }

        public static void LatinCharacterLowercasePrint()
        {
            Console.WriteLine("\n #### Latin Lowercase \n");
            //lalpha
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\tabcdefghijklmnopqrstuvwxyz");
            //lalpha-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" lalpha-space\n");
            Console.ResetColor();
            //lalpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tabcdefghijklmnopqrstuvwxyz");
            //lalpha-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t0123456789\n");
            //lalpha-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tabcdefghijklmnopqrstuvwxyz0123456789");
            //lalpha-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine(" \t\t@#$%^&*()-_+= [space]\n");
            //lalpha-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyz0123456789");
            //lalpha-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric-all-space ");
            Console.ResetColor();
            Console.WriteLine("\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
        }

        public static void LatinCharacteUppercasePrint()
        {
            Console.WriteLine("\n #### Latin Uppercase \n");
            //ualpha
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ");
            //ualpha-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ualpha-space\n");
            Console.ResetColor();
            //ualpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ");
            //ualpha-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t0123456789\n");
            //ualpha-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
            //ualpha-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\t\t@#$%^&*()-_+=\n");
            //ualpha-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
            //ualpha-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
        }

        public static void LatinCharacterUppercaseLowercasePrint()
        {
            Console.WriteLine("\n #### Latin Uppercase \n");
            //mixalpha
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tabcdefghijklmnopqrstuvwxyz");
            //mixalpha-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ\n");
            //mixalpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyz");
            //mixalpha-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t\t0123456789\n");
            //mixalpha-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mmixalpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tabcdefghijklmnopqrstuvwxyz");
            //mixalpha-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\tABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=\n");
            //mixalpha-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyz");
            //mixalpha-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/\n");
        }


        public static void CyrillicCharacterLowercasePrint()
        {
            Console.WriteLine("\n #### Cyrillic Mixcase \n");

            //lcyrillic
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic");
            Console.ResetColor();
                
            Console.WriteLine("\t\t\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //lcyrillic-space
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" lcyrillic-space\n");
            Console.ResetColor();

            //lcyrillic-numeric
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric");
            Console.ResetColor();

            Console.WriteLine("\t\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //lcyrillic-numeric-space
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric-space");
            Console.ResetColor();

            Console.WriteLine("\t\t0123456789\n");
            //lcyrillic-numeric-symbol14
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric-symbol14");
            Console.ResetColor();

            Console.WriteLine("\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //lcyrillic-numeric-symbol14-space
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric-symbol14-space");
            Console.ResetColor();

            Console.WriteLine(" \t0123456789@#$%^&*()-_+= [space]\n");
            //lcyrillic-numeric-all
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric-all");
            Console.ResetColor();

            Console.WriteLine("\t\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //lcyrillic-numeric-all-space
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric-all-space ");
            Console.ResetColor();

            Console.WriteLine("\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
        }


        public static void CyrillicCharacterUppercasePrint()
        {
            Console.WriteLine("\n #### Cyrillic Uppercase \n");
            //lcyrillic
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic");
            Console.ResetColor();

            Console.WriteLine("\t\t\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

            //lcyrillic-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ucyrillic-space\n");
            Console.ResetColor();

            //lcyrillic-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric");
            Console.ResetColor();

            Console.WriteLine("\t\t\tаАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            //lcyrillic-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric-space");
            Console.ResetColor();

            Console.WriteLine("\t\t0123456789\n");
            //lcyrillic-numeric-symbol14
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric-symbol14");
            Console.ResetColor();

            Console.WriteLine("\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

            //lcyrillic-numeric-symbol14-space
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric-symbol14-space");
            Console.ResetColor();

            Console.WriteLine(" \t0123456789@#$%^&*()-_+= [space]\n");
            //lcyrillic-numeric-all
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric-all");
            Console.ResetColor();

            Console.WriteLine("\t\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            //lcyrillic-numeric-all-space
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric-all-space ");
            Console.ResetColor();

            Console.WriteLine("\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
        }


        public static void CyrillicCharacterUppercaseLowercasePrint()
        {
            Console.WriteLine("\n #### Cyrillic Mixcase \n");
            //mixcyrillic

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic");
            Console.ResetColor();

            Console.WriteLine("\t\t\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //mixcyrillic-space
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-space");
            Console.ResetColor();

            Console.WriteLine("\t\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n");
            //mixcyrillic-numeric

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-numeric");
            Console.ResetColor();

            Console.WriteLine("\t\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");

            //mixcyrillic-numeric-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-numeric-space");
            Console.ResetColor();

            Console.WriteLine("\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n\t\t\t\t\t0123456789\n");

            //mixcyrillic-numeric-symbol14

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mmixcyrillic-numeric-symbol14");
            Console.ResetColor();

            Console.WriteLine("\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");

            //mixcyrillic-numeric-symbol14-space
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-numeric-symbol14-space");
            Console.ResetColor();

            Console.WriteLine("\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=\n");
            //mixcyrillic-numeric-all

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-numeric-all");
            Console.ResetColor();

            Console.WriteLine("\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //mixcyrillic-numeric-all-space
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-numeric-all-space");
            Console.ResetColor();

            Console.WriteLine("\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/\n");
        }

        public static void SwddishCharacterLowercasePrint()
        {
            //////////////////////////////////////////////////////////////////////////////////////////
            //                 SWEDISH CHAR  SUPPORT                                                // 
            /////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////
            // Lowercase           //
            /////////////////////////

            Console.WriteLine("\n #### Swddish Lowercase \n");

            //lalpha-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //lalpha-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" sv-lalpha-space\n");
            Console.ResetColor();
            //lalpha-numeric-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyzåäö0");
            //lalpha-numeric-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t123456789\n");
            //lalpha-numeric-symbol14-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tabcdefghijklmnopqrstuvwxyzåäö0");
            //lalpha-numeric-symbol14-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\t123456789!@#$%^&*()-_+=\n");
            //lalpha-numeric-all-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyzåäö0");
            //lalpha-numeric-all-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/ [space]\n");
        }     

        public static void SwddishCharacterUppercasePrint()
        {            

            /////////////////////////
            //       Uppercase     //
            /////////////////////////
            Console.WriteLine("\n #### Swddish Uppercase \n");
            //ualpha-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ");
            //ualpha-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" sv-ualpha-space\n");
            Console.ResetColor();
            //ualpha-numeric-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
            //ualpha-numeric-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" sv-ualpha-numeric-space\n");
            Console.ResetColor();
            //ualpha-numeric-symbol14-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
            //ualpha-numeric-symbol14-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\t@#$%^&*()-_+= [space]\n");
            //ualpha-numeric-all-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
            //ualpha-numeric-all-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
        }

                

        public static void SwddishCharacterLowercaseUppercasePrint()
        {
            /////////////////////////
            // Mixcase             // 
            ////////////////////////
            Console.WriteLine("\n #### Swddish Mixcase \n");
            //mixalpha-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n");
            //mixalpha-numeric-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-numeric-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789\n");
            //mixalpha-numeric-symbol14-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-numeric-symbol14-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine(" \tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=\n");
            //mixalpha-numeric-all-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-numeric-all-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/\n");
        }


        public static void SyllableCharacterLowercasePrint()
        {
            Console.WriteLine("\n #### Syllable Lowercase\n");
            //lsyllable
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //lsyllable-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" lsyllable-space\n");
            Console.ResetColor();
            //lalpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //lsyllable-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t0123456789\n");
            //lsyllable-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //usyllable-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\t0123456789t@#$%^&*()-_+=\n");
            //lsyllable-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //lsyllable-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:\n\t\t\t\t\t;\"'<>,.?/\n");
        }

        public static void SyllableCharacteUppercasePrint()
        {
            Console.WriteLine("\n #### Syllable Uppercase \n");
            //usyllable
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" usyllable-space\n");
            Console.ResetColor();
            //ualpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t0123456789\n");
            //ulsyllable-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\t0123456789t@#$%^&*()-_+=\n");
            //usyllable-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:\n\t\t\t\t\t;\"'<>,.?/\n");
        }

        public static void SyllableCharacterUppercaseLowercasePrint()
        {
            Console.WriteLine("\n #### Syllable Mixcase \n");
            //mixsyllable
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n");
            //mixalpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n\t\t\t\t\t0123456789\n");
            //mixsyllable-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n\t\t\t\t\t0123456789t@#$%^&*()-_+=\n");
            //mixsyllable-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:\n\t\t\t\t\t;\"'<>,.?/\n");
        }

        
         	

    }
}

