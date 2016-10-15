using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Crisis.Charset
{
    class Special : Default
    {
        public List<string> ReadFileTxt()
        {
            if (File.Exists(charsetName.ToString()))
            {
                try
                {
                    charsetSelecting.Add(System.IO.File.ReadAllText(CharsetName.ToString()));
                    
                }
                catch (OutOfMemoryException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n The file is too large to be stored in RAM !");
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();
                }

            }

            return charsetSelecting;
        }

        public List<string> ListWifiCharset(string charsetName)
        {
            if (charsetName == "sfr")
            {
                charsetSelecting = Sfr_fr.Concat(Numeric).Concat(Ualpha).Concat(Lalpha).ToList();
                //Property.NumberOfChar = 20;

            }
            else if (charsetName == "livebox-sagem")
            {
                charsetSelecting = Livebox_sagem.ToList();
               // Property.NumberOfChar = 26;

            }
            

            return charsetSelecting;
        }

        public List<string> ListHexa(string charsetName)
        {
            if (charsetName == "hex-lower")
            {
                //hex-lower
                charsetSelecting = Numeric.Concat(Hex_lower).ToList();                
            }
            else if (charsetName == "hex-upper")
            {
                //hex-upper 
                charsetSelecting = Numeric.Concat(Hex_upper).ToList();
            }
            
            return charsetSelecting;
        }

        public List<string> ListNumeric(string charsetName)
        {
            if (charsetName == "numeric")
            {
                //numeric
                charsetSelecting = Numeric;
            }
            else if (charsetName == "numeric-space")
            {
                //numeric-space
                charsetSelecting = Numeric.Concat(Space).ToList();
            }
            
            return charsetSelecting;
        }

        public List<string> ListSymbols(string charsetName)
        {
            if (charsetName == "symbols14")
            {
                //symbols14  
                charsetSelecting = Symbols14;                
            }
            else if (charsetName == "symbols14-space")
            {
                //symbols14-space
                charsetSelecting = Symbols14.Concat(Space).ToList();                
            }
            else if (charsetName == "symbols-all")
            {
                //symbols-all
                charsetSelecting = Symbols14.Concat(Symbols_all).ToList();                
            }
            else if (charsetName == "symbols-all-space")
            {
                //symbols-all-space
                charsetSelecting = Symbols14.Concat(Symbols_all).Concat(Space).ToList();
            }           

            return charsetSelecting;
        }
    }
}
