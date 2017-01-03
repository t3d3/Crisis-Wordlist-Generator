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
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Crisis.Charset;
using System.Text.RegularExpressions;
using System.Resources;
using Crisis.Tools;
using Crisis.Graphic;

namespace Crisis
{
    public class Parameter : CLI
    {
        private static BigInteger numberLine;
        public static BigInteger NumberLine
        {
            get { return Parameter.numberLine; }
            set { Parameter.numberLine = value; }
        }

        private static string pathBackUpFiles = null;
        public static string PathBackUpFiles
        {
            get{ return pathBackUpFiles; }
            set { pathBackUpFiles = value; }
        }


        protected ResourceManager lang;

        private static byte numberOfChar;
        public static byte NumberOfChar
        {
            get { return numberOfChar; }
            set { numberOfChar = value; }
        }

        private static List<string> charsetSelecting = new List<string>();
        public static List<string> CharsetSelecting
        {
            get { return Parameter.charsetSelecting; }
            set { Parameter.charsetSelecting = value; }
        }

        private static int typesAtGenerate;
        public static int TypesAtGenerate
        {
            get { return Parameter.typesAtGenerate; }
            set { Parameter.typesAtGenerate = value; }
        }

        private static BigInteger numberOfAllCombination;       
        public static BigInteger NumberOfAllCombination
        {
            get { return Parameter.numberOfAllCombination; }
            set { Parameter.numberOfAllCombination = value; }
        }

       

