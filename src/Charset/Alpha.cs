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

using System.Collections.Generic;
using System.Linq;

namespace Crisis.Charset
{
    public class Alpha : Default
    {
        public List<string> Lalpha_List(string charsetName)
        {
            if (charsetName == "lalpha")
            {
                //lalpha
                charsetSelecting = Lalpha.ToList();
                BooleanType = false;
            }
            else if (charsetName == "lalpha-space")
            {
                // lalpha_space
                charsetSelecting = Lalpha.Concat(Space).ToList();
                BooleanType = false;
            }
            else if (charsetName == "lalpha-numeric")
            {
                // lalpha-numeric
                charsetSelecting = Lalpha.Concat(Numeric).ToList();
                BooleanType = false;
            }
            else if (charsetName == "lalpha-numeric-space")
            {
                // lalpha-numeric-space
                charsetSelecting = Lalpha.Concat(Numeric).Concat(Space).ToList();
                BooleanType = false;
            }
            else if (charsetName == "lalpha-numeric-symbol14")
            {
                //lalpha-numeric-symbol14
                charsetSelecting = Lalpha.Concat(Numeric).Concat(Symbols14).ToList();
                BooleanType = false;
            }
            else if (charsetName == "lalpha-numeric-symbol14-space")
            {
                // lalpha-numeric-symbol14-space
                charsetSelecting = Lalpha.Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();
                BooleanType = false;
            }
            else if (charsetName == "lalpha-numeric-all")
            {
                //lalpha-numeric-all
                charsetSelecting = Lalpha.Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();
                BooleanType = false;
            }
            else if (charsetName == "lalpha-numeric-all-space")
            {
                //lalpha-numeric-all-space
                charsetSelecting = Lalpha.Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();
                BooleanType = false;
            }            

            return charsetSelecting;
        }



        public List<string> Ualpha_List(string charsetName)
        {
            if (charsetName == "ualpha")
            {
                //ualpha
                charsetSelecting = Ualpha;
                BooleanType = false;
            }
            else if (charsetName == "ualpha-space")
            {
                //ualpha-space
                charsetSelecting = Ualpha.Concat(Space).ToList();
                BooleanType = false;
            }
            else if (charsetName == "ualpha-numeric")
            {
                //ualpha-numeric
                charsetSelecting = Ualpha.Concat(Numeric).ToList();
                BooleanType = false;
            }
            else if (charsetName == "ualpha-numeric-space")
            {
                //ualpha_numeric_space
                charsetSelecting = Ualpha.Concat(Numeric).Concat(Space).ToList();
                BooleanType = false;
            }
            else if (charsetName == "ualpha-numeric-symbol14")
            {
                // ualpha_numeric_symbol14
                charsetSelecting = Ualpha.Concat(Numeric).Concat(Symbols14).ToList();
                BooleanType = false;
            }
            else if (charsetName == "ualpha-numeric-symbol14-space")
            {
                //ualpha_numeric-symbol14-space
                charsetSelecting = Ualpha.Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();
                BooleanType = false;
            }
            else if (charsetName == "ualpha-numeric-all")
            {
                //ualpha-numeric-all
                charsetSelecting = Ualpha.Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();
                BooleanType = false;
            }
            else if (charsetName == "ualpha-numeric-all-space")
            {
                //ualpha-numeric-all-space
                charsetSelecting = Ualpha.Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();
                BooleanType = false;
            }
            else
            {
                BooleanType = true;
            }

            return charsetSelecting;
        }


        public List<string> MixAlphaList(string charsetName)
        {


            if (charsetName == "mixalpha")
            {
                //mixalpha
                charsetSelecting = Lalpha.Concat(Ualpha).ToList();
                BooleanType = false;
            }
            else if (charsetName == "mixalpha-space")
            {
                //mixalpha-space
                charsetSelecting = Lalpha.Concat(Ualpha).Concat(Space).ToList();
                BooleanType = false;

            }
            else if (charsetName == "mixalpha-numeric")
            {
                //mixalpha-numeric
                charsetSelecting = Lalpha.Concat(Ualpha).Concat(Numeric).ToList();
                BooleanType = false;

            }
            else if (charsetName == "mixalpha-numeric-space")
            {
                //mixalpha-numeric-space
                charsetSelecting = Lalpha.Concat(Ualpha).Concat(Numeric).Concat(Space).ToList();
                BooleanType = false;

            }
            else if (charsetName == "mixalpha-numeric-symbol14")
            {
                //mixalpha-numeric-symbol14
                charsetSelecting = Lalpha.Concat(Ualpha).Concat(Numeric).Concat(Symbols14).ToList();
                BooleanType = false;

            }
            else if (charsetName == "mixalpha-numeric-symbol14-space")
            {
                //mixalpha-numeric-symbol14-space
                charsetSelecting = Lalpha.Concat(Ualpha).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();
                BooleanType = false;

            }
            else if (charsetName == "mixalpha-numeric-all")
            {
                // mixalpha-numeric-all
                charsetSelecting = Lalpha.Concat(Ualpha).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();
                BooleanType = false;

            }
            else if (charsetName == "mixalpha-numeric-all-space")
            {
                // mixalpha-numeric-all-space
                charsetSelecting = Lalpha.Concat(Ualpha).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();
                BooleanType = false;

            }
            else
            {
                BooleanType = true;
            }


            return charsetSelecting;
        }
    }
}
