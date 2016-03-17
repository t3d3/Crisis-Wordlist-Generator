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
    public class SubMenu : Property
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


        internal void GenericMenuSelectCharset()
        {
            Command run = new Command(true);
            while (Charset.BooleanType)
            {
                Console.Write(" Write the name corresponding to your choice : ");
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor();

                string[] args = new string[] { Charset.CharsetName };
                run.FunctionPattern(args);
            }
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
       
    }
}
