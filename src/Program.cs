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
using Crisis.Tools;
using Crisis.Graphic;
using System.Resources;

namespace Crisis
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.InputEncoding = System.Text.Encoding.UTF8;            
            Console.SetWindowSize(120, 25);

            Utility os = new Utility();
            os.Root();

            if (args.Length == 0)
            {
                Interface category = new Interface();
                ResourceManager lang = category.Lang_Text();
                new Run(lang);                
            }
            else
            {
                new Run(args);
            }
        }
    }
}