        public static new List<string> SelectPattern(string[] args)
        {
            try
            {
                Regex wifi = new Regex(@"sfr|livebox-sagem");
                Regex hex = new Regex(@"^hex.{6,6}$");
                Regex numeric = new Regex(@"^numeric.{0,6}$");
                Regex symbols = new Regex(@"^symbols.{0,10}$");

                Regex usyllable = new Regex(@"^usyllable.{0,23}$");
                Regex lsyllable = new Regex(@"^lsyllable.{0,23}$");
                Regex mixsyllable = new Regex(@"^mixsyllable.{0,23}$");

                Regex ualpha = new Regex(@"^ualpha.{0,23}$");
                Regex lalpha = new Regex(@"^lalpha.{0,23}$");
                Regex mixalpha = new Regex(@"^mixalpha.{0,23}$");


                Regex ualpha_sv = new Regex(@"^sv-ualpha.{0,23}");
                Regex lalpha_sv = new Regex(@"^sv-lalpha.{0,23}$");
                Regex mixalpha_sv = new Regex(@"^sv-mixalpha.{0,23}$");

                Regex lcyrillic = new Regex(@"^lcyrillic.{0,23}");
                Regex ucyrillic = new Regex(@"^ucyrillic.{0,23}");
                Regex mixcyrillic = new Regex(@"^mixcyrillic.{0,23}");
                
                for (int i = 0; i < args.Length; i++)
                {
                    if (hex.IsMatch(args[i].ToString().ToLower()))
                    {
                        Special charset = new Special();
                        charsetSelecting = charset.ListHexa(args[i].ToString().ToLower());
                        break;
                    }
                    else if (numeric.IsMatch(args[i].ToString().ToLower()))
                    {
                        Special charset = new Special();
                        charsetSelecting = charset.ListNumeric(args[i].ToString().ToLower());
                        break;
                    }
                    else if (symbols.IsMatch(args[i].ToString().ToLower()))
                    {
                        Special charset = new Special();
                        charsetSelecting = charset.ListSymbols(args[i].ToString().ToLower());
                        break;
                    }
                    else if (usyllable.IsMatch(args[i].ToString().ToLower()))
                    {

                        Syllable charset = new Syllable();
                        charsetSelecting = charset.ListSyllableUpperCase_fr(args[i].ToString().ToLower());
                        break;
                    }
                    else if (lsyllable.IsMatch(args[i].ToString().ToLower()))
                    {
                        Syllable charset = new Syllable();
                        charsetSelecting = charset.ListSyllableLowerCase_fr(args[i].ToString().ToLower());
                        break;
                    }
                    else if (mixsyllable.IsMatch(args[i].ToString().ToLower()))
                    {
                        Syllable charset = new Syllable();
                        charsetSelecting = charset.ListMixsyllable_fr(args[i].ToString().ToLower());
                        break;
                    }
                    else if (ualpha.IsMatch(args[i].ToString().ToLower()))
                    {
                        Alpha charset = new Alpha();
                        charsetSelecting = charset.Ualpha_List(args[i].ToString().ToLower());
                        break;

                    }
                    else if (lalpha.IsMatch(args[i].ToString().ToLower()))
                    {
                        Alpha charset = new Alpha();
                        charsetSelecting = charset.Lalpha_List(args[i].ToString().ToLower());
                        break;
                    }
                    else if (mixalpha.IsMatch(args[i].ToString().ToLower()))
                    {
                        Alpha charset = new Alpha();
                        charsetSelecting = charset.MixAlphaList(args[i].ToString().ToLower());
                        break;
                    }
                    else if (ualpha_sv.IsMatch(args[i].ToString()))
                    {
                        Alpha_sv charset = new Alpha_sv();
                        charsetSelecting = charset.Ualpha_svList(args[i].ToString().ToLower());
                        break;
                    }
                    else if (lalpha_sv.IsMatch(args[i].ToString().ToLower()))
                    {
                        Alpha_sv charset = new Alpha_sv();
                        charsetSelecting = charset.Lalpha_svList(args[i].ToString().ToLower());
                        break;
                    }
                    else if (mixalpha_sv.IsMatch(args[i].ToString().ToLower()))
                    {
                        Alpha_sv charset = new Alpha_sv();
                        charsetSelecting = charset.MixAlpha_svList(args[i].ToString().ToLower());
                        break;
                    }
                    else if (wifi.IsMatch(args[i].ToString().ToLower()))
                    {
                        Special charset = new Special();
                        charsetSelecting = charset.ListWifiCharset(args[i].ToString().ToLower());                                              
                        break;
                    }
                    else if (lcyrillic.IsMatch(args[i].ToString().ToLower()))
                    {
                        Cyrillic charset = new Cyrillic();
                        charsetSelecting = charset.ListcyrillicLowerCase(args[i].ToString().ToLower());
                        break;
                    }
                    else if (ucyrillic.IsMatch(args[i].ToString().ToLower()))
                    {
                        Cyrillic charset = new Cyrillic();
                        charsetSelecting = charset.ListCyrillicUpperCase(args[i].ToString().ToLower());
                        break;
                    }
                    else if (mixcyrillic.IsMatch(args[i].ToString().ToLower()))
                    {
                        Cyrillic charset = new Cyrillic();
                        charsetSelecting = charset.ListMixCyrillic(args[i].ToString().ToLower());
                        break;
                    }
                    else if(Wordlist.CUSTOM)
                    {
                        string s = null;
                        if (args.Length == 1)
                        {
                            s = args[0].ToString();
                        }

                        for (int x = 0; x < s.Length; x++)
                        {
                            charsetSelecting.Add(s[x].ToString());
                        }
                    }
                    else if (((i > 1 & i < args.Length & args[i] == "-f") & (!hex.IsMatch(args[i + 1].ToString().ToLower()) & !numeric.IsMatch(args[i + 1].ToString().ToLower()) & !symbols.IsMatch(args[i + 1].ToString().ToLower()) & !usyllable.IsMatch(args[i + 1].ToString().ToLower()) & !lsyllable.IsMatch(args[i + 1].ToString().ToLower()) & !mixsyllable.IsMatch(args[i + 1].ToString().ToLower()) & !ualpha.IsMatch(args[i + 1].ToString().ToLower()) & !lalpha.IsMatch(args[i + 1].ToString().ToLower()) & !mixalpha.IsMatch(args[i + 1].ToString().ToLower()) & !ualpha_sv.IsMatch(args[i + 1].ToString()) & !lalpha_sv.IsMatch(args[i + 1].ToString().ToLower()) & !wifi.IsMatch(args[i + 1].ToString().ToLower()) & !lcyrillic.IsMatch(args[i + 1].ToString().ToLower()) & !ucyrillic.IsMatch(args[i + 1].ToString().ToLower()) & !mixcyrillic.IsMatch(args[i + 1].ToString().ToLower()))) )
                    {
                        string s = args[i + 1].ToString();
                        
                        if (s.Length > 1 & s != null)
                        {
                            for (int x = 0; x < s.Length; x++)
                            {
                                charsetSelecting.Add(s[x].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n {0} \n", e.Message);
                Console.ResetColor();
            }

            return charsetSelecting;
        }

    } //End class
} //End NameSpace
