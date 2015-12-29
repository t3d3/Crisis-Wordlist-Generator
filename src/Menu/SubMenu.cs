using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public class SubMenu
    {

        private static bool booleanSubMenu = true;

        public static bool BooleanSubMenu
        {
            get { return SubMenu.booleanSubMenu; }
            set { SubMenu.booleanSubMenu = value; }
        }
        
        public SubMenu()
        {

        }
                
        // SubMenu Special
        internal void MenuHexa()
        {           
            while (Charset.BooleanType)
            {                
                MenuDisplayCharset.MenuHexaPrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();                
                Charset.Hexa();
            }
            
        }

        internal  void MenuLeetSpeak()
        {
            while (Charset.BooleanType)
            {                
                               
                MenuDisplayCharset.MenuLeetSpeakPrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine();
                Charset.ReadFileTxt();
                Parameter.TypesOfGeneration = 4; 
            }            
        }

        internal void MenuNumeric()
        {            
            while (Charset.BooleanType)
            {
                MenuDisplayCharset.MenuNumericPrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();                
                Charset.Numeric();
            }            
        }

        internal void MenuSpecialCharacteres()
        {            
            while (Charset.BooleanType)
            {               
                MenuDisplayCharset.MenuSpecialCharacteresPrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();
                Charset.Symbols();
            }            
        }

        //Sub Menu Latin

        internal void LatinCharacterLowercase()
        {           
            while (Charset.BooleanType)
            {                
                MenuDisplayCharset.LatinCharacterLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();
                Charset.Lalpha();
            }
           
        }

        internal void LatinCharacteUppercase()
        {
            
            while (Charset.BooleanType)
            {                
                MenuDisplayCharset.LatinCharacteUppercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();
                Charset.Ualpha();
            }
            
        }

        internal void LatinCharacterUppercaseLowercase()
        {
            
            while (Charset.BooleanType)
            {                
                MenuDisplayCharset.LatinCharacterUppercaseLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();
                Charset.MixAlpha();
            }
            
        }

        // Sub Menu Swddish

        internal void SwddishCharacterUppercase()
        {
            
            while (Charset.BooleanType)
            {                
                MenuDisplayCharset.SwddishCharacterUppercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();
                Charset.Ualpha_sv();
            }
            
        }

        internal void SwddishCharacterLowercase()
        {            
            while (Charset.BooleanType)
            {                
                MenuDisplayCharset.SwddishCharacterLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();
                Charset.Lalpha_sv();
            }            
        }


        internal void SwddishCharacterLowercaseUppercase()
        {
            

            while (Charset.BooleanType)
            {                
                MenuDisplayCharset.SwddishCharacterLowercaseUppercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();

                Charset.MixAlpha_sv();
            }
           
        }

        // Sub Menu Syllable

        internal void SyllableCharacterLowercase()
        {           
            while (Charset.BooleanType)
            {                
                MenuDisplayCharset.SyllableCharacterLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();
                Charset.Lsyllable_fr();
            }
            
        }

        internal void SyllableCharacteUppercase()
        {
            
            while (Charset.BooleanType)
            {                
                MenuDisplayCharset.SyllableCharacteUppercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();

                Charset.Usyllable_fr();
            }
            
        }

        

        internal void SyllableCharacterUppercaseLowercase()
        {            
            while (Charset.BooleanType)
            {                
                MenuDisplayCharset.SyllableCharacterUppercaseLowercasePrint();
                Console.Write(" Write the name corresponding to your choice : ");
                Charset.CharsetName = Console.ReadLine().ToLower();                
                Charset.mixsyllable_fr();
            }            
        }

        
        

    }
}
