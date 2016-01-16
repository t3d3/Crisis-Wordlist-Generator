//  Author:
//       Teeknofil <teeknofil@gmail.com>
//
//  Copyright (c) 2015 Teeknofil
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Numerics;

namespace crisis
{
    

    public class Statistical
    {
        private BigInteger dataSizeOctet;

        private static BigInteger numberOfAllCombination;
        public static BigInteger NumberOfAllCombination
        {
            get { return Statistical.numberOfAllCombination; }
            set { Statistical.numberOfAllCombination = value; }
        }       

        private static int sizeFileInOctet;

        public static int DefaultSizeFileInOctet
        {
            get
            {
                return sizeFileInOctet;
            }
            set
            {
                sizeFileInOctet = value;
            }
        }
                
        public Statistical()
        {
            dataSizeOctet = 0;
            sizeFileInOctet = 104857600;
        }

       
        internal BigInteger CalculOfAllCombinaison()
        {
           try
            {
                numberOfAllCombination = new BigInteger();

                if (Parameter.TypesOfGeneration == 1 | Parameter.TypesOfGeneration == 2)
                {
                    numberOfAllCombination = CombinationPattern.CaclulCombination().Count; 
                }
                else if (Parameter.TypesOfGeneration == 3 | Parameter.TypesOfGeneration == 6)
                {
                    numberOfAllCombination = (BigInteger)Math.Pow((double)Parameter.NumberOfChar, (double)Charset.CharsetSelecting.Count);
                }
                else if (Parameter.TypesOfGeneration == 4)
                {
                    numberOfAllCombination = VariationnPattern.CalculVariation().Count;
                }
                else if (Parameter.TypesOfGeneration == 5)
                {
                    numberOfAllCombination = PermutationPattern.CaclulPermut();
                }

            }
            catch (Exception) 
            {
                numberOfAllCombination = 9999999999999999999;
            }

            return numberOfAllCombination;
        }

        internal BigInteger CalculSizeFile()
        {
            // 104857600 octet = 100 Mo
            // Not to change
            // Ne pas modifier

            BigInteger nbLine = DefaultSizeFileInOctet / (Parameter.NumberOfChar + 2);

            if ( nbLine - 1 > Parameter.NumberLine  )
            {
                return Parameter.NumberLine;                        
            }
            else
            {
                Parameter.NumberLine = nbLine;
            }
            
            return Parameter.NumberLine;
        }

        internal void StatiscalInfoSize()
        {
            if (Parameter.TypesOfGeneration == 1)
            {
                dataSizeOctet = (BigInteger)(Parameter.NumberOfChar + 14) * NumberOfAllCombination;
            }            
            else if (Parameter.TypesOfGeneration == 2 | Parameter.TypesOfGeneration == 3 | Parameter.TypesOfGeneration == 4 | Parameter.TypesOfGeneration == 5 |Parameter.TypesOfGeneration == 6)
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
            Console.WriteLine("\n {0} KB", dataSizeKo);
            Console.WriteLine(" {0} MB", dataSizeMo);
            Console.WriteLine(" {0} GB", dataSizeGo);
            Console.WriteLine(" {0} TB", dataSizeTo);
            Console.WriteLine(" {0} PB", dataSizePo);
            Console.WriteLine("\n Crisis will now generate the following number of lines: {0}\n ", NumberOfAllCombination);

            System.Threading.Thread.Sleep(5000);
        }

    }
}