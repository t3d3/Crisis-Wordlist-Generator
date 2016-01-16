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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public class SubMenu
    {

        private static bool booleanSubMenu;

        public static bool BooleanSubMenu
        {
            get { return SubMenu.booleanSubMenu; }
            set { SubMenu.booleanSubMenu = value; }
        }
        
        public SubMenu()
        {
            booleanSubMenu = true;
        }

        internal void MenuLeetSpeak()
        {
            while (Charset.BooleanType)
            {
                DisplayCharset.MenuLeetSpeakPrint();
                Charset.CharsetName = Console.ReadLine().ToLower();
                Charset.ReadFileTxt();
            }
        }

        internal void MenuCustom()
        {
            while (Charset.BooleanType)
            {                
                Console.Write(" Write your custom pattern : ");
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string s = Console.ReadLine();
                Console.ResetColor();                              

                if (s.Length > 1 & s != null)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        Charset.CharsetSelecting.Add(s[i].ToString());
                    }

                    Charset.BooleanType = false;
                    MainMenu.BooleanCategoryMenu = false;
                   
                }
                else
                {
                     Charset.BooleanType = true;
                }
            }
        }
                
        // SubMenu Special
        internal void MenuHexa()
        {           
            while (Charset.BooleanType)
            {                
                DisplayCharset.MenuHexaPrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor();
                Charset.Hexa();
            }            
        }

        

        internal void MenuNumeric()
        {            
            while (Charset.BooleanType)
            {
                DisplayCharset.MenuNumericPrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor();                
                Charset.Numeric();
            }            
        }

        internal void MenuSpecialCharacteres()
        {            
            while (Charset.BooleanType)
            {               
                DisplayCharset.MenuSpecialCharacteresPrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor(); 
                Charset.Symbols();
            }            
        }

        //Sub Menu Latin

        internal void LatinCharacterLowercase()
        {           
            while (Charset.BooleanType)
            {                
                DisplayCharset.LatinCharacterLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor(); 
                Charset.Lalpha();
            }           
        }

        internal void LatinCharacteUppercase()
        {            
            while (Charset.BooleanType)
            {                
                DisplayCharset.LatinCharacteUppercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor(); 
                Charset.Ualpha();
            }
            
        }

        internal void LatinCharacterUppercaseLowercase()
        {            
            while (Charset.BooleanType)
            {                
                DisplayCharset.LatinCharacterUppercaseLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor(); 
                Charset.MixAlpha();
            }
            
        }

       

        internal void CyrillicCharacterLowercase()
        {
            while (Charset.BooleanType)
            {
                DisplayCharset.CyrillicCharacterLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor();
                Charset.Lcyrillic();
            }
        }

        internal void CyrillicCharacteUppercase()
        {
            while (Charset.BooleanType)
            {
                DisplayCharset.CyrillicCharacterUppercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor();
                Charset.Ucyrillic();
            }

        }

        internal void CyrillicCharacterUppercaseLowercase()
        {
            while (Charset.BooleanType)
            {
                DisplayCharset.CyrillicCharacterUppercaseLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor();
                Charset.MixCyrillic();
            }

        }


        // Sub Menu Swddish

        internal void SwddishCharacterUppercase()
        {            
            while (Charset.BooleanType)
            {                
                DisplayCharset.SwddishCharacterUppercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor(); 
                Charset.Ualpha_sv();
            }            
        }

        internal void SwddishCharacterLowercase()
        {            
            while (Charset.BooleanType)
            {                
                DisplayCharset.SwddishCharacterLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor(); 
                Charset.Lalpha_sv();
            }            
        }


        internal void SwddishCharacterLowercaseUppercase()
        {
            while (Charset.BooleanType)
            {                
                DisplayCharset.SwddishCharacterLowercaseUppercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor(); 

                Charset.MixAlpha_sv();
            }           
        }

        // Sub Menu Syllable

        internal void SyllableCharacterLowercase()
        {           
            while (Charset.BooleanType)
            {                
                DisplayCharset.SyllableCharacterLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor(); 
                Charset.Lsyllable_fr();
            }
            
        }


        internal void SyllableCharacteUppercase()
        {            
            while (Charset.BooleanType)
            {                
                DisplayCharset.SyllableCharacteUppercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();

                Charset.Usyllable_fr();
            }            
        }

        

        internal void SyllableCharacterUppercaseLowercase()
        {            
            while (Charset.BooleanType)
            {                
                DisplayCharset.SyllableCharacterUppercaseLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor();                 
                Charset.mixsyllable_fr();
            }            
        }

        internal void BoxAdslSfr()
        {            
            while (Charset.BooleanType)
            {
                DisplayCharset.SfrPrint();                
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor(); 
                Charset.WifiCharset();                
            }
        }

        internal void BoxAdslLivebox()
        {
            while (Charset.BooleanType)
            {
                DisplayCharset.LiveboxPrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor();
                Charset.WifiCharset();
            }
        }
    }
}
