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
using Crisis.Graphic.Menu;
using Crisis.CommandLine;
using System.IO;

namespace Crisis.Tools
{
    [CommandLineManager(ApplicationName = "\n\n Crisis Wordlist Generator by Teeknofil,", Version = ": 1.1.4 \n\n", Copyright = "SYNOPSIS\n\n crisis <method> -l <len> -f <charset string> [options] \n\nDESCRIPTION \n\n  Crisis can create a wordlist based on criteria you specify. The output  from crisis can be sent to the screen, file, or  to  another  program.  The required parameters are: ", EnabledOptionStyles = OptionStyles.Group | OptionStyles.LongUnix)]

    [CommandLineOptionGroup("method", Name = "Method", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("parameter", Name = "Parameter", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("help", Name = "Help", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("options", Name = "Options", Require = OptionGroupRequirement.None)]

    public class CLI
    {

        private bool booleanneTmp;

        /*
        /////// Help
        */

        private bool mHelp;
        private bool mWordlistHelp;

        [CommandLineOption(Name = "h", Aliases = "help",
                           Description = "Shows this help text\n", GroupId = "help")]
        public bool Help
        {
            get { return mHelp; }
            set { mHelp = value; }
        }

        [CommandLineOption(Name = "w", Aliases = "help-wordlist",
                           Description = "Displays the list of wordlist\n", GroupId = "help")]
        public bool WordlistHelp
        {
            get { return mWordlistHelp; }
            set { mWordlistHelp = value; }
        }



        /*
        /////// Method
        */

        private bool mCrunch;
        private bool mCombination;
        private bool mVariation;
        private bool mPermutation;
        private bool mRandom;
        private bool mWifi;


        [CommandLineOption(Name = "1", Aliases = "crunch", Description = "Charset list customized to crunch wordlist generator.\n\nExample : crisis -1 -l 10 -f ualpha -u\n\n", GroupId = "method")]
        public bool Crunch
        {
            get { return mCrunch; }
            set { mCrunch = value; }
        }


        [CommandLineOption(Name = "2", Aliases = "increment",
                           Description = "Generate a character list in increment.\n\nExample : crisis -2 -l 5 -f MyWord -u\n\n", GroupId = "method")]

        public bool Combination
        {
            get { return mCombination; }
            set { mCombination = value; }
        }
        [CommandLineOption(Name = "3", Aliases = "random",
                           Description = "Generate random character.\n\nExample : crisis -3 -l 15 -f mixalpha -u\n\n", GroupId = "method")]
        public bool Random
        {
            get { return mRandom; }
            set { mRandom = value; }
        }

        [CommandLineOption(Name = "4", Aliases = "variation", Description = " Generate a character list variation.\n\nExample : crisis -4 -l 10 -f lalpha\n\n", GroupId = "method")]
        public bool Variation
        {
            get { return mVariation; }
            set { mVariation = value; }
        }

        [CommandLineOption(Name = "5", Aliases = "permutation", Description = " Generate a character list permutation.\n\nExample : crisis -5 -l 10 -f lalpha\n\n", GroupId = "method")]
        public bool Permutation
        {
            get { return mPermutation; }
            set { mPermutation = value; }
        }

        [CommandLineOption(Name = "6", Aliases = "wifi",
                           Description = "Generer des caractere specialement pour un routeur ou une box.\n\nExemple : crisis -6 -f livebox-sagem\n\nExemple : crisis -6 -f sfr -u | aircrack-ng -e SFR_???? -w- out-01.cap \n\n", GroupId = "method")]
        public bool Wifi
        {
            get { return mWifi; }
            set { mWifi = value; }
        }



        /*
        /////// Options
        */

        private bool mByte;
        private bool mEndBlock;
        private bool mLine;
        private bool mDisables;
        private bool mInvert;
        protected bool saveFile;
        protected bool repeat;
        private bool mStartblock;
        protected bool zip;


        [CommandLineOption(Name = "b", Aliases = "byte",
                           Description = "Specifies the size of the output file, only works if -o is used,  i.e.:  60 mib. \n For example  is 500 mib correct 500mb  is NOT correct. \n The three types are based on 1024.\n\nExample :\n crisis -2 -l 10 -f JohnDoe0123456789 -b 50 mib -o /tmp/wordlist \n\n Will generate 1  files  valid values for type  are   kib, mib, and gib. \n\n NOTE  There is  space between the number and type.\n\n", GroupId = "options")]
        public bool Byte
        {
            get { return mByte; }
            set { mByte = value; }
        }


        [CommandLineOption(Name = "c", Aliases = "line",
                           Description = "Specifies the number of lines to  write  to  output \n file,  only works if -o is used.\n\n Example :\n crisis -4 -l 10 -f mixalpha -r -o /tmp/wordlist -c 100 \n\n", GroupId = "options")]
        public bool Line
        {
            get { return mLine; }
            set { mLine = value; }
        }

        [CommandLineOption(Name = "e", Aliases = "endblock", Description = "Specifies a ending string, eg: god77xD.\n\nExample : \ncrisis \n\n", GroupId = "options")]

        public bool EndBlock
        {
            get { return mEndBlock; }
            set { mEndBlock = value; }
        }

        [CommandLineOption(Name = "o", Aliases = "output", Description = "Specify the save file in an folder \n\nExample :\ncrisis -2 -l 16 -f  alpha-numeric -o /root", GroupId = "options")]

        public bool SaveFile
        {
            get { return saveFile; }
            set { saveFile = value; }
        }


        [CommandLineOption(Name = "i", Aliases = "invert", Description = "Inverts  the  output  so  instead  of  aaa,aab,aac,aad, \n etc you get aaa,baa,caa,daa,aba,bba, etc\n\n", GroupId = "options")]

        public bool Invert
        {
            get { return mInvert; }
            set { mInvert = value; }
        }

        [CommandLineOption(Name = "r", Aliases = "repeat", Description = " Specify if you want a repetition of characters.\n\nExample : crisis -5 -l 10 -f  sv-mixalpha  -r\n\n", GroupId = "options")]

        public bool Repeat
        {
            get { return repeat; }
            set { repeat = value; }
        }

        [CommandLineOption(Name = "s", Aliases = "startblock", Description = "  Specifies a starting string, eg: qwerty.\n\nExample :\n crisis -2 -l 15 -f  sv-mixalpha  -s \"Hello World\"\n\n", GroupId = "options")]
        public bool Startblock
        {
            get { return mStartblock; }
            set { mStartblock = value; }
        }


        [CommandLineOption(Name = "u", Aliases = "disables", Description = "The -u option disables the print size . \n This should be the last option.\n\n", GroupId = "options")]

        public bool Disables
        {
            get { return mDisables; }
            set { mDisables = value; }
        }

        [CommandLineOption(Name = "z", Aliases = "zip", Description = "Compresses  the output from the -o option.\n\nExample : \ncrisis -2 -l 10 -f ualpha -r  -o /root/tmp/wordlist  -b 1024 mib -z\n\n", GroupId = "options")]


        public bool Zip
        {
            get { return zip; }
            set { zip = value; }
        }


        /*
        /////// Parameter
        */

        private bool lenght;
        private bool mDictionnary;

        [CommandLineOption(Name = "f", Aliases = "charset-name", Description = "Specifies a character set from crisis, \n type --help-wordlist for more info\n\n", GroupId = "parameter")]

        public bool Dictionnary
        {
            get { return mDictionnary; }
            set { mDictionnary = value; }
        }

        [CommandLineOption(Name = "l", Aliases = "lenght",
                           Description = "Number of character or character group", GroupId = "parameter")]


        public bool Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public CLI()
        {
        }

        public CLI(bool _bool)
        {
            booleanneTmp = _bool;
        }

        public int HelpPrint(string[] args)
        {
            CLI options = new CLI();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Help)
            {
                Console.Write(parser.UsageInfo.ToString(80, false));

            }
            else if (options.WordlistHelp)
            {
                Pattern.SfrPrint();
                Pattern.LiveboxPrint();
                Pattern.MenuHexaPrint();
                Pattern.MenuNumericPrint();
                Pattern.MenuSpecialCharacteresPrint();

                Pattern.LatinCharacteUppercasePrint();
                Pattern.LatinCharacterLowercasePrint();
                Pattern.LatinCharacterUppercaseLowercasePrint();

                Pattern.CyrillicCharacterLowercasePrint();
                Pattern.CyrillicCharacterUppercasePrint();
                Pattern.CyrillicCharacterUppercaseLowercasePrint();

                Pattern.SwddishCharacterUppercasePrint();
                Pattern.SwddishCharacterLowercasePrint();
                Pattern.SwddishCharacterLowercaseUppercasePrint();

                Pattern.SyllableCharacteUppercasePrint();
                Pattern.SyllableCharacterLowercasePrint();
                Pattern.SyllableCharacterUppercaseLowercasePrint();

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

        public int SelectPattern(string[] args)
        {
            CLI options = new CLI();

            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Dictionnary)
            {
                Parameter.SelectPattern(args);
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));                
            }
            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }

        


         public int FunctionLenght(string[] args)
         {
             CLI options = new CLI();
             CommandLineParser parser = new CommandLineParser(options);
             parser.Parse();

             if (options.Lenght)
             {
                 for (int i = 0; i < args.Length; i++)
                 {
                     if (args[i].ToLower() == "-l" | args[i].ToLower() == "--lenght")
                     {
                         byte l;

                         bool b = byte.TryParse(args[i + 1], out l);

                         if (b == false)
                         {
                             Console.WriteLine("\nThe value entered with the -l option is incorrect\n");
                             Environment.Exit(0);
                         }
                         else
                         {
                             Parameter.NumberOfChar = l;
                         }
                     } // End For               
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

        public int FunctionByte(string[] args)
        {
            CLI options = new CLI();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Byte)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToLower() == "-b" | args[i].ToLower() == "--byte")
                    {
                        int iByte = 0;

                        bool booleanByte = int.TryParse(args[i + 1], out iByte);

                        if (booleanByte == false)
                        {
                            Console.WriteLine("\nThe value entered with the -b option is incorrect\n");
                            Environment.Exit(0);
                        }
                        else
                        {
                            if (args[i + 2].ToLower() == "kib")
                            {
                                iByte *= 1024;
                            }
                            else if (args[i + 2].ToLower() == "mib")
                            {
                                iByte *= 1048576;

                            }
                            else if (args[i + 2].ToLower() == "gib")
                            {
                                iByte *= 1073741824;
                            }

                            //Statistical.DefaultSizeFileInOctet = iByte;
                            Statistical obj = new Statistical();
                            Parameter.NumberLine = obj.CalculSizeFile(iByte,Parameter.NumberOfChar,Parameter.TypesAtGenerate,Parameter.NumberOfAllCombination);
                        }
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

        public int FunctionSaveFiles(string[] args)
        {
            CLI options = new CLI();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.SaveFile)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToLower() == "-o")
                    {
                        string pathBackupFile = args[i + 1];

                        if (pathBackupFile[0].ToString() == @"/" || pathBackupFile[1].ToString() == ":")
                        {
                            Parameter.PathBackUpFiles = pathBackupFile;
                        }

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

        
        public int FunctionLine(string[] args)
        {
            CLI options = new CLI();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Line)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToLower() == "-c" | args[i].ToLower() == "--line")
                    {
                        int c;

                        bool booleanLine = int.TryParse(args[i + 1], out c);

                        if (booleanLine == false)
                        {
                            Console.WriteLine("\nThe value entered with the -c option is incorrect\n");
                            Environment.Exit(0);
                        }
                        else
                        {
                           Parameter.NumberLine = c;
                        }
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

        public int StartblockPattern(string[] args)
        {
            Utility obj2 = new Utility();
            CLI options = new CLI();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Startblock)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToString().ToLower() == "-s" | args[i].ToString().ToLower() == "--startblock")
                    {
                        string s = args[i + 1].ToString();

                        if (s.Length > Parameter.CharsetSelecting.Count)
                        {
                            obj2.DoubleCapacityList(Parameter.CharsetSelecting, Parameter.NumberOfChar);
                        }
                        else
                        {
                            obj2.StartblockPattern(s, Parameter.CharsetSelecting);
                        }
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


        public int EndPattern(string[] args)
        {
            Utility tools = new Utility();
            CLI options = new CLI();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.EndBlock)
            {
                string s = null;
                for (int i = 0; i < args.Length; i++)
                {
                    
                    if (args[i].ToString().ToLower() == "-e" | args[i].ToString().ToLower() == "--end")
                    {
                        s = args[i + 1];
                    }                    
                }

                tools.EndPattern(s, Parameter.NumberOfChar, Parameter.CharsetSelecting);
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
        
    } // End class
}

