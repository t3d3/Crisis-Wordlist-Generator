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

namespace crisis
{
    public class LeetSpeak : Property 
    {

        public LeetSpeak()
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

            switch (Char.ToLower(letterLeet))
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

        public void L33tSpeekPrintF()
        {
            FilesNameDirectory make = new FilesNameDirectory();

            DateTime obj1 = DateTime.Now;
            string input = obj1.ToString().Substring(10);

            Console.Write("\n{0} : ", input);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This work, please wait !\n");
            Console.ResetColor();

            //if ( SaveFile == true)
            //{
                make.Setting_UpFile();

                foreach (var item in Charset.CharsetSelecting)
                {
                    make.WorkFile.WriteLine(ConverterInLeetSpeak(item.ToString()));
                }

                make.WorkFile.Close();
            //}
            //else
            //{
            //    Charset.CharsetSelecting.ForEach(x => Console.WriteLine(ConverterInLeetSpeak(x.ToString())));
            //}           
        
        } // End Function 

    }   
}
