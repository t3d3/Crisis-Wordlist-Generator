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

namespace Crisis.Combinatorics
{
    class UserPasswordProfiler
    {
        internal static string CustomCharsetWord()
        {
            string str = null;
            
            try
            {
                str = Console.ReadLine();
                
                if (String.IsNullOrEmpty(str))
                    return null;
               
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
            }

            return str;
        }

        public static List<string> InitialPersonne(List<string> charsetSelecting, string name, string surname)
        {
            try
            {
                if (name.Length > 2 & surname.Length > 2 & !String.IsNullOrEmpty(name) & !String.IsNullOrEmpty(surname))
                {
                    // Initial
                    string str1 = name[0].ToString() + surname[0].ToString();
                    charsetSelecting.Add(str1.ToUpper());
                    charsetSelecting.Add(str1.ToLower());
                    charsetSelecting.Add(name[0].ToString().ToUpper() + surname[0].ToString().ToLower());
                    charsetSelecting.Add(name[0].ToString().ToLower() + surname[0].ToString().ToUpper());

                    string str2 = surname[0].ToString() + name[0].ToString();
                    charsetSelecting.Add(str2.ToUpper());
                    charsetSelecting.Add(str2.ToLower());
                    charsetSelecting.Add(surname[0].ToString().ToUpper() + name[0].ToString().ToLower());
                    charsetSelecting.Add(surname[0].ToString().ToLower() + name[0].ToString().ToUpper());

                    // Initial first letter uppercase in name and surname
                    charsetSelecting.Add(name[0].ToString().ToUpper() + name.Substring(1));
                    charsetSelecting.Add(surname[0].ToString().ToUpper() + name.Substring(1));

                    // UPPERCASE
                    charsetSelecting.Add(name.ToUpper());
                    charsetSelecting.Add(surname.ToUpper());

                    // LOWERCASE
                    charsetSelecting.Add(name.ToLower());
                    charsetSelecting.Add(surname.ToLower());

                    // Asd name and surname
                    charsetSelecting.Add(name);
                    charsetSelecting.Add(surname);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", (object)ex.Message);
                Console.ResetColor();
            }

            return charsetSelecting;
        }

        public static List<string> BirthdatePerson(List<string> charsetSelecting)
        {
            string str = Console.ReadLine();
            if (str.Length == 8 & str != string.Empty)
            {
                charsetSelecting.Add(str);
                charsetSelecting.Add(str.Substring(0, 2));
                charsetSelecting.Add(str.Substring(2, 2));
                charsetSelecting.Add(str.Substring(4, 4));
                charsetSelecting.Add(str.Substring(6, 2));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Length of the birth date false\n");
                Console.ResetColor();
            }

            return charsetSelecting;
        }

        
        internal static List<string> CustomCharsetSpecial(List<string> charsetSelecting)
        {
            Charset.Default symbols = new Charset.Default();
            return charsetSelecting.Concat<string>((IEnumerable<string>) symbols.Symbols_all).ToList<string>();
        }

        internal static List<string> CustomCharsetNumber(List<string> charsetSelecting)
        {
            Charset.Default number = new Charset.Default();
            return charsetSelecting.Concat<string>((IEnumerable<string>)number.Numeric).ToList<string>();
        }
        

        internal static List<string> CustumCHarsetUpperCase(List<string> charsetSelecting)
        {
            try
            {
                for (int index = 0; index < charsetSelecting.Count; ++index)
                {
                    charsetSelecting.Add(charsetSelecting[index].ToUpper().ToString());
                    Tools.Utility.RemoveDuplicate(charsetSelecting);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", (object)ex.Message);
                Console.ResetColor();
            }
            return charsetSelecting;
        }

        internal static List<string> CustumCHarsetLowerCase(List<string> charsetSelecting)
        {
            try
            {
                for (int index = 0; index < charsetSelecting.Count; ++index)
                {
                    charsetSelecting.Add(charsetSelecting[index].ToLower().ToString());
                    Tools.Utility.RemoveDuplicate(charsetSelecting);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", (object)ex.Message);
                Console.ResetColor();
            }

            return charsetSelecting;
        }

       
    }
}
