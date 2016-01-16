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
using System.Linq;
using System.Text;
using System.Numerics;

namespace crisis
{
    public class Randomizer 
    {
        private Random random = null;
        
        public Randomizer()
        {
            random = new Random();
        }


        public string Aleatory()
        {
            string randonString = null;

            try
            {
                for (int i = 0; i < Parameter.NumberOfChar; i++)
                {
                    randonString += Charset.CharsetSelecting[random.Next(Charset.CharsetSelecting.Count)].ToString();
                }
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("{0}", e.Message);
            }

            return randonString;
        }


        public void RamdonPrintF()
        {
            FilesNameDirectory make = new FilesNameDirectory();
            BigInteger cpt = 0;


            if (Parameter.SaveFile == true)
            {
                make.Setting_UpFile();

                BigInteger i = 0;

                while ( Statistical.NumberOfAllCombination >= cpt )
                {
                    
                    make.WorkFile.WriteLine(this.Aleatory());
                    ++i;
                    ++cpt;
                    
                    if (i >= Parameter.NumberLine - 1 || cpt >= Statistical.NumberOfAllCombination)
                    {
                        i = 0;
                        make.WorkFile.Flush();
                        make.WorkFile.Close();
                        make.Setting_UpFile();
                    }           
                }
            }
            else
            {
                while (cpt <= Statistical.NumberOfAllCombination)
                {
                    Console.WriteLine(this.Aleatory());
                    cpt++;
                }
            }
        } // End Function
        

    }
}
