using System;
using System.Text.RegularExpressions;
using Plossum.CommandLine;

namespace crisis
{
    public partial class Command
    {

        public int FunctionPattern(string[] args)
        {
            Tools obj1 = new Tools();
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

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

            for (int i = 0; i < args.Length; i++)
            {
                if (options.Dictionnary)
                {
                    if (hex.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.Hexa();
                    }
                    else if (numeric.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.Numeric();
                    }
                    else if (symbols.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.Symbols();
                    }
                    else if (usyllable.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.Usyllable_fr();
                    }
                    else if (lsyllable.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.Lsyllable_fr();
                    }
                    else if (mixsyllable.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.mixsyllable_fr();
                    }
                    else if (ualpha.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.Ualpha();
                    }
                    else if (lalpha.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.Lalpha();
                    }
                    else if (mixalpha.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.MixAlpha();

                    }
                    else if (ualpha_sv.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.Ualpha_sv();
                    }
                    else if (lalpha_sv.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.Lalpha_sv();
                    }
                    else if (mixalpha_sv.IsMatch(args[i].ToLower()))
                    {
                        Charset.CharsetName += args[i].ToLower();
                        Charset.MixAlpha_sv();
                    }

                    if (options.Startblock)
                    {
                        if (args[i].ToLower() == "-s" | args[i].ToLower() == "--startblock")
                        {
                            string s = args[i + 1];

                            if (s.Length > Charset.CharsetSelecting.Count)
                            {
                                Console.WriteLine("\nThe string entered with the -s option is too big\n");
                                Console.WriteLine("example : crisis -2 -l 10 -f lalpha -s qwerty");
                                Environment.Exit(0);
                            }
                            else
                            {
                                obj1.StartblockPattern(s);
                            }
                        }
                    }
                    else if (parser.HasErrors)
                    {
                        Console.WriteLine(parser.UsageInfo.ToString(78, true));
                    }

                    if (options.End)
                    {
                        if (args[i].ToLower() == "-e" | args[i].ToLower() == "--end")
                        {
                            string e = args[i + 1];

                            if (e.Length > Charset.CharsetSelecting.Count)
                            {
                                Console.WriteLine("\nThe string entered with the -s option is too big\n");
                                Console.WriteLine("example : crisis -2 -l 10 -f lalpha -e qwerty");
                                Environment.Exit(0);
                            }
                            else
                            {
                                obj1.EndPattern(e);
                            }
                        }
                    }
                    else if (parser.HasErrors)
                    {
                        Console.WriteLine(parser.UsageInfo.ToString(78, true));
                        return -1;
                    }

                }
                else if (parser.HasErrors)
                {
                    Console.WriteLine(parser.UsageInfo.ToString(78, true));
                    return -1;
                }

                // No errors present and all arguments correct
                // Do work according to arguments
                
            } // End for
            return 0;
        }
    
    }//End class
}//End namespace
