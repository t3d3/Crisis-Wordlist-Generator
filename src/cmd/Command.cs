////
////  Command.cs
////
////  Author:
////       Teeknofil <teeknofil@gmail.com>
////
////  Copyright (c) 2015 Teeknofil
////
////  This program is free software: you can redistribute it and/or modify
////  it under the terms of the GNU General Public License as published by
////  the Free Software Foundation, either version 3 of the License, or
////  (at your option) any later version.
////
////  This program is distributed in the hope that it will be useful,
////  but WITHOUT ANY WARRANTY; without even the implied warranty of
////  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
////  GNU General Public License for more details.
////
////  You should have received a copy of the GNU General Public License
////  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//// Manuel Librairy http://www.codeproject.com/Articles/19869/Powerful-and-simple-command-line-parsing-in-C#x1-40001.1

using System;
using System.Text.RegularExpressions;
using Plossum.CommandLine;

namespace crisis
{
    [CommandLineManager(ApplicationName = " Crisis Wordlist Generator, by Teeknofil", Version = ": 1.0.8", Copyright = " Thanks WarLocG for the debugging and fix bug \n Trouble : http://www.kali-linux.fr/forum/index.php\n FAQ:  www.crack-wifi.com/forum/index.php", EnabledOptionStyles = OptionStyles.Group | OptionStyles.LongUnix)]

