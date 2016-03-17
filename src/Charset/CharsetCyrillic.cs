using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public static partial class Charset
    {
        public static List<string> Lcyrillic()
        {
            if (charsetName == "lcyrillic")
            {
                //lcyrillic
                charsetSelecting = cyrillic.ToList();
                ;
                booleanType = false;
            }
            else if (charsetName == "lcyrillic-space")
            {
                // lcyrillic-space
                charsetSelecting = cyrillic.Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "lcyrillic-numeric")
            {
                // lcyrillic-numeric
                charsetSelecting = cyrillic.Concat(numeric).ToList();
                booleanType = false;
            }
            else if (charsetName == "lcyrillic-numeric-space")
            {
                // lcyrillic-numeric-space
                charsetSelecting = cyrillic.Concat(numeric).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "lcyrillic-numeric-symbol14")
            {
                //lcyrillic-numeric-symbol14
                charsetSelecting = cyrillic.Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;
            }
            else if (charsetName == "lcyrillic-numeric-symbol14-space")
            {
                // lcyrillic-numeric-symbol14-space
                charsetSelecting = cyrillic.Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "lcyrillic-numeric-all")
            {
                //lcyrillic-numeric-all
                charsetSelecting = cyrillic.Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;
            }
            else if (charsetName == "lcyrillic-numeric-all-space")
            {
                //lcyrillic-numeric-all-space
                charsetSelecting = cyrillic.Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                booleanType = false;
            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }

        public static List<string> Ucyrillic()
        {
            if (charsetName == "ucyrillic")
            {
                //ucyrillique
                charsetSelecting = cyrillic.ConvertAll(item => item.ToUpper()).ToList();
                booleanType = false;
            }
            else if (charsetName == "ucyrillic-space")
            {
                //uacyrillique-space
                charsetSelecting = cyrillic.ConvertAll(item => item.ToUpper()).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "ucyrillic-numeric")
            {
                //ucyrillique-numeric
                charsetSelecting = cyrillic.ConvertAll(item => item.ToUpper()).Concat(numeric).ToList();
                booleanType = false;
            }
            else if (charsetName == "ucyrillic-numeric-space")
            {
                //ucyrillique_numeric_space
                charsetSelecting = cyrillic.ConvertAll(item => item.ToUpper()).Concat(numeric).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "ucyrillic-numeric-symbol14")
            {
                // ucyrillique_numeric_symbol14
                charsetSelecting = cyrillic.ConvertAll(item => item.ToUpper()).Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;
            }
            else if (charsetName == "ucyrillic-numeric-symbol14-space")
            {
                //ucyrillique_numeric-symbol14-space
                charsetSelecting = cyrillic.ConvertAll(item => item.ToUpper()).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "ucyrillic-numeric-all")
            {
                //ucyrillique-numeric-all
                charsetSelecting = cyrillic.ConvertAll(item => item.ToUpper()).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;
            }
            else if (charsetName == "ucyrillic-numeric-all-space")
            {
                //ucyrillique-numeric-all-space
                charsetSelecting = cyrillic.ConvertAll(item => item.ToUpper()).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                booleanType = false;
            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }

        public static List<string> MixCyrillic()
        {


            if (charsetName == "mixcyrillic")
            {
                //mixcyrillic
                charsetSelecting = cyrillic.Concat(cyrillic.ConvertAll(item => item.ToUpper())).ToList();
                booleanType = false;
            }
            else if (charsetName == "mixcyrillic-space")
            {
                //mixcyrillic-space
                charsetSelecting = cyrillic.Concat(cyrillic.ConvertAll(item => item.ToUpper())).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixcyrillic-numeric")
            {
                //mixcyrillic-numeric
                charsetSelecting = cyrillic.Concat(cyrillic.ConvertAll(item => item.ToUpper())).Concat(numeric).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixcyrillic-numeric-space")
            {
                //mixcyrillic-numeric-space
                charsetSelecting = cyrillic.Concat(cyrillic.ConvertAll(item => item.ToUpper())).Concat(numeric).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixcyrillic-numeric-symbol14")
            {
                //mixcyrillic-numeric-symbol14
                charsetSelecting = cyrillic.Concat(cyrillic.ConvertAll(item => item.ToUpper())).Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixcyrillic-numeric-symbol14-space")
            {
                //mixcyrillic-numeric-symbol14-space
                charsetSelecting = cyrillic.Concat(cyrillic.ConvertAll(item => item.ToUpper())).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixcyrillic-numeric-all")
            {
                // mixcyrillic-numeric-all
                charsetSelecting = cyrillic.Concat(cyrillic.ConvertAll(item => item.ToUpper())).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixcyrillic-numeric-all-space")
            {
                // mixcyrillic-numeric-all-space
                charsetSelecting = cyrillic.Concat(cyrillic.ConvertAll(item => item.ToUpper())).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
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
