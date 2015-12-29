//
//  MenuDisplayCharset.cs
//
//  Author:
//       root <>
//
//  Copyright (c) 2015 root
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
    public class MenuDisplayCharset
    {
        public MenuDisplayCharset()
        {
        }


        public static void MenuLeetSpeakPrint()
        {
            Console.WriteLine(" leet speak\t\t\t 1337 5p34k\n");
        }

        public static void MenuHexaPrint()
        {
            //hexa-lower
            Console.WriteLine("\n hex-lower\t\t\t0123456789abcdef");
            //hexa-upper
            Console.WriteLine(" hex-upper\t\t\t0123456789ABCDEF\n");
        }
        
        public static void MenuNumericPrint()
        {
            //numeric  
            Console.WriteLine(" numeric\t\t\t0123456789");
            //numeric-space
            Console.WriteLine(" numeric-space\t\t\t0123456789 [space] \n");
        }
        
        
       

        public static void MenuSpecialCharacteresPrint()
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
        
        public static void SyllableCharacteUppercasePrint()
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
        
        public static void SyllableCharacterLowercasePrint()
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
        
        public static void LatinCharacterUppercaseLowercasePrint()
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
        
        public static void SwddishCharacterUppercasePrint()
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
        
        public static void SwddishCharacterLowercasePrint()
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
            Console.WriteLine(" sv-lalpha-numeric-all\t\t\tabcdefghijklmnopqrstuvwxyzåäö0");
            //lalpha-numeric-all-space-sv
            Console.WriteLine(" sv-lalpha-numeric-all-space\t\t123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/ [space]\n");
        }
        
        public static void SwddishCharacterLowercaseUppercasePrint()
        {
            /////////////////////////
            // Mixcase             // 
            ////////////////////////

            //mixalpha-sv
            Console.WriteLine(" sv-mixalpha\t\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
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
        
        public static void  LatinCharacteUppercasePrint()
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
        
        public static void SyllableCharacterUppercaseLowercasePrint()
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
        
        public static void LatinCharacterLowercasePrint()
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
    }
}

