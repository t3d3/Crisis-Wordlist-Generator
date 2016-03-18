using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public static partial class Charset
    {
        public static List<string> Lsyllable_fr()
        {
            if (charsetName == "lsyllable")
            {
                //syllable
                charsetSelecting = syllable_fr;
                booleanType = false;
            }
            else if (charsetName == "lsyllable-space")
            {
                // lsyllable_space
                charsetSelecting = syllable_fr.Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "lsyllable-numeric")
            {
                // lsyllable-numeric
                charsetSelecting = syllable_fr.Concat(numeric).ToList();
                booleanType = false;
            }
            else if (charsetName == "lsyllable-numeric-space")
            {
                // lsyllable-numeric-space
                charsetSelecting = syllable_fr.Concat(numeric).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "lsyllable-numeric-symbol14")
            {
                //lsyllable-numeric-symbol14
                charsetSelecting = syllable_fr.Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;
            }
            else if (charsetName == "lsyllable-numeric-symbol14-space")
            {
                // lsyllable-numeric-symbol14-space
                charsetSelecting = syllable_fr.Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "lsyllable-numeric-all")
            {
                //lsyllable-numeric-all
                charsetSelecting = syllable_fr.Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;
            }
            else if (charsetName == "lsyllable-numeric-all-space")
            {
                //lsyllable-numeric-all-space
                charsetSelecting = syllable_fr.Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                booleanType = false;
            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }

        public static List<string> Usyllable_fr()
        {
            if (charsetName == "usyllable")
            {

                //usyllable
                charsetSelecting = syllable_fr.ConvertAll(item => item.ToUpper());
                booleanType = false;
            }
            else if (charsetName == "usyllable-space")
            {
                //usyllable-space
                charsetSelecting = syllable_fr.ConvertAll(item => item.ToUpper()).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "usyllable-numeric")
            {

                //usyllable-numeric
                charsetSelecting = syllable_fr.ConvertAll(item => item.ToUpper()).Concat(numeric).ToList();
                booleanType = false;
            }
            else if (charsetName == "usyllable-numeric-space")
            {
                //usyllable_numeric_space
                charsetSelecting = syllable_fr.ConvertAll(item => item.ToUpper()).Concat(numeric).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "usyllable-numeric-symbol14")
            {
                // usyllable_numeric_symbol14
                charsetSelecting = syllable_fr.ConvertAll(item => item.ToUpper()).Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;
            }
            else if (charsetName == "usyllable-numeric-symbol14-space")
            {
                //usyllable_numeric-symbol14-space
                charsetSelecting = syllable_fr.ConvertAll(item => item.ToUpper()).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "usyllable-numeric-all")
            {
                //usyllable-numeric-all
                charsetSelecting = syllable_fr.ConvertAll(item => item.ToUpper()).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;
            }
            else if (charsetName == "usyllable-numeric-all-space")
            {
                //usyllable-numeric-all-space
                charsetSelecting = syllable_fr.ConvertAll(item => item.ToUpper()).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                booleanType = false;
            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }

        public static List<string> mixsyllable_fr()
        {
            if (charsetName == "mixsyllable")
            {
                //syllable
                charsetSelecting = syllable_fr.Concat(syllable_fr.ConvertAll(item => item.ToUpper())).ToList();
                booleanType = false;
            }
            else if (charsetName == "mixsyllable-space")
            {
                // mixsyllable_space
                charsetSelecting = syllable_fr.Concat(syllable_fr.ConvertAll(item => item.ToUpper())).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "mixsyllable-numeric")
            {
                // mixsyllable-numeric
                charsetSelecting = syllable_fr.Concat(syllable_fr.ConvertAll(item => item.ToUpper())).Concat(numeric).ToList();
                booleanType = false;
            }
            else if (charsetName == "mixsyllable-numeric-space")
            {
                // mixsyllable-numeric-space
                charsetSelecting = syllable_fr.Concat(syllable_fr.ConvertAll(item => item.ToUpper())).Concat(numeric).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "mixsyllable-numeric-symbol14")
            {
                //mixsyllable-numeric-symbol14
                charsetSelecting = syllable_fr.Concat(syllable_fr.ConvertAll(item => item.ToUpper())).Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;
            }
            else if (charsetName == "mixsyllable-numeric-symbol14-space")
            {

                // mixsyllable-numeric-symbol14-space
                charsetSelecting = syllable_fr.Concat(syllable_fr.ConvertAll(item => item.ToUpper())).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "mixsyllable-numeric-all")
            {
                //mixsyllable-numeric-all
                charsetSelecting = syllable_fr.Concat(syllable_fr.ConvertAll(item => item.ToUpper())).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;
            }
            else if (charsetName == "mixsyllable-numeric-all-space")
            {
                //mixsyllable-numeric-all-space
                charsetSelecting = syllable_fr.Concat(syllable_fr.ConvertAll(item => item.ToUpper())).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
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
