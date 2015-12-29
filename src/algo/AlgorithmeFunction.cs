using System;
using System.Collections.Generic;
using System.Numerics;

namespace crisis
{
    public partial class Algorithme   
    {
        private Random random =  new Random();
        private static int indexEnuCharset = 0;
        private FilesNameDirectory make = null;
        

        public Algorithme()
        {
            
        }       
       

        public string ConverterInLeetSpeak(string _word)
        {
            string wordLeet = null;

            for (int i = 0; i < _word.Length; i++) 
            {
                wordLeet += FoundLetterLeet(_word[i]);
            }
            return wordLeet;
        }

        public char FoundLetterLeet(char _letter)
        {
            char letterLeet = _letter;

            switch(Char.ToLower(letterLeet))
            {
                case 'a':
                    letterLeet = '4';
                    break;
                case 'b':
                    letterLeet = '8';
                    break;
                case 'e':
                    letterLeet = '3';
                    break;
                case 'l':
                    letterLeet = '1';
                    break;
                case 'o':
                    letterLeet = '0';
                    break;
                case 's':
                    letterLeet = '5';
                    break;
                case 't':
                    letterLeet = '7';
                    break;
                case 'i':
                    letterLeet = '!';
                    break;
                case 'g':
                    letterLeet = '6';
                    break;
                case 'z':
                    letterLeet = '2';
                    break;                
            }

            return letterLeet;
        }       

        public string CombinationRamdon()
        {
            string randonString = null;
            for (int i = 0; i < Parameter.NumberOfChar; i++)
            {
                try
                {
                    randonString += Charset.CharsetSelecting[random.Next(Charset.CharsetSelecting.Count)].ToString();
                }
                catch (OutOfMemoryException e)
                {                    
                    Console.WriteLine("{0}", e.Message);                    
                }                
            }
            return randonString;
        }

        public string Enumeration(int[] nbIndexChar)
        {
            int h = 0, i = 0;
            string s = null;            
            
            if ((Charset.CharsetSelecting.Count < Parameter.NumberOfChar) || (Parameter.NumberOfChar == 1))
            {
                return Charset.CharsetSelecting.ToString();
            }
            else if (Charset.CharsetSelecting.Count == Parameter.NumberOfChar)
            {
                while (i < Charset.CharsetSelecting.Count)
                {
                    s += Charset.CharsetSelecting[i];
                    i++;
                }
                return s;
            }
            else if (Charset.CharsetSelecting.Count > Parameter.NumberOfChar)
            {
                s = Charset.CharsetSelecting[Charset.CharsetSelecting.Count - 1];
                while (h < nbIndexChar.Length)
                {
                    if (indexEnuCharset > 0 && indexEnuCharset < nbIndexChar.Length)
                    {
                        nbIndexChar[indexEnuCharset] = nbIndexChar[indexEnuCharset - 1] + 1;
                    }

                    s += Charset.CharsetSelecting[nbIndexChar[h]];
                    h++;
                    indexEnuCharset++;
                }

                h = 0;
                indexEnuCharset = 0;

                while (indexEnuCharset < nbIndexChar.Length && nbIndexChar[indexEnuCharset] != indexEnuCharset + Charset.CharsetSelecting.Count - Parameter.NumberOfChar)
                {
                    indexEnuCharset++;
                }

                if (indexEnuCharset > 0)
                {
                    nbIndexChar[indexEnuCharset - 1] = nbIndexChar[indexEnuCharset - 1] + 1;
                }
            }
            return s;
        }

        

    } // End Class
} // End Namespace
