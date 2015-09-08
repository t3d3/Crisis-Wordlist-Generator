//
//  Command.cs
//
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
// Manuel Librairy http://www.codeproject.com/Articles/19869/Powerful-and-simple-command-line-parsing-in-C#x1-40001.1

using System;
using System.Text.RegularExpressions;
using Plossum.CommandLine;

namespace crisis 
{
    [CommandLineManager(ApplicationName=" Crisis Wordlist Generator, by Teeknofil", Version= ": 1.0.4", Copyright=" Thanks WarLocG for the debugging et fix bug \n Trouble : http://www.kali-linux.fr/forum/index.php",EnabledOptionStyles=OptionStyles.Group | OptionStyles.LongUnix)]

    [CommandLineOptionGroup("combination", Name="Combination", Require=OptionGroupRequirement.None)]

    [CommandLineOptionGroup("parameter", Name="Parameter", Require=OptionGroupRequirement.None)]

    [CommandLineOptionGroup("help", Name="Help", Require=OptionGroupRequirement.None)]

    [CommandLineOptionGroup("options", Name="Options")]

    public class Command : Generate
    {
        [CommandLineOption(Name="h", Aliases="help", 
                           Description="Shows this help text", GroupId="help" )]
        public bool Help
        {
            get { return mHelp; }
            set { mHelp = value; }
        }

        [CommandLineOption(Name="c", Aliases="charset", 
                           Description="Displays the list of wordlist", GroupId="help")]
        public bool WordlistHelp
        {
            get { return mWordlistHelp; }
            set { mWordlistHelp = value; }
        }

        [CommandLineOption(Name = "w", Aliases = "wordlist", 
                           Description = "Character of the wordlist, type wordlist-help for more info", GroupId = "parameter")]

        public bool Dictionnary
        {
            get { return mDictionnary;}
            set { mDictionnary = value;}
        }

        [CommandLineOption(Name="l", Aliases="lenght",
                           Description="Number of character or character group", GroupId="parameter")]
        public bool Lenght
        {
            get { return mLenght; }
            set { mLenght = value; }
        }
        [CommandLineOption(Name = "r", Aliases = "random",
                           Description = "generate random character", GroupId = "combination")]
        public bool Random
        {
            get { return mRandom;}
            set { mRandom = value;}
        }

        [CommandLineOption(Name = "e", Aliases = "enumeration",
                           Description = "generates a character list without repetition", GroupId = "combination")]
        public bool Enumeration
        {
            get { return mEnumeration;}
            set { mEnumeration = value;}
        }

        [CommandLineOption(Name="i", Aliases="interactive",
                           Description="Interactive command in the terminal with question and answer", GroupId="options")]
        public bool Interactive
        {
            get { return mInteractive; }
            set { mInteractive = value; }
        }
        [CommandLineOption(Name="f", Aliases="file",
                           Description="Specify the save file in the output-dico folder on the desktop", GroupId="options")]
        public bool FileName
        {
            get { return mFileName;}
            set { mFileName = value;}
        }
        private bool mHelp;
        private bool mWordlistHelp;

        private bool mEnumeration;
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
                Console.Write(parser.UsageInfo.ToString(78, false)+"Example:");
                Console.WriteLine("\t\tcrisis --charset");
                Console.WriteLine("\t\t\tcrisis -l 15 -e -w hex-lower -f");
                Console.WriteLine("\t\t\tcrisis -l 17 -r -w ualpha");               
                return 0;
            }
             else if (options.WordlistHelp )
            {
                Menu printf = new Menu();
                printf.MenuHexaPrint();
                printf.MenuNumericPrint();
                printf.MenuSpecialCharacteresPrint();

                printf.LatinCharacteUppercasePrint();
                printf.LatinCharacterLowercasePrint();
                printf.LatinCharacterUppercaseLowercasePrint();
                printf.SwddishCharacterUppercasePrint();
                printf.SwddishCharacterLowercasePrint();
                printf.SwddishCharacterLowercaseUppercasePrint();

                printf.SyllableCharacteUppercasePrint();
                printf.SyllableCharacterLowercasePrint();
                printf.SyllableCharacterUppercaseLowercasePrint();
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

                    if (hex.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.Hexa();
                    } else if (numeric.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.Numeric();
                    } else if (symbols.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.Symbols();
                    } else if (usyllable.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.Usyllable_fr();
                    } else if (lsyllable.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.Lsyllable_fr();
                    } else if (mixsyllable.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.mixsyllable_fr();
                    } else if (ualpha.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.Ualpha();
                    } else if (lalpha.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.Lalpha();
                    } else if (mixalpha.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.MixAlpha();   
                    } ///////////////////////////////
                    else if (ualpha_sv.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.Ualpha_sv();
                    } 
                    else if (lalpha_sv.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.Lalpha_sv();
                    } 
                    else if (mixalpha_sv.IsMatch(args [i]))
                    {
                        Charset.CharsetName += args [i];
                        Charset.MixAlpha_sv();
                    } 
//                    else if ( i == args.Length && hex == false )
//                    {
//                        Console.WriteLine("\n\n");
//                        Environment.Exit(0);
//                    }
                
                }
                else if (parser.HasErrors)
                {
                    Console.WriteLine(parser.UsageInfo.ToString(78, true));
                    return -1;
                } 

                if (options.Lenght)
                {
                    if (args [i] == "-l" | args [i] == "--lenght")
                    {
                        int l;

                        bool b = int.TryParse(args [i + 1], out l);

                        if (l.Equals(null) | b == false)
                        {
                            Console.WriteLine("\nThe value entered with the -l option is incorrect\n");
                            Environment.Exit(0);
                        } 
                        else
                        {
                            NumberOfChar += l;
                        }
                    }

                } 
                else if (parser.HasErrors)
                {
                    Console.WriteLine(parser.UsageInfo.ToString(78, true));
                    return -1;
                }

            }
            return 0;
        }

        public int CombinationArg(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Random)
            {
                Wordlist();
            }
            else if (options.Enumeration )
            {                
                TypesOfGeneration = '2';
                CharsetCrunch ();
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
                Menu run = new Menu();
                run.MainMenu();
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            if (options.FileName)
            {
                Console.WriteLine("test_1");
                SaveFile += '1';
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

