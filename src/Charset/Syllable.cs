using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crisis.Charset
{
    class Syllable : Default
    {
        public List<string> ListSyllableLowerCase_fr(string charsetName)
        {
            if (charsetName == "lsyllable")
            {
                //syllable
                charsetSelecting = Syllable_fr;
            }
            else if (charsetName == "lsyllable-space")
            {
                //lsyllable-space
                charsetSelecting = Syllable_fr.Concat(Space).ToList();
            }
            else if (charsetName == "lsyllable-numeric")
            {
                // lsyllable-numeric
                charsetSelecting = Syllable_fr.Concat(Numeric).ToList();
            }
            else if (charsetName == "lsyllable-numeric-space")
            {
                // lsyllable-numeric-space
                charsetSelecting = Syllable_fr.Concat(Numeric).Concat(Space).ToList();
           }
            else if (charsetName == "lsyllable-numeric-symbol14")
            {
                //lsyllable - numeric - symbol14
                charsetSelecting = Syllable_fr.Concat(Numeric).Concat(Symbols14).ToList();
            }
            else if (charsetName == "lsyllable-numeric-symbol14-space")
            {
                // lsyllable-numeric-symbol14-space
               charsetSelecting = Syllable_fr.Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();
            }
            else if (charsetName == "lsyllable-numeric-all")
            {
                //lsyllable-numeric-all
                charsetSelecting = Syllable_fr.Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();
            }
            else if (charsetName == "lsyllable-numeric-all-space")
            {
                //lsyllable-numeric-all-space
                charsetSelecting = Syllable_fr.Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();
            }
            
            return charsetSelecting;
        }

        public List<string> ListSyllableUpperCase_fr(string charsetName)
        {
            if (charsetName == "usyllable")
            {
                //usyllable
                charsetSelecting = Syllable_fr.ConvertAll(item => item.ToUpper());
            }
            else if (charsetName == "usyllable-space")
            {
                //usyllable-space
                charsetSelecting = Syllable_fr.ConvertAll(item => item.ToUpper()).Concat(Space).ToList();
            }
            else if (charsetName == "usyllable-numeric")
            {
                //usyllable-numeric
                charsetSelecting = Syllable_fr.ConvertAll(item => item.ToUpper()).Concat(Numeric).ToList();
            }
            else if (charsetName == "usyllable-numeric-space")
            {
                //usyllable-numeric-space
                charsetSelecting = Syllable_fr.ConvertAll(item => item.ToUpper()).Concat(Numeric).Concat(Space).ToList();
            }
            else if (charsetName == "usyllable-numeric-symbol14")
            {
                //usyllable-numeric-symbol14
                charsetSelecting = Syllable_fr.ConvertAll(item => item.ToUpper()).Concat(Numeric).Concat(Symbols14).ToList();
            }
            else if (charsetName == "usyllable-numeric-symbol14-space")
            {
                //usyllable_numeric-symbol14-space
                charsetSelecting = Syllable_fr.ConvertAll(item => item.ToUpper()).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();
            }
            else if (charsetName == "usyllable-numeric-all")
            {
                //usyllable-numeric-all
                charsetSelecting = Syllable_fr.ConvertAll(item => item.ToUpper()).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();
            }
            else if (charsetName == "usyllable-numeric-all-space")
            {
                //usyllable-numeric-all-space
                charsetSelecting = Syllable_fr.ConvertAll(item => item.ToUpper()).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();
            }
            
            return charsetSelecting;
        }

        public List<string> ListMixsyllable_fr(string charsetName)
        {
            if (charsetName == "mixsyllable")
            {
                //mixsyllable
                charsetSelecting = Syllable_fr.Concat(Syllable_fr.ConvertAll(item => item.ToUpper())).ToList();
            }
            else if (charsetName == "mixsyllable-space")
            {
                //mixsyllable-space
                charsetSelecting = Syllable_fr.Concat(Syllable_fr.ConvertAll(item => item.ToUpper())).Concat(Space).ToList();
            }
            else if (charsetName == "mixsyllable-numeric")
            {
                //mixsyllable-numeric
                charsetSelecting = Syllable_fr.Concat(Syllable_fr.ConvertAll(item => item.ToUpper())).Concat(Numeric).ToList();
            }
            else if (charsetName == "mixsyllable-numeric-space")
            {
                //mixsyllable-numeric-space
                charsetSelecting = Syllable_fr.Concat(Syllable_fr.ConvertAll(item => item.ToUpper())).Concat(Numeric).Concat(Space).ToList();
            }
            else if (charsetName == "mixsyllable-numeric-symbol14")
            {
                charsetSelecting = Syllable_fr.Concat(Syllable_fr.ConvertAll(item => item.ToUpper())).Concat(Numeric).Concat(Symbols14).ToList();
            }
            else if (charsetName == "mixsyllable-numeric-symbol14-space")
            {
                // mixsyllable-numeric-symbol14-space
                charsetSelecting = Syllable_fr.Concat(Syllable_fr.ConvertAll(item => item.ToUpper())).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();
            }
            else if (charsetName == "mixsyllable-numeric-all")
            {
                //mixsyllable-numeric-all
                charsetSelecting = Syllable_fr.Concat(Syllable_fr.ConvertAll(item => item.ToUpper())).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();
            }
            else if (charsetName == "mixsyllable-numeric-all-space")
            {
                //mixsyllable-numeric-all-space
                charsetSelecting = Syllable_fr.Concat(Syllable_fr.ConvertAll(item => item.ToUpper())).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();
            }
            
            return charsetSelecting;
        }
    }
}
