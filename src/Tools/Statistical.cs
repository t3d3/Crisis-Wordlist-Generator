//  Author:
//       Teeknofil <teeknofil.dev@gmail.com>
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
using System.Numerics;
using System.Collections.Generic;
using Crisis.Combinatorics;
using Crisis.CommandLine;

namespace Crisis.Tools
{
    class Statistical
    {

        public Statistical()
        {

        }

        internal BigInteger CalculOfAllCombinaison(bool _repeat, int typesAtGenerate, int numberOfChar, List<string> charsetSelecting)
        {

            BigInteger numberOfAllCombination = new BigInteger();

            try
            {
                
                if (typesAtGenerate == 1 | typesAtGenerate == 2)
                {
                    CombinationPattern obj = new CombinationPattern();
                    numberOfAllCombination = obj.CaclulCombination(_repeat,charsetSelecting,numberOfChar).Count;
                }
                else if (typesAtGenerate == 3 | typesAtGenerate == 6)
                {
                    numberOfAllCombination = (BigInteger)Math.Pow((double)numberOfChar, (double)charsetSelecting.Count);
                }
                else if (typesAtGenerate == 4)
                {
                    VariationnPattern obj = new VariationnPattern();
                    numberOfAllCombination = obj.CalculVariation(_repeat , charsetSelecting, numberOfChar).Count;
                }
                else if (typesAtGenerate == 5)
                {                    
                    numberOfAllCombination = PermutationPattern.CaclulPermut(_repeat,charsetSelecting,numberOfChar);
                }

                if (0 > numberOfAllCombination)
                {
                    numberOfAllCombination = -1 * numberOfAllCombination;
                }

            }
            catch (Exception)
            {
                numberOfAllCombination = 9999999999999999999;
            }

            return numberOfAllCombination;
        }


        internal void StatiscalInfoSize(BigInteger numberOfAllCombination, int typesOfGeneration, int numberOfChar)
        {
            BigInteger dataSizeOctet = 0;

            for (int i = 2; i <= 6 ; i++)
            {
                if (typesOfGeneration == 1)
                {
                    dataSizeOctet = (BigInteger)(numberOfChar + 20) * numberOfAllCombination;
                    break;
                }
                else if (typesOfGeneration == i )
                {
                    dataSizeOctet = (numberOfChar + 2) * numberOfAllCombination;
                    break;
                }
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
            Console.WriteLine("\n {0} KB\n", dataSizeKo);
            Console.WriteLine(" {0} MB\n", dataSizeMo);
            Console.WriteLine(" {0} GB\n", dataSizeGo);
            Console.WriteLine(" {0} TB\n", dataSizeTo);
            Console.WriteLine(" {0} PB\n", dataSizePo);
            Console.WriteLine("\n Crisis will now generate the following number of lines: {0}\n ", numberOfAllCombination);

            System.Threading.Thread.Sleep(5000);
        }

        internal BigInteger CalculSizeFile(int sizeFile, int numberOfChar, int typesOfGeneration, BigInteger numberOfAllCombination)
        {
            CLI options = new CLI();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();
            BigInteger numberLine = 0;

            if (options.Line == false)
            {
                 numberLine = sizeFile / (numberOfChar + 2);
            }

            return numberLine;
        }


    } // End Class
}// End Name space
