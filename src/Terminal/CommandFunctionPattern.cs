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
using System.Text.RegularExpressions;
using crisis.CommandLine;

namespace crisis
{
    public partial class Command
    {

        public int FunctionPattern(string[] args)
        {            
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

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

            if (options.Dictionnary)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (hex.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.Hexa();
                    }
                    else if (numeric.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.Numeric();
                    }
                    else if (symbols.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.Symbols();
                    }
                    else if (usyllable.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.Usyllable_fr();
                    }
                    else if (lsyllable.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.Lsyllable_fr();
                    }
                    else if (mixsyllable.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.mixsyllable_fr();
                    }
                    else if (ualpha.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.Ualpha();
                    }
                    else if (lalpha.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.Lalpha();
                    }
                    else if (mixalpha.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.MixAlpha();

                    }
                    else if (ualpha_sv.IsMatch(args[i].ToString()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.Ualpha_sv();
                    }
                    else if (lalpha_sv.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.Lalpha_sv();
                    }
                    else if (mixalpha_sv.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.MixAlpha_sv();
                    }
                    else if (wifi.IsMatch(args[i].ToString().ToLower()))
                    {
                        Charset.CharsetName += args[i].ToString().ToLower();
                        Charset.WifiCharset();
                    }
                }


            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            return 0;
        }
    
    }//End class
}//End namespace
