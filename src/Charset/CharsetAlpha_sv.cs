using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public static partial class Charset
    {
        public static List<string> Lalpha_sv()
        {

            if (charsetName == "sv-lalpha")
            {
                //lalpha-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-lalpha-space")
            {
                //lalpha-space-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(space).ToList();
                booleanType = false;
            }
            else if (charsetName == "sv-lalpha-numeric")
            {
                //lalpha-numeric-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-lalpha-numeric-space")
            {
                //lalpha-numeric-space-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-lalpha-numeric-symbol14")
            {

                //lalpha-numeric-symbol14-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-lalpha-numeric-symbol14-space")
            {

                // lalpha-numeric-symbol14-space-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-lalpha-numeric-all")
            {
                // lalpha-numeric-all-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-lalpha-numeric-all-space")
            {
                //lalpha-numeric-all-space-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();                    //charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("indexEnuCharset"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/"); charsetSelecting.Add(" ");
                booleanType = false;

            }
            else
            {
                booleanType = true;
            }

            return charsetSelecting;
        }

        public static List<string> Ualpha_sv()
        {

            if (charsetName == "sv-ualpha")
            {
                //ualpha-sv
                charsetSelecting = ualpha.Concat(ualpha_sv).ToList();
                booleanType = false;
            }
            else if (charsetName == "sv-ualpha-space")
            {
                //ualpha-space-sv
                charsetSelecting = ualpha.Concat(ualpha_sv).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-ualpha-numeric")
            {
                //ualpha-numeric-sv
                charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-ualpha-numeric-space")
            {
                //ualpha-numeric-space-sv
                charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-ualpha-numeric-symbol14")
            {
                //ualpha-numeric-symbol14-sv
                charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-ualpha-numeric-symbol14-space")
            {
                //ualpha-numeric-symbol14-space-sv
                charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-ualpha-numeric-all")
            {
                //ualpha-numeric-all-sv
                charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-ualpha-numeric-all-space")
            {
                //ualpha-numeric-all-space-sv
                charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                booleanType = false;

            }
            else
            {
                booleanType = true;
            }


            return charsetSelecting;
        }



        public static List<string> MixAlpha_sv()
        {

            if (charsetName == "sv-mixalpha")
            {
                //mixalpha-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).ToList();
                booleanType = false;
            }
            else if (charsetName == "sv-mixalpha-space")
            {
                //mixalpha-space-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-mixalpha-numeric")
            {
                // mixalpha-numeric-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).ToList();
                booleanType = false;
            }
            else if (charsetName == "sv-mixalpha-numeric-space")
            {
                //mixalpha-numeric-space_sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-mixalpha-numeric-symbol14")
            {
                //mixalpha-numeric-symbol14-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-mixalpha-numeric-symbol14-space")
            {
                //mixalpha-numeric-symbol14-space-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-mixalpha-numeric-all")
            {
                //mixalpha-numeric-all-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;

            }
            else if (charsetName == "sv-mixalpha-numeric-all-space")
            {
                //mixalpha-numeric-all-space-sv
                charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                booleanType = false;

            }
            else
            {
                booleanType = true;
            }


            return charsetSelecting;

        }
    }
}
