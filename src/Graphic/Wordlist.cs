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

using System;
using Crisis.Graphic.Menu;
using System.Resources;
using System.Threading;

namespace Crisis.Graphic
{
    class Wordlist
    {
        private static ResourceManager lang;
        public static bool CUSTOM = false;

        public Wordlist(ResourceManager _lang)
        {
            lang = _lang;
        }

        public Wordlist()
        {
            
        }

        public void MainCharacter()
        {
           

            Main subMenu = new Main(lang);
            subMenu.LocalBruteForcerMenu();

            Interface category = new Interface(lang);           

            bool b = true;

            while (b)
            {
                int i = category.SelectOption(6);

                if (i == 1)
                {
                    LatinCharactere();
                    b = false;
                }
                else if (i == 2)
                {
                    SpecialCharacter(); 
                    b = false;
                }
                else if (i == 3)
                {
                    SwedishCharacter();
                    b = false;
                }
                else if (i == 4)
                {
                    CyrillicCharacter();
                    b = false;
                }
                else if (i == 5)
                {
                    Syllable_FrCharacter();
                    b = false;
                }
                else if (i == 6)
                {
                    CUSTOM = true;
                    b = false;
                }
                else if (i == 88)
                {
                    new Run(lang);
                }
                else if (i == 99)
                {
                    Environment.Exit(0);
                }                
            }
            
        }


        public int Wifi()
        {

            Main.Version();
            Character.WifiMenu(lang);
            Interface category = new Interface(lang);

            int i = 0;

            bool b = true;

            while (b)
            {
                i = category.SelectOption(2);
               
                if (i == 1)
                {
                    Pattern.SfrPrint();
                    b = false;
                }
                else if (i == 2)
                {
                    Pattern.LiveboxPrint();
                    b = false;
                    
                }                
                else if (i == 88)
                {
                    new Run(lang);
                }
                else if (i == 99)
                {
                    Environment.Exit(0);
                }
            }

            Return(i);

            return i;

        }


        internal void Return(int i)
        {
            if (i == 77)
            {
                Wordlist back = new Wordlist();                
                Thread workerThread = new Thread(back.MainCharacter);
            }
            else if (i == 88)
            {
                new Run(lang);
            }
            else if (i == 99)
            {
                Environment.Exit(0);
            }
        }



        /// <summary>
        /// Display character and selecting pattern latin
        /// </summary>
        internal void LatinCharactere()
        {
            Character chars = new Character(lang);
            chars.LatinMenu();

            Interface selection = new Interface(lang);            

            bool b = true;
            int i = 0;

            while (b)
            {
                i = selection.SelectOption(3);
                if (i == 1)
                {
                    Pattern.LatinCharacterLowercasePrint();
                    b = false;
                }
                else if (i == 2)
                {
                    Pattern.LatinCharacteUppercasePrint();
                    b = false;
                }
                else if (i == 3)
                {
                    Pattern.LatinCharacterUppercaseLowercasePrint();
                    b = false;
                }
              
            }
           
        }

        /// <summary>
        /// Display character and selecting special character
        /// </summary>
        internal void SpecialCharacter()
        {
            Character chars = new Character(lang);
            chars.SpecialMenu();
            Interface selection = new Interface(lang);            

            bool b = true;

            while (b)
            {
                int i = selection.SelectOption(3);

                if (i == 1)
                {
                    Pattern.MenuHexaPrint();
                    b = false;
                }
                else if (i == 2)
                {
                    Pattern.MenuNumericPrint();
                    b = false;
                }                
                else if (i == 3)
                {
                    Pattern.MenuSpecialCharacteresPrint();
                    b = false;
                }
                                
            }
            
        }

        /// <summary>
        /// Display character and selecting Swedish special charactere
        /// </summary>
        
        internal void SwedishCharacter()
        {
            Character chars = new Character(lang);
            chars.SwedishMenu();
            Interface selection = new Interface(lang);            

            bool b = true;

            while (b)
            {
                int i = selection.SelectOption(3);

                if (i == 1)
                {
                    Pattern.SwddishCharacterLowercasePrint();
                    b = false;
                }
                else if (i == 2)
                {
                    Pattern.SwddishCharacterUppercasePrint();
                    b = false;
                }
                else if (i == 3)
                {
                    Pattern.SwddishCharacterLowercaseUppercasePrint();
                    b = false;
                }                
                                
            }
           
        }

        internal void  CyrillicCharacter()
        {

            Character chars = new Character(lang);
            chars.CyrillicMenu();
            Interface selection = new Interface(lang);

            bool b = true;

            while (b)
            {
                int i = selection.SelectOption(3);

                if (i == 1)
                {
                    Pattern.CyrillicCharacterLowercasePrint();
                    b = false;
                }
                else if (i == 2)
                {
                    Pattern.CyrillicCharacterUppercasePrint();
                    b = false;
                }
                else if (i == 3)
                {
                    Pattern.CyrillicCharacterUppercaseLowercasePrint();
                    b = false;
                }

            }            
        }
        /// <summary>
        /// display and selecting french syllable
        /// </summary>
        internal void  Syllable_FrCharacter()
        {
            Character chars = new Character(lang);
            chars.SyllableMenu();
            Interface selection = new Interface(lang);           

            bool b = true;

            while (b)
            {
                int i = selection.SelectOption(3);

                if (i == 1)
                {
                    Pattern.SyllableCharacterLowercasePrint();
                    b = false;
                }
                else if (i == 2)
                {
                    Pattern.SwddishCharacterUppercasePrint();
                    b = false;
                }
                else if (i == 3)
                {
                    Pattern.SwddishCharacterLowercaseUppercasePrint();
                    b = false;
                }
                                
            }           
        }


    }
}
