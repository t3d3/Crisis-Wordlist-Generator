using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public static partial class Charset
    {
        public static List<string> Lalpha()
        {
            if (charsetName == "lalpha")
            {
                //lalpha
                charsetSelecting = lalpha.ToList();
                booleanType = false;
            }
            else if (charsetName == "lalpha-space")
            {
                // lalpha_space
                charsetSelecting = lalpha.Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric")
            {
                // lalpha-numeric
                charsetSelecting = lalpha.Concat(numeric).ToList();
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric-space")
            {
                // lalpha-numeric-space
                charsetSelecting = lalpha.Concat(numeric).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric-symbol14")
            {
                //lalpha-numeric-symbol14
                charsetSelecting = lalpha.Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric-symbol14-space")
            {
                // lalpha-numeric-symbol14-space
                charsetSelecting = lalpha.Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric-all")
            {
                //lalpha-numeric-all
                charsetSelecting = lalpha.Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric-all-space")
            {
                //lalpha-numeric-all-space
                charsetSelecting = lalpha.Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                booleanType = false;
            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }



        public static List<string> Ualpha()
        {
            if (charsetName == "ualpha")
            {
                //ualpha
                charsetSelecting = ualpha;
                booleanType = false;
            }
            else if (charsetName == "ualpha-space")
            {
                //ualpha-space
                charsetSelecting = ualpha.Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric")
            {
                //ualpha-numeric
                charsetSelecting = ualpha.Concat(numeric).ToList();
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric-space")
            {
                //ualpha_numeric_space
                charsetSelecting = ualpha.Concat(numeric).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric-symbol14")
            {
                // ualpha_numeric_symbol14
                charsetSelecting = ualpha.Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric-symbol14-space")
            {
                //ualpha_numeric-symbol14-space
                charsetSelecting = ualpha.Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric-all")
            {
                //ualpha-numeric-all
                charsetSelecting = ualpha.Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric-all-space")
            {
                //ualpha-numeric-all-space
                charsetSelecting = ualpha.Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                booleanType = false;
            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }


        public static List<string> MixAlpha()
        {


            if (charsetName == "mixalpha")
            {
                //mixalpha
                charsetSelecting = lalpha.Concat(ualpha).ToList();
                booleanType = false;
            }
            else if (charsetName == "mixalpha-space")
            {
                //mixalpha-space
                charsetSelecting = lalpha.Concat(ualpha).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixalpha-numeric")
            {
                //mixalpha-numeric
                charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixalpha-numeric-space")
            {
                //mixalpha-numeric-space
                charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixalpha-numeric-symbol14")
            {
                //mixalpha-numeric-symbol14
                charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixalpha-numeric-symbol14-space")
            {
                //mixalpha-numeric-symbol14-space
                charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixalpha-numeric-all")
            {
                // mixalpha-numeric-all
                charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;

            }
            else if (charsetName == "mixalpha-numeric-all-space")
            {
                // mixalpha-numeric-all-space
                charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
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
