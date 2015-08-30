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
using Plossum.CommandLine;
using  System.Text.RegularExpressions;
namespace crisis
{


    [CommandLineManager(ApplicationName="Crisis Wordlist Generator by Teeknofil, ver: 1.0.3", EnabledOptionStyles=OptionStyles.Group | OptionStyles.LongUnix)]

    [CommandLineOptionGroup("commands", Name="Commands", Require=OptionGroupRequirement.ExactlyOne)]

    [CommandLineOptionGroup("options", Name="Options")]



    public class Command
    {
        [CommandLineOption(Name="h", Aliases="help",
                           Description="Shows this help text", GroupId="options")]
        public bool Help
        {
            get { return mHelp; }
            set { mHelp = value; }
        }

        [CommandLineOption(Name="i", Aliases="interactive",
                           Description="Interactive command in the terminal with question and answer", GroupId="options")]
        public bool Interactive
        {
            get { return mInteractive; }
            set { mInteractive = value; }
        }
        [CommandLineOption(Name="f", Aliases="file",
                           Description="Specify the save file in the output-dico folder on the desktop", MinOccurs=0,GroupId="options")]
        public bool FileName
        {
            get { return mFileName;}
            set { mFileName = value;}
        }

        [CommandLineOption(Name="w", Aliases="wordlist",
                           Description="Character of the wordlist, type wordlist-help for more info", GroupId="commands")]
        public bool Wordlist
        {
            get { return mWordlist; }
            set { mWordlist = value; }
        }

        [CommandLineOption(Name="wl", Aliases="wordlist-list",
                           Description="Displays the list of wordlist\n", GroupId="options")]
        public bool WordlistHelp
        {
            get { return mWordlistHelp; }
            set { mWordlistHelp = value; }
        }

        [CommandLineOption(Name="l", Aliases="lenght",
                           Description="Number of character or character group", MinOccurs=1,GroupId="commands")]
        public bool Lenght
        {
            get { return mLenght; }
            set { mLenght = value; }
        }

        [CommandLineOption(Name = "r", Aliases = "random",
                           Description = "generate random character", GroupId = "commands")]
        public bool Random
        {
            get { return mRandom;}
            set { mRandom = value;}
        }
        
        [CommandLineOption(Name = "e", Aliases = "enumeration",
                           Description = "generates a character list without repetition", GroupId = "commands")]
        public bool Enumeration
        {
            get { return mEnumeration;}
            set { mEnumeration = value;}
        }
        private bool mEnumeration;
        private bool mWordlistHelp;
        private bool mHelp;
        private bool mLenght;
        private bool mFileName;
        private bool mInteractive;
        private bool mWordlist;
        private bool mRandom;

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
                Console.WriteLine(parser.UsageInfo.ToString(78, false));
                return 0;
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
        
        public int InteractiveArg(string[] args)
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

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }


        public int LenghtArg(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Lenght)
            {
                Combination add = new Combination();
                int l = Convert.ToInt32(args[2]);
                add.NumberOfChar += l;

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

        public int RandomArg(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Random)
            {
                Combination run = new Combination();
                run.CombinationRamdon();
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

        public int FilesArg(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Random)
            {
                Generate run = new Generate();
                run.Setting_UpFile();
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

        public int EnumerationArg(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Enumeration )
            {
                Combination add = null;
               Generate run = new Generate();
               run.CombinationCharset(Charset.CharsetSelecting , add.NumberOfChar, Charset.CharsetSelecting.Count - add.NumberOfChar);

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

        public int WordlistArg(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            Regex hex = new Regex(@"^hex-[.]$");
            Regex numeric = new Regex(@"^numeric[.]$");
            Regex symbols = new Regex(@"^symbols[.]$");

            Regex usyllable = new Regex(@"^usyllable[.]$");
            Regex lsyllable = new Regex(@"^lsyllable[.]$");
            Regex mixsyllable = new Regex(@"^mixsyllable[.]$");

            Regex ualpha = new Regex(@"^ualpha[.]$");
            Regex lalpha = new Regex(@"^lalpha[.]$");
            Regex mixalpha = new Regex(@"^mixalpha[.]$");


            Regex ualpha_sv = new Regex(@"^ualpha[.]-sv$");
            Regex lalpha_sv = new Regex(@"^lalpha[.]-sv$");
            Regex mixalpha_sv = new Regex(@"^mixalpha[.]-sv$");

            if (options.Wordlist)
            { 
                for (int i = 0; i < args.Length; i++)
                {
                    if (hex.IsMatch(args[i]))
                    {
                        Charset.Hexa();
                    } 
                    else if (numeric.IsMatch(args[i]))
                    {
                        Console.Write(args[1]);

                    }
                    else if (symbols.IsMatch(args[i]))
                    {
                        Charset.Symbols();
                    }
                    else if (usyllable.IsMatch(args[i]))
                    {
                        Charset.Usyllable_fr();
                    }
                    else if (lsyllable.IsMatch(args[i]))
                    {
                        Charset.Lsyllable_fr();
                    }
                    else if (mixsyllable.IsMatch(args[i]))
                    {
                        Charset.mixsyllable_fr();
                    }
                    else if (ualpha.IsMatch(args[i]))
                    {
                        Charset.Ualpha();
                    } 
                    else if (lalpha.IsMatch(args[i]))
                    {
                        Charset.Lalpha();
                    } 
                    else if (mixalpha.IsMatch(args[i]))
                    {
                        Charset.MixAlpha();   
                    }
                    else if (ualpha_sv.IsMatch(args[i]))
                    {
                        Charset.Ualpha_sv();
                    }
                    else if (lalpha_sv.IsMatch(args[i])) 
                    {
                        Charset.Lalpha_sv();
                    }
                    else if (mixalpha_sv.IsMatch(args[i])) 
                    {
                        Charset.MixAlpha_sv();
                    }

                }
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

        public int WordlistHelpArg(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.WordlistHelp )
            {

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
    }
}

