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
using crisis;
using System.Linq;
using System.Text;
using System.Numerics;
using System.IO.Compression;
using System.Collections.Generic;
using System.Security.Cryptography;
using Crisis.Tools;
//using crisis.Ionic.Zip;

namespace Crisis.Combinatorics
{
    public class Randomizer 
    {        
        
        public Randomizer()
        {            
        }
                
        /// <summary>
        /// Return At string Ramdom
        /// </summary>
        /// <returns>string</returns>

        public string Aleatory(List<string> charsetSelecting, int numberOfChar)
        {            
            byte[] data = new byte[1];
            
            using (RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                cryptoServiceProvider.GetNonZeroBytes(data);
                data = new byte[numberOfChar];
                cryptoServiceProvider.GetNonZeroBytes(data);
            }

            StringBuilder stringBuilder = new StringBuilder(numberOfChar);
            foreach (byte num in data)
                stringBuilder.Append(charsetSelecting[(int)num % charsetSelecting.Count]);

            return stringBuilder.ToString();
        }

        /// <summary>
        /// retun a list random of string
        /// </summary>
        /// <param name="charsetSelecting"></param>
        /// <param name="numberLine"></param>
        /// <param name="numberOfAllCombination"></param>
        /// <param name="saveFile"></param>
        /// <param name="zip"></param>       
        /// <param name="numberOfChar"></param>
        /// <param name="filePath"></param>
        /// <param name="extension"></param>
        public void GenerateRandomString(List<string> charsetSelecting, BigInteger numberLine, BigInteger numberOfAllCombination, bool saveFile, bool zip,  int numberOfChar, string filePath, string extension)
        {
            Utility make = new Utility();
            BigInteger cpt = 0;

            if (saveFile)
            {
                BigInteger iMakeFile = 0;

                while  (numberOfAllCombination >= cpt)
                {
                    if (iMakeFile == 0)
                    {
                        make.Setting_UpFile(filePath,extension);
                    }

                    make.WorkFile.WriteLine(this.Aleatory(charsetSelecting, numberOfChar));
                    ++iMakeFile;
                    ++cpt;

                    if (iMakeFile >= numberLine || cpt >= numberOfAllCombination)
                    {
                        make.WorkFile.Flush();
                        make.WorkFile.Close();
                        make.Zipper(zip);
                        make.GenerateOut(extension);
                        iMakeFile = 0;
                    }
                }
            }
            else
            {
                while (cpt <= numberOfAllCombination)
                {
                    Console.WriteLine(this.Aleatory(charsetSelecting, numberOfChar));
                    cpt++;
                }
            }
        }

       
    }
}
