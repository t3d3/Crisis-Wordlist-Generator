using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace crisis
{
    public class Combination   
    {
        private int numberOfChar;

        public int NumberOfChar
        {
            get { return numberOfChar; }
            set { numberOfChar = value; }
        }

        private Random random = new Random();
        

        public Combination()
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
            for (int i = 0; i < numberOfChar; i++)
            {
                randonString += Charset.CharsetSelecting[random.Next(Charset.CharsetSelecting.Count)].ToString();
            }
            return randonString;
        }

        private double factorial(int x)
        {
            double buffer = 1;
            while(x > 1) //tant que x est supérieur a 1
            {
                buffer = buffer * x; // je multiple
                x--; // je decremente mon x
            }
            return buffer;
        }

       

        public List<String> CombinationCharset(List<String> charset, int NumberOfChar, int k)
        {
            int h = 0, i = 0, j = 0;
            int[] array = new int[NumberOfChar - 1];
            for (int tmp = 0; tmp < NumberOfChar - 1; tmp++)
            {
                array[tmp] = 0;
            }
            
            string s = "";
            List<String> resultCombinationNoRepeats = new List<String>();
            

            if ((charset.Count < NumberOfChar) || (NumberOfChar == 1))
            {
                return charset;
            }
            else if (charset.Count == NumberOfChar)
            {
                while (i < charset.Count)
                {
                    s += charset[i];
                    i++;
                }
                resultCombinationNoRepeats.Add(s);
            }
            else if (charset.Count > NumberOfChar)
            {
               
                double numberCombinationNoRepeat = factorial(charset.Count - 1) /  ( factorial(NumberOfChar - 1) * factorial((charset.Count - 1) - (NumberOfChar - 1)) ) ;                
                
                while (i < numberCombinationNoRepeat)
                {

                    s = charset[charset.Count - 1];
                    while (h < array.Length)
                    {
                        if (j > 0 && j < array.Length)
                        {
                            array[j] = array[j - 1] + 1;
                        }

                        s += charset[array[h]];
                        h++;
                        j++;                        

                    }

                    if (resultCombinationNoRepeats.Count == 25100000)
                    {
                        return resultCombinationNoRepeats;                         
                    }

                    

                    resultCombinationNoRepeats.Add(s);
                    h = 0;
                    j = 0;


                    while (j < array.Length && array[j] != j + k)
                    {
                        j++;
                    }

                    if (j > 0)
                    {
                        array[j - 1] = array[j - 1] + 1;
                    }

                    i++ ;
                }               
            }
            return resultCombinationNoRepeats;
        }

    } // End Class
} // End Namespace
