using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Crisis_Wordlist_Generator
{
    public class Charset
    {
        private List<string> charsetSelecting = new List<string>();

        public List<string> CharsetSelecting
        {
            get { return charsetSelecting; }
            set { charsetSelecting = value; }
        }
        char info;
        char category;
        internal Regex noLetters = new Regex("^[a-zA-Z]$");

        public Charset()
        {

        }


        public List <string> Hexa()
        {
            bool b = true;

            Console.Write("\n Enter the number corresponding to your choice : ");
            while (b)
            {
                if (category == '1')
                {
                    //hex_lower
                    charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f");
                    b = false;

                }
                else if (category == '2')
                {
                    //hex_upper 
                    charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F");
                    b = false;                    
                }
                else
                {
                    try
                    {
                        category = char.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Write(" Enter the number corresponding to your choice : ");


                    }
                    finally
                    {
                        if (noLetters.IsMatch(info.ToString()))
                        {
                            Console.Write(" Enter the number corresponding to your choice : ");

                        }

                    }

                }  
            }
            
            

            return charsetSelecting;
            
        }

        public List<string> Numeric()
        {
            bool b = true;
            Console.Write("\n Enter the number corresponding to your choice : ");
            while (b)
            {
                if (category == '1')
                {
                    //numeric
                    charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9");
                    b = false;
                }
                else if (category == '2')
                {
                    //numeric_space
                    charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add(" ");
                    b = false;
                }
                else
                {
                    try
                    {                        
                        category = char.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Write(" Enter the number corresponding to your choice : ");

                    }
                    finally
                    {
                        if (noLetters.IsMatch(info.ToString()))
                        {
                            Console.Write(" Enter the number corresponding to your choice : ");

                        }

                    }
                }                
            }            

            return charsetSelecting;
        }

        public List<string> Symbols()
        {
            Console.Write("\n Enter the number corresponding to your choice : ");
            bool b = true;

            while (b)
            {
                if (category == '1')
                {
                    //symbols14
                    charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("=");
                    b = false;

                }
                else if (category == '2')
                {
                    //symbols14_space
                    charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add(" ");
                    b = false;
                }
                else if (category == '3')
                {
                    //symbols_all
                    charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\\"); charsetSelecting.Add("\""); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/");
                    b = false;
                }
                else if (category == '4')
                {
                    //symbols_all_space
                    charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(":"); charsetSelecting.Add("\\"); charsetSelecting.Add("\""); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/"); charsetSelecting.Add(" ");
                    b = false;
                }
                else
                {
                    try
                    {
                        category = char.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Write(" Enter the number corresponding to your choice : ");

                    }
                    finally
                    {
                        if (noLetters.IsMatch(info.ToString()))
                        {
                            Console.Write(" Enter the number corresponding to your choice : ");

                        }

                    }
                }                
            }

            return charsetSelecting;
        }

        public List<string> Ualpha()
        {
            Console.Write("\n Enter the number corresponding to your choice : ");
            
            bool b = true;
            while (b)
            {
                if (category == '1')
                {
                    //ualpha
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z");
                    b = false;
                }
                else if (category == '2')
                {
                    //ualpha_space
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add(" ");
                    b = false;
                }
                else if (category == '3')
                {
                    //ualpha_numeric
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9");
                    b = false;
                }
                else if (category == '4')
                {
                    //ualpha_numeric_space
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add(" ");
                    b = false;
                }
                else if (category == '5')
                {
                    // ualpha_numeric_symbol14
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("=");
                    b = false;
                }
                else if (category == '6')
                {
                    //ualpha_numeric_symbol14_space
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add(" ");
                    b = false;
                }
                else if (category == '7')
                {
                    //ualpha_numeric_all
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(":"); charsetSelecting.Add("\\"); charsetSelecting.Add("\""); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/");
                    b = false;
                }
                else if (category == '8')
                {
                    //ualpha_numeric_all_space
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/"); charsetSelecting.Add(" ");
                    b = false;
                }
                else
                {
                    try
                    {
                        category = char.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Write(" Enter the number corresponding to your choice : ");

                    }
                    finally
                    {
                        if (noLetters.IsMatch(info.ToString()))
                        {
                            Console.Write(" Enter the number corresponding to your choice : ");

                        }

                    }
                }
            }
            
            return charsetSelecting;
        }

        public List<string> Lalpha()
        {
            Console.Write("\n Enter the number corresponding to your choice : ");

            bool b = true;
            while (b)
            {
                if (category == '1')
                {
                    //lalpha
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z");
                    b = false;
                }
                else if (category == '2')
                {
                    // lalpha_space 
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add(" ");
                    b = false;
                }
                else if (category == '3')
                {
                    // lalpha_numeric
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9");
                    b = false;
                }
                else if (category == '4')
                {
                    // lalpha_numeric_space
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '5')
                {
                    //lalpha_numeric_symbol14
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("=");
                    b = false;

                }
                else if (category == '6')
                {
                    // lalpha_numeric_symbol14_space
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("y"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '7')
                {
                    //lalpha_numeric_all
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("y"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("\'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/");
                    b = false;

                }
                else if (category == '8')
                {
                    //lalpha_numeric_all_space
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("y"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("\'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/"); charsetSelecting.Add(" ");
                    b = false;
                }
                else
                {
                    try
                    {
                        category = char.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Write(" Enter the number corresponding to your choice : ");

                    }
                    finally
                    {
                        if (noLetters.IsMatch(info.ToString()))
                        {
                            Console.Write(" Enter the number corresponding to your choice : ");

                        }

                    }
                }
            }
            return charsetSelecting;
        }

        public List<string> MixAlpha()
        {
            Console.Write("\n Enter the number corresponding to your choice : ");

            bool b = true;

            while (b)
            {
                if (category == '1')
                {
                    //mixalpha
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z");
                    b = false;
                }
                else if (category == '2')
                {
                    //mixalpha_space
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '3')
                {
                    //mixalpha_numeric
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9");
                    b = false;

                }
                else if (category == '4')
                {
                    //mixalpha_numeric_space
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '5')
                {
                    //mixalpha_numeric_symbol14
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("=");
                    b = false;

                }
                else if (category == '6')
                {
                    //mixalpha_numeric_symbol14_space
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '7')
                {
                    // mixalpha_numeric_all
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("\'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/");
                    b = false;

                }
                else if (category == '8')
                {
                    // mixalpha_numeric_all_space
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("\'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/"); charsetSelecting.Add(" ");
                    b = false;

                }
                else
                {
                    try
                    {
                        category = char.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Write(" Enter the number corresponding to your choice : ");

                    }
                    finally
                    {
                        if (noLetters.IsMatch(info.ToString()))
                        {
                            Console.Write(" Enter the number corresponding to your choice : ");

                        }

                    }
                }

            }


            return charsetSelecting;
        }

        public List<string> Ualpha_sv()
        {
            Console.Write("\n Enter the number corresponding to your choice : ");
            bool b = true;
            while (b)
            {

                if (category == '1')
                {
                    //ualpha_sv
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö");
                    b = false;
                }
                else if (category == '2')
                {
                    //ualpha_space_sv
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '3')
                {
                    //ualpha_numeric_sv
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9");
                    b = false;

                }
                else if (category == '4')
                {
                    //ualpha_numeric_space_sv
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '5')
                {
                    //ualpha_numeric_symbol14_sv
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("=");
                    b = false;

                }
                else if (category == '6')
                {
                    //ualpha_numeric_symbol14_space_sv
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '7')
                {
                    //ualpha_numeric_all_sv
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("\'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/");
                    b = false;

                }
                else if (category == '8')
                {
                    //ualpha_numeric_all_space_sv
                    charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("\'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/"); charsetSelecting.Add(" ");
                    b = false;

                }
                else
                {
                    try
                    {
                        category = char.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Write(" Enter the number corresponding to your choice : ");

                    }
                    finally
                    {
                        if (noLetters.IsMatch(info.ToString()))
                        {
                            Console.Write(" Enter the number corresponding to your choice : ");

                        }

                    }
                }
            }
            return charsetSelecting;
        }

        public List<string> Lalpha_sv()
        {
            Console.Write("\n Enter the number corresponding to your choice : ");

            bool b = true;
            while (b)
            {
                if (category == '1')
                {
                    //lalpha_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö");
                    b = false;

                }
                else if (category == '2')
                {
                    //lalpha_space_sv 
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add(" ");
                    b = false;
                }
                else if (category == '3')
                {
                    //lalpha_numeric_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9");
                    b = false;

                }
                else if (category == '4')
                {
                    //lalpha_numeric_space_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '5')
                {

                    //lalpha_numeric_symbol14
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("=");
                    b = false;

                }
                else if (category == '6')
                {

                    // lalpha_numeric_symbol14_space_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '7')
                {
                    // lalpha_numeric_all_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/");
                    b = false;

                }
                else if (category == '8')
                {
                    //lalpha_numeric_all_space_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/"); charsetSelecting.Add(" ");
                    b = false;

                }
                else
                {
                    try
                    {
                        category = char.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Write(" Enter the number corresponding to your choice : ");

                    }
                    finally
                    {
                        if (noLetters.IsMatch(info.ToString()))
                        {
                            Console.Write(" Enter the number corresponding to your choice : ");

                        }

                    }
                }
            }



            return charsetSelecting;
        }

        public List<string> MixAlpha_sv()
        {
            Console.Write("\n Enter the number corresponding to your choice : ");

            bool b = true;
            while (b)
            {
                if (category == '1')
                {
                    //mixalpha_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö");
                    b = false;
                }
                else if (category == '2')
                {
                    //mixalpha_space_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '3')
                {
                    // mixalpha_numeric_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9");
                    b = false;
                }
                else if (category == '4')
                {
                    //mixalpha_numeric_space_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '5')
                {
                    //mixalpha_numeric_symbol14_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("=");
                    b = false;

                }
                else if (category == '6')
                {
                    //mixalpha_numeric_symbol14_space_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add(" ");
                    b = false;

                }
                else if (category == '7')
                {
                    //mixalpha_numeric_all_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("\'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/");
                    b = false;

                }
                else if (category == '8')
                {
                    //mixalpha_numeric_all_space_sv
                    charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("A"); charsetSelecting.Add("B"); charsetSelecting.Add("C"); charsetSelecting.Add("D"); charsetSelecting.Add("E"); charsetSelecting.Add("F"); charsetSelecting.Add("G"); charsetSelecting.Add("H"); charsetSelecting.Add("I"); charsetSelecting.Add("J"); charsetSelecting.Add("K"); charsetSelecting.Add("L"); charsetSelecting.Add("M"); charsetSelecting.Add("N"); charsetSelecting.Add("O"); charsetSelecting.Add("P"); charsetSelecting.Add("Q"); charsetSelecting.Add("R"); charsetSelecting.Add("S"); charsetSelecting.Add("T"); charsetSelecting.Add("U"); charsetSelecting.Add("V"); charsetSelecting.Add("W"); charsetSelecting.Add("X"); charsetSelecting.Add("Y"); charsetSelecting.Add("Z"); charsetSelecting.Add("Å"); charsetSelecting.Add("Ä"); charsetSelecting.Add("Ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("\'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/"); charsetSelecting.Add(" ");
                    b = false;

                }
                else
                {
                    try
                    {
                        category = char.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Write(" Enter the number corresponding to your choice : ");

                    }
                    finally
                    {
                        if (noLetters.IsMatch(info.ToString()))
                        {
                            Console.Write(" Enter the number corresponding to your choice : ");

                        }

                    }
                }
            }


            return charsetSelecting;

        }       
        
      
        public void Menu()
        {

            Console.WriteLine(" Crisis Wordlist Generator  by Teeknofil, ver: 1.0.1");
            Console.WriteLine(" Trouble: http://www.kali-linux.fr/forum/index.php");
            
            Console.WriteLine("\n N°\tDESCRIPTION \n");
            

            Console.WriteLine(" 1)\t HEXA");
            Console.WriteLine(" 2)\t NUMBER");
            Console.WriteLine(" 3)\t SPECIAL CHARACTER");
            Console.WriteLine(" 4)\t LATIN   CHARACTER UPPERCASE");
            Console.WriteLine(" 5)\t LATIN   CHARACTER LOWERCASE");
            Console.WriteLine(" 6)\t LATIN   CHARACTER UPPERCASE & LOWERCASE");
            Console.WriteLine(" 7)\t SWEDISH   CHARACTER UPPERCASE");
            Console.WriteLine(" 8)\t SWEDISH   CHARACTER LOWERCASE");
            Console.WriteLine(" 9)\t SWEDISH   CHARACTER UPPERCASE & LOWERCASE");
        }


        public void Display()
        {
            // Mettre les connsole.WriteLine dans les Méthode Correspondante.

            Menu();
            bool b = true;
            
            while (b)
            {
                Console.WriteLine("\n");

                if (info == '1')
                {

                    Console.WriteLine(" 1)\t 0123456789abcdef");
                    Console.WriteLine(" 2)\t 0123456789ABCDEF\n");
                    Hexa();
                    b = false;
                }
                else if (info == '2')
                {
                    //numeric    
                    Console.WriteLine(" 1)\t 0123456789");
                    //numeric-space
                    Console.WriteLine(" 2)\t 0123456789 [space] \n");

                    Numeric();
                    b = false;
                }
                else if (info == '3')
                {

                    //symbols14              
                    Console.WriteLine(" 1)\t !@#$%^&*()-_+=");
                    //symbols14-space
                    Console.WriteLine(" 2)\t !@#$%^&*()-_+= [space]\n");

                    //symbols-all                
                    Console.WriteLine(" 3)\t !@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/");
                    //symbols-all-space

                    Console.WriteLine(" 4)\t !@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]\n");

                    Symbols(); 
                    b = false;

                }
                else if (info == '4')
                {

                    //ualpha     
                    Console.WriteLine(" 1)\t ABCDEFGHIJKLMNOPQRSTUVWXYZ\n");
                    //ualpha-space
                    Console.WriteLine(" 2)\t ABCDEFGHIJKLMNOPQRSTUVWXYZ [space]\n");

                    //ualpha-numeric
                    Console.WriteLine(" 3)\t ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789\n");
                    //ualpha-numeric-space
                    Console.WriteLine(" 4)\t ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789\n\t [space]\n");

                    //ualpha-numeric-symbol14
                    Console.WriteLine(" 5)\t ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789\n\t !@#$%^&*()-_+=\n");
                    //ualpha-numeric-symbol14-space
                    Console.WriteLine(" 6)\t ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789\n\t !@#$%^&*()-_+= [space]\n");

                    //ualpha-numeric-all
                    Console.WriteLine(" 7)\t ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789\n\t !@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
                    //ualpha-numeric-all-space
                    Console.WriteLine(" 8)\t ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789\n\t !@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]");

                    Ualpha();
                    b = false;


                }
                else if (info == '5')
                {
                    //lalpha
                    Console.WriteLine(" 1)\t abcdefghijklmnopqrstuvwxyz\n");
                    //lalpha-space
                    Console.WriteLine(" 2)\t abcdefghijklmnopqrstuvwxyz [space]\n");
                    //lalpha-numeric
                    Console.WriteLine(" 3)\t abcdefghijklmnopqrstuvwxyz0123456789\n");
                    //lalpha-numeric-space
                    Console.WriteLine(" 4)\t abcdefghijklmnopqrstuvwxyz0123456789\n\t [space]\n");
                    //lalpha-numeric-symbol14
                    Console.WriteLine(" 5)\t abcdefghijklmnopqrstuvwxyz0123456789\n\t !@#$%^&*()-_+=\n");
                    //lalpha-numeric-symbol14-space
                    Console.WriteLine(" 6)\t abcdefghijklmnopqrstuvwxyz0123456789\n\t !@#$%^&*()-_+= [space]\n");
                    //lalpha-numeric-all
                    Console.WriteLine(" 7)\t abcdefghijklmnopqrstuvwxyz0123456789\n\t !@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ \n\t");
                    //lalpha-numeric-all-space 
                    Console.WriteLine(" 8)\t abcdefghijklmnopqrstuvwxyz0123456789\n\t !@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]\n");
                    
                    Lalpha();
                    b = false;


                }
                else if (info == '6')
                {

                    //mixalpha
                    Console.WriteLine(" 1)\t abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ\n");
                    //mixalpha-space
                    Console.WriteLine(" 2)\t abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ \n\t [space]\n");

                    //mixalpha-numeric
                    Console.WriteLine(" 3)\t abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ \n\t 0123456789\n");
                    //mixalpha-numeric-space
                    Console.WriteLine(" 4)\t abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ \n\t 0123456789 [space]\n");

                    //mixalpha-numeric-symbol14
                    Console.WriteLine(" 5)\t abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ \n\t 0123456789!@#$%^&*()-_+=\n");
                    //mixalpha-numeric-symbol14-space
                    Console.WriteLine(" 6)\t abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ \n\t 0123456789!@#$%^&*()-_+= [space]\n");

                    //mixalpha-numeric-all
                    Console.WriteLine(" 7)\t abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ \n\t 0123456789!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
                    //mixalpha-numeric-all-space
                    Console.WriteLine(" 8)\t abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ \n\t 0123456789!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]\n");

                    MixAlpha();

                    b = false;

                }
                else if (info == '7')
                {
                    //////////////////////////////////////////////////////////////////////////////////////////
                    //                 SWEDISH CHAR  SUPPORT                                                // 
                    /////////////////////////////////////////////////////////////////////////////////////////

                    /////////////////////////
                    //       Uppercase     //
                    /////////////////////////

                    //ualpha-sv
                    Console.WriteLine(" 1)\t ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n");
                    //ualpha-space-sv
                    Console.WriteLine(" 2)\t ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ [space]\n");

                    //ualpha-numeric-sv
                    Console.WriteLine(" 3)\t ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789\n");
                    //ualpha-numeric-space-sv
                    Console.WriteLine(" 4)\t ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789\n\t [space]\n");

                    //ualpha-numeric-symbol14-sv
                    Console.WriteLine(" 5)\t ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789\n\t !@#$%^&*()-_+=\n");
                    //ualpha-numeric-symbol14-space-sv
                    Console.WriteLine(" 6)\t ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789\n\t !@#$%^&*()-_+= [space]\n");

                    //ualpha-numeric-all-sv
                    Console.WriteLine(" 7)\t ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789\n\t !@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
                    //ualpha-numeric-all-space-sv
                    Console.WriteLine(" 8)\t ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789\n\t !@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]\n");

                    Ualpha_sv();

                    b = false;

                }
                else if (info == '8')
                {
                    /////////////////////////
                    // Lowercase           //
                    /////////////////////////

                    //lalpha-sv
                    Console.WriteLine(" 1)\t abcdefghijklmnopqrstuvwxyzåäö\n");
                    //lalpha-space-sv
                    Console.WriteLine(" 2)\t abcdefghijklmnopqrstuvwxyzåäö\n\t [space]\n");

                    //lalpha-numeric-sv
                    Console.WriteLine(" 3)\t abcdefghijklmnopqrstuvwxyzåäö0\n\t 123456789");
                    //lalpha-numeric-space-sv
                    Console.WriteLine(" 4)\t abcdefghijklmnopqrstuvwxyzåäö0\n\t 123456789 [space]\n");

                    //lalpha-numeric-symbol14-sv 
                    Console.WriteLine(" 5)\t abcdefghijklmnopqrstuvwxyzåäö0\n\t 123456789!@#$%^&*()-_+=");
                    //lalpha-numeric-symbol14-space-sv
                    Console.WriteLine(" 6)\t abcdefghijklmnopqrstuvwxyzåäö0\n\t 123456789!@#$%^&*()-_+= [space]\n");

                    //lalpha-numeric-all-sv
                    Console.WriteLine(" 7)\t abcdefghijklmnopqrstuvwxyzåäö0\n\t 123456789!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
                    //lalpha-numeric-all-space-sv
                    Console.WriteLine(" 8)\t abcdefghijklmnopqrstuvwxyzåäö0\n\t 123456789!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]\n");

                    Lalpha_sv();

                    b = false;


                }
                else if (info == '9')
                {
                    /////////////////////////
                    // Mixcase             // 
                    ////////////////////////

                    //mixalpha-sv
                    Console.WriteLine(" 1)\t abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n");
                    //mixalpha-space-sv
                    Console.WriteLine(" 2)\t abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ [space]\n");

                    //mixalpha-numeric-sv
                    Console.WriteLine(" 3)\t abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t 0123456789\n");
                    //mixalpha-numeric-space-sv
                    Console.WriteLine(" 4)\t abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t 0123456789 [space]\n");

                    //mixalpha-numeric-symbol14-sv
                    Console.WriteLine(" 5)\t abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t 0123456789!@#$%^&*()-_+= \n");
                    //mixalpha-numeric-symbol14-space-sv
                    Console.WriteLine(" 6)\t abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t 0123456789!@#$%^&*()-_+= [space]\n");

                    //mixalpha-numeric-all-sv
                    Console.WriteLine(" 7)\t abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t 0123456789!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
                    //mixalpha-numeric-all-space-sv
                    Console.WriteLine(" 8)\t abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t 0123456789!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]\n");

                    MixAlpha_sv();
                    b = false;

                }
                else
                {
                    try
                    {
                        
                        Console.Write(" With what category you want to work : ");
                        info = char.Parse(Console.ReadLine());
                       
                    }
                    catch (FormatException)
                    {
                        Console.Write("\n Enter the number corresponding to your choice !");
                       
                        
                    }
                    finally     
                    {
                        if (noLetters.IsMatch(info.ToString()))
	                    {
                            Console.Write("\n Enter the number corresponding to your choice ! ");
                            
	                    }
                        
                    }
                }
            }
        

        }


    } // End Class
} // End name space

