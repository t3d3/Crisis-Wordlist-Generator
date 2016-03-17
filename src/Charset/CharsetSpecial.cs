using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace crisis
{
    public static partial class Charset
    {
        public static List<string> ReadFileTxt()
        {
            if (File.Exists(charsetName.ToString()))
            {
                try
                {
                    charsetSelecting.Add(System.IO.File.ReadAllText(CharsetName.ToString()));
                    booleanType = false;
                    MainMenu.BooleanCategoryMenu = false;
                    MenuParameter.TypesOfGeneration = 8;
                }
                catch (OutOfMemoryException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n The file is too large to be stored in RAM !");
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();
                    MenuParameter.TypesOfGeneration = 0;
                }

            }
            else
            {
                booleanType = true;
                MainMenu.BooleanCategoryMenu = true;
                MenuParameter.TypesOfGeneration = 0;
            }
            return charsetSelecting;
        }

        public static List<string> WifiCharset()
        {
            if (charsetName == "sfr")
            {
                charsetSelecting = sfr_fr.Concat(numeric).Concat(ualpha).Concat(lalpha).ToList();
                booleanType = false;
                SubMenu.BooleanSubMenu = false;
                MainMenu.BooleanCategoryMenu = false;
                Property.NumberOfChar = 20;

            }
            else if (charsetName == "livebox-sagem")
            {
                charsetSelecting = livebox_sagem.ToList();
                booleanType = false;
                SubMenu.BooleanSubMenu = false;
                MainMenu.BooleanCategoryMenu = false;
                Property.NumberOfChar = 26;

            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }

        public static List<string> Hexa()
        {
            if (charsetName == "hex-lower")
            {
                //hex-lower
                charsetSelecting = numeric.Concat(hex_lower).ToList();
                booleanType = false;
            }
            else if (charsetName == "hex-upper")
            {
                //hex-upper 
                charsetSelecting = numeric.Concat(hex_upper).ToList();
                booleanType = false;
            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }

        public static List<string> Numeric()
        {
            if (charsetName == "numeric")
            {
                //numeric
                charsetSelecting = numeric;
                booleanType = false;
            }
            else if (charsetName == "numeric-space")
            {
                //numeric-space
                CharsetSelecting = numeric.Concat(space).ToList();
                booleanType = false;
            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }



        public static List<string> Symbols()
        {
            if (charsetName == "symbols14")
            {
                //symbols14  
                charsetSelecting = symbols14;
                booleanType = false;
            }
            else if (charsetName == "symbols14-space")
            {
                //symbols14-space
                charsetSelecting = symbols14.Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "symbols-all")
            {
                //symbols-all
                charsetSelecting = symbols14.Concat(symbols_all).ToList();
                booleanType = false;
            }
            else if (charsetName == "symbols-all-space")
            {
                //symbols-all-space
                charsetSelecting = symbols14.Concat(symbols_all).Concat(space).ToList();
                booleanType = false;
            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }
    }
}
