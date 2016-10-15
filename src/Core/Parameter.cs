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
using Crisis.Charset;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Resources;
using Crisis.Tools;
using Crisis.Graphic;

namespace Crisis
{
    public class Parameter : CLI
    {
        protected  BigInteger numberLine;
        
        private static byte iExtension;
        public static byte IExtension
        {
            get { return Parameter.iExtension; }
            set { Parameter.iExtension = value; }
        }

        

        private static string lhost;
        public static string Lhost
        {
            get { return Parameter.lhost; }
            set { Parameter.lhost = value; }
        }

        private static int lport;
        public static int Lport
        {
            get { return Parameter.lport; }
            set { Parameter.lport = value; }
        }

        protected ResourceManager lang;

        protected byte numberOfChar;
        public byte NumberOfChar
        {
            get { return numberOfChar; }
            set { numberOfChar = value; }
        }
      
        protected List<string> charsetSelecting = new List<string>();

        public List<string> SelectPattern(string[] args)
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
                    return charset.ListHexa(args[i].ToString().ToLower());
                }
                else if (numeric.IsMatch(args[i].ToString().ToLower()))
                {
                    Special charset = new Special();
                    return charset.ListNumeric(args[i].ToString().ToLower());

                }
                else if (symbols.IsMatch(args[i].ToString().ToLower()))
                {
                    Special charset = new Special();
                    return charset.ListSymbols(args[i].ToString().ToLower());

                }
                else if (usyllable.IsMatch(args[i].ToString().ToLower()))
                {

                    Syllable charset = new Syllable();
                    return charset.ListSyllableUpperCase_fr(args[i].ToString().ToLower());
                }
                else if (lsyllable.IsMatch(args[i].ToString().ToLower()))
                {
                    Syllable charset = new Syllable();
                    return charset.ListSyllableLowerCase_fr(args[i].ToString().ToLower());

                }
                else if (mixsyllable.IsMatch(args[i].ToString().ToLower()))
                {
                    Syllable charset = new Syllable();
                    return charset.ListMixsyllable_fr(args[i].ToString().ToLower());
                }
                else if (ualpha.IsMatch(args[i].ToString().ToLower()))
                {
                    Alpha charset = new Alpha();
                    return charset.Ualpha_List(args[i].ToString().ToLower());

                }
                else if (lalpha.IsMatch(args[i].ToString().ToLower()))
                {
                    Alpha charset = new Alpha();
                    return charset.Lalpha_List(args[i].ToString().ToLower());

                }
                else if (mixalpha.IsMatch(args[i].ToString().ToLower()))
                {
                    Alpha charset = new Alpha();
                    return charset.MixAlphaList(args[i].ToString().ToLower());
                }
                else if (ualpha_sv.IsMatch(args[i].ToString()))
                {
                    Alpha_sv charset = new Alpha_sv();
                    return charset.Ualpha_svList(args[i].ToString().ToLower());
                }
                else if (lalpha_sv.IsMatch(args[i].ToString().ToLower()))
                {
                    Alpha_sv charset = new Alpha_sv();
                    return charset.Lalpha_svList(args[i].ToString().ToLower());
                }
                else if (mixalpha_sv.IsMatch(args[i].ToString().ToLower()))
                {
                    Alpha_sv charset = new Alpha_sv();
                    return charset.MixAlpha_svList(args[i].ToString().ToLower());

                }
                else if (wifi.IsMatch(args[i].ToString().ToLower()))
                {
                    Special charset = new Special();
                    return charset.ListWifiCharset(args[i].ToString().ToLower());
                }
                else if (lcyrillic.IsMatch(args[i].ToString().ToLower()))
                {
                    Cyrillic charset = new Cyrillic();
                    return charset.ListcyrillicLowerCase(args[i].ToString().ToLower());

                }
                else if (ucyrillic.IsMatch(args[i].ToString().ToLower()))
                {
                    Cyrillic charset = new Cyrillic();
                    return charset.ListCyrillicUpperCase(args[i].ToString().ToLower());
                }
                else if (mixcyrillic.IsMatch(args[i].ToString().ToLower()))
                {
                    Cyrillic charset = new Cyrillic();
                    return charset.ListMixCyrillic(args[i].ToString().ToLower());
                }
                else if (i > 1 & i < args.Length & args[i] == "-f")
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
                else if (Wordlist.CUSTOM)
                {
                    string s = args[i].ToString();
                    if (s.Length > 1 & s != null)
                    {
                        List<string> tmp = new List<string>();

                        for (int x = 1; x < s.Length; x++)
                        {                            
                            tmp.Add(s[x].ToString());                            
                        }

                        return charsetSelecting = tmp.ToList();
                    }
                }
            }
            return charsetSelecting;
        }

    } //End class
} //End NameSpace
