using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crisis.Graphic.Menu;
using System.Reflection;
using System.Resources;

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
                int i = category.SelectOption();

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
                i = category.SelectOption();
               
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
                back.MainCharacter();
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
            Character.LatinMenu();
            Interface selection = new Interface(lang);            

            bool b = true;
            int i = 0;

            while (b)
            {
                i = selection.SelectOption();
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
                
                Return(i);
            }
           
        }

        /// <summary>
        /// Display character and selecting special character
        /// </summary>
        internal void SpecialCharacter()
        {
            Character.SpecialMenu();
            Interface selection = new Interface(lang);            

            bool b = true;

            while (b)
            {
                int i = selection.SelectOption();

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
                    b = false;
                }
                else if (i == 4)
                {
                    Pattern.MenuSpecialCharacteresPrint();
                    b = false;
                }

                Return(i);
            }
            
        }

        /// <summary>
        /// Display character and selecting Swedish special charactere
        /// </summary>
        
        internal void SwedishCharacter()
        {
            Character.SwedishMenu();
            Interface selection = new Interface(lang);            

            bool b = true;

            while (b)
            {
                int i = selection.SelectOption();

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

                Return(i);
            }
           
        }

        internal void  CyrillicCharacter()
        {          

            Character.CyrillicMenu();
            Interface selection = new Interface(lang);

            bool b = true;

            while (b)
            {
                int i = selection.SelectOption();

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
                Return(i);
            }            
        }
        /// <summary>
        /// display and selecting french syllable
        /// </summary>
        internal void  Syllable_FrCharacter()
        {
            Character.SyllableMenu();
            Interface selection = new Interface(lang);           

            bool b = true;

            while (b)
            {
                int i = selection.SelectOption();

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
                
                Return(i);
            }           
        }


    }
}