    [CommandLineOptionGroup("combination", Name = "Combination", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("parameter", Name = "Parameter", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("help", Name = "Help", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("options", Name = "Options")]

    public class Command 
    {
        [CommandLineOption(Name = "h", Aliases = "help",
                           Description = "Shows this help text", GroupId = "help")]
        public bool Help
        {
            get { return mHelp; }
            set { mHelp = value; }
        }

        [CommandLineOption(Name = "c", Aliases = "wordlist-help",
                           Description = "Displays the list of wordlist", GroupId = "help")]
        public bool WordlistHelp
        {
            get { return mWordlistHelp; }
            set { mWordlistHelp = value; }
        }

        [CommandLineOption(Name = "w", Aliases = "wordlist",
                           Description = "Character of the wordlist, type wordlist-help for more info", GroupId = "parameter")]

        public bool Dictionnary
        {
            get { return mDictionnary; }
            set { mDictionnary = value; }
        }

        [CommandLineOption(Name = "l", Aliases = "lenght",
                           Description = "Number of character or character group", GroupId = "parameter")]
        public bool Lenght
        {
            get { return mLenght; }
            set { mLenght = value; }
        }
        [CommandLineOption(Name = "r", Aliases = "random",
                           Description = "generate random character", GroupId = "combination")]
        public bool Random
        {
            get { return mRandom; }
            set { mRandom = value; }
        }

        [CommandLineOption(Name = "e", Aliases = "enumeration",
                           Description = "generates a character list without repetition", GroupId = "combination")]
        public bool Enumeration
        {
            get { return mEnumeration; }
            set { mEnumeration = value; }
        }


        [CommandLineOption(Name = "a", Aliases = "crunch",
            Description = "charset list customized to crunch wordlist generator", GroupId = "combination")]

        public bool Crunch
        {
            get { return mCrunch; }
            set { mCrunch = value; }
        }

        [CommandLineOption(Name = "i", Aliases = "interactive",
                           Description = "Interactive command in the terminal with question and answer", GroupId = "options")]
        public bool Interactive
        {
            get { return mInteractive; }
            set { mInteractive = value; }
        }
        [CommandLineOption(Name = "f", Aliases = "file",
                           Description = "Specify the save file in the output-dico folder on the desktop", GroupId = "options")]
        public bool FileName
        {
            get { return mFileName; }
            set { mFileName = value; }
        }
        private bool mHelp;
        private bool mWordlistHelp;


        private bool mEnumeration;
        private bool mCrunch;

        private bool mLenght;
        private bool mFileName;
        private bool mInteractive;
        private bool mRandom;
        private bool mDictionnary;
        

        public Command()
        {

        }

        public int HelpArg(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Help)
            {
                Console.Write(parser.UsageInfo.ToString(78, false) + "Example:");
                Console.WriteLine("\t\tcrisis --wordlist-help");
                Console.WriteLine("\t\t\tcrisis -l 27 -r -w hex-upper");
                Console.WriteLine("\t\t\tcrisis -l 10 -e -w ualpha -f ");
                Console.WriteLine("\t\t\tcrisis -a -w sfr5 > charset.lst ");


                return 0;
            }
            else if (options.WordlistHelp)
            {

                MenuDisplayCharset.MenuSfrNeufBoxPrint();
                MenuDisplayCharset.MenuHexaPrint();
                MenuDisplayCharset.MenuNumericPrint();
                MenuDisplayCharset.MenuSpecialCharacteresPrint();

                MenuDisplayCharset.LatinCharacteUppercasePrint();
                MenuDisplayCharset.LatinCharacterLowercasePrint();
                MenuDisplayCharset.LatinCharacterUppercaseLowercasePrint();
                MenuDisplayCharset.SwddishCharacterUppercasePrint();
                MenuDisplayCharset.SwddishCharacterLowercasePrint();
                MenuDisplayCharset.SwddishCharacterLowercaseUppercasePrint();

                MenuDisplayCharset.SyllableCharacteUppercasePrint();
                MenuDisplayCharset.SyllableCharacterLowercasePrint();
                MenuDisplayCharset.SyllableCharacterUppercaseLowercasePrint();
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }

        public int ParameterArgs(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            Regex sfr = new Regex(@"^sfr.{1}$");

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
            bool b = false;

            for (int i = 0; i < args.Length; i++)
            {
                if (options.Dictionnary)
                {
                    if (sfr.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.SfrNeufBox();
                        Parameter.NumberOfChar = 20;
                        b = true;
                    }
                    else if (hex.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.Hexa();
                        b = true;
                    }
                    else if (numeric.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.Numeric();
                        b = true;
                    }
                    else if (symbols.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.Symbols();
                        b = true;

                    }
                    else if (usyllable.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.Usyllable_fr();
                        b = true;

                    }
                    else if (lsyllable.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.Lsyllable_fr();
                        b = true;

                    }
                    else if (mixsyllable.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.mixsyllable_fr();
                        b = true;

                    }
                    else if (ualpha.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.Ualpha();
                        b = true;

                    }
                    else if (lalpha.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.Lalpha();
                        b = true;

                    }
                    else if (mixalpha.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.MixAlpha();
                        b = true;

                    } ///////////////////////////////
                    else if (ualpha_sv.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        b = true;

                    }
                    else if (lalpha_sv.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.Lalpha_sv();
                        b = true;

                    }
                    else if (mixalpha_sv.IsMatch(args[i]))
                    {
                        Charset.CharsetName += args[i];
                        Charset.MixAlpha_sv();
                        b = true;
                    }

                }
                else if (parser.HasErrors)
                {
                    Console.WriteLine(parser.UsageInfo.ToString(78, true));
                    return -1;
                }

                if (options.Lenght)
                {                    
                    if (args[i] == "-l" | args[i] == "--lenght")
                    {
                        int l;

                        bool c = int.TryParse(args[i + 1], out l);

                        if (l.Equals(null) | c == false)
                        {
                            Console.WriteLine("\nThe value entered with the -l option is incorrect\n");
                            Environment.Exit(0);
                        }
                        else
                        {
                            if (sfr.IsMatch(args[i]))
                            {
                                l = 20;
                            }

                            Parameter.NumberOfChar = l;

                        }
                    }

                }
                else if (parser.HasErrors)
                {
                    Console.WriteLine(parser.UsageInfo.ToString(78, true));
                    return -1;
                }

            }
            if (b == false & options.WordlistHelp == false)
            {
                Console.WriteLine("\nThe name entered with the -w option is incorrect\n");
                Environment.Exit(0);
            }

            return 0;
        }

        public int CombinationArg(string[] args)
        {
            Generate Function = new Generate();
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Random)
            {
                Function.Wordlist();
            }
            else if (options.Crunch)
            {
                Parameter.TypesOfGeneration = 0;
                Function.CharsetCrunch();
            }
            else if (options.Enumeration)
            {
                Parameter.TypesOfGeneration = 1;
                Function.CharsetCrunch();
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }


        public int OptionsArg(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Interactive)
            {
                Parameter run = new Parameter();
                run.MainMenu();
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            if (options.FileName)
            {
                Parameter.SaveFile += 1;
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            return 0;
        }


    }
}

