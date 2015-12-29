using System;
using System.Collections.Generic;
using System.Numerics;

namespace crisis
{
    /// <summary>
    /// An ASCII progress bar
    /// </summary>
    
    public class Statistical
    {  
        private BigInteger dataSizeOctet = 0;
        

        private static BigInteger numberOfAllCombination = 0;

        public static BigInteger NumberOfAllCombination
        {
            get { return Statistical.numberOfAllCombination; }
            set { Statistical.numberOfAllCombination = value; }
        }

        

        public Statistical()
        {
            
        }

        private static int defaultSizeFileInOctet = 524288000;

        public static int DefaultSizeFileInOctet
        {
            get
            {
                return defaultSizeFileInOctet;
            }
            set
            {
                defaultSizeFileInOctet = value;
            }
        }

        private BigInteger Factorial(int x)
        {
            BigInteger buffer = 1;
            while (x > 1) //tant que x est supérieur a 1
            {
                buffer = buffer * x; // je multiple
                x--; // je decremente mon x
            }
            return buffer;
        }

        internal BigInteger CalculOfAllCombinaison()
        {
            try
            {
                if (Parameter.TypesOfGeneration == 1 | Parameter.TypesOfGeneration == 2)
                {
                    numberOfAllCombination = Factorial(Charset.CharsetSelecting.Count - 1) / (Factorial(Parameter.NumberOfChar - 1) * Factorial((Charset.CharsetSelecting.Count - 1) - (Parameter.NumberOfChar - 1)));
                }
                else if (Parameter.TypesOfGeneration == 3)
                {
                    numberOfAllCombination = new BigInteger();
                    numberOfAllCombination = (BigInteger)Math.Pow((double)Parameter.NumberOfChar, (double)Charset.CharsetSelecting.Count);
                }
            }
            catch (Exception)
            {
                numberOfAllCombination = 9999999999999999999;
            }
            

            return numberOfAllCombination;                       
        }

        internal int CalculSizeFile()
        {
            // 524288000 octet = 500 Mo
            // Not to change
            // Ne pas modifier

            Parameter.NumberLine = DefaultSizeFileInOctet / (Parameter.NumberOfChar + 2);
            return Parameter.NumberLine;
        }

        internal void StatiscalInfoSize()
        {
            if (Parameter.TypesOfGeneration == 1)
            {
                dataSizeOctet = (BigInteger)(Parameter.NumberOfChar + 14) * NumberOfAllCombination;
            }
            else if ( Parameter.TypesOfGeneration == 2)
            {                
                dataSizeOctet = (Parameter.NumberOfChar + 2) * NumberOfAllCombination;
            }
            else if (Parameter.TypesOfGeneration == 3)
            {
                dataSizeOctet = (Parameter.NumberOfChar + 2) * NumberOfAllCombination;
            }

            BigInteger dataSizeKo = 4096;
            if (dataSizeOctet <= 4096)
            {
                dataSizeKo = 4;
            }
            else
            {
                dataSizeKo = dataSizeOctet / 1024;
            }

            BigInteger dataSizeMo = dataSizeKo / 1024;
            BigInteger dataSizeGo = dataSizeMo / 1024;
            BigInteger dataSizeTo = dataSizeGo / 1024;
            BigInteger dataSizePo = dataSizeTo / 1024;

            Console.WriteLine("\n Crisis will now generate the following amount of data: {0} ", dataSizeOctet);
            Console.WriteLine("\n {0} Ko", dataSizeKo);
            Console.WriteLine(" {0} Mo", dataSizeMo);
            Console.WriteLine(" {0} Go", dataSizeGo);
            Console.WriteLine(" {0} To", dataSizeTo);
            Console.WriteLine(" {0} Po", dataSizePo);
            Console.WriteLine("\n Crisis will now generate the following number of lines: {0}\n ", NumberOfAllCombination);

            System.Threading.Thread.Sleep(10000);
        }
        
    }
}