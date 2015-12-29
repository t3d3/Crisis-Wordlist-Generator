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
    [CommandLineManager(ApplicationName = "\n\n Crisis Wordlist Generator by Teeknofil,", Version = ": 1.0.9\n\n", Copyright = "SYNOPSIS\n\n crisis <method> -l <len> -f [<charset string>] [options] \n\nDESCRIPTION \n\n  Crisis can create a wordlist based on criteria you specify. The output  from crisis can be sent to the screen, file, or  to  another  program.  The required parameters are: ", EnabledOptionStyles = OptionStyles.Group | OptionStyles.LongUnix)]

    [CommandLineOptionGroup("method", Name = "Method", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("parameter", Name = "Parameter", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("help", Name = "Help", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("options", Name = "Options", Require = OptionGroupRequirement.None)]

    public partial class Command
    {
        /*
       /////// Help
       */

        [CommandLineOption(Name = "h", Aliases = "help",
                           Description = "Shows this help text", GroupId = "help")]
        public bool Help
        {
            get { return mHelp; }
            set { mHelp = value; }
        }

        [CommandLineOption(Name = "w", Aliases = "help-wordlist",
                           Description = "Displays the list of wordlist", GroupId = "help")]
        public bool WordlistHelp
        {
            get { return mWordlistHelp; }
            set { mWordlistHelp = value; }
        }

        private bool mHelp;
        private bool mWordlistHelp;

        /*
        /////// Method
        */

        [CommandLineOption(Name = "1", Aliases = "crunch", Description = "Charset list customized to crunch wordlist generator", GroupId = "method")]
        public bool Crunch
        {
            get { return mCrunch; }
            set { mCrunch = value; }
        }

        [CommandLineOption(Name = "2", Aliases = "enumeration",
                           Description = "Generate a character list without repetition", GroupId = "method")]

        public bool Enumeration
        {
            get { return mEnumeration; }
            set { mEnumeration = value; }
        }
        [CommandLineOption(Name = "3", Aliases = "random",
                           Description = "Generate random character", GroupId = "method")]
        public bool Random
        {
            get { return mRandom; }
            set { mRandom = value; }
        }

        [CommandLineOption(Name = "4", Aliases = "leetspeak", Description = "Convert a list of words in language Leet Speak \n Example : crisis  -4 ..\\crisis\\dico.txt -o ", GroupId = "method")]
        public bool LeetSpeak
        {
            get { return m1337; }
            set { m1337 = value; }
        }

        [CommandLineOption(Name = "5", Aliases = "wifi",
                           Description = "Not available ", GroupId = "method")]
        public bool Wifi
        {
            get { return mWifi; }
            set { mWifi = value; }
        }


        [CommandLineOption(Name = "6", Aliases = "birthdate",
                           Description = "Not available ", GroupId = "method")]
        public bool BirthDate
        {
            get { return mBirthDate; }
            set { mBirthDate = value; }
        }


        [CommandLineOption(Name = "7", Aliases = "incremental", Description = "Not available", GroupId = "method")]
        public bool Incremental
        {
            get { return mIncremental; }
            set { mIncremental = value; }
        }

        [CommandLineOption(Name = "8", Aliases = "permutation",
                           Description = "Not available ", GroupId = "method")]
        public bool Permution
        {
            get { return mPermutation; }
            set { mPermutation = value; }
        }

        private bool mCrunch;
        private bool mEnumeration;
        private bool mIncremental;
        private bool mPermutation;
        private bool m1337;
        private bool mRandom;
        private bool mBirthDate;
        private bool mWifi;

        /*
        /////// Options
        */

        [CommandLineOption(Name = "b", Aliases = "byte",
                           Description = "Specifies the size of the output file, \n only works if -o is used,  i.e.:  60 mib. \n For example  is 500 mib correct 500mb  is NOT correct. \n The three types are based on 1024. \n Example :   crisis -3 -l 10 -b 50 mib -o will generate 1 \n files  valid values for type  are   kib, mib, and gib. \n NOTE  There is  space between the number and type.", GroupId = "options")]
        public bool Byte
        {
            get { return mByte; }
            set { mByte = value; }
        }


        [CommandLineOption(Name = "c", Aliases = "line",
                           Description = "Specifies the number of lines to  write  to  output \n file,  only works if -o is used.", GroupId = "options")]
        public bool Line
        {
            get { return mLine; }
            set { mLine = value; }
        }

        [CommandLineOption(Name = "o", Aliases = "output", Description = "Specify the save file in the crisis folder on the desktop", GroupId = "options")]
        public bool FileName
        {
            get { return mFileName; }
            set { mFileName = value; }
        }

        [CommandLineOption(Name = "i", Aliases = "invert", Description = "Inverts  the  output  so  instead  of  aaa,aab,aac,aad, \n etc you get aaa,baa,caa,daa,aba,bba, etc", GroupId = "options")]

        public bool Invert
        {
            get { return mInvert; }
            set { mInvert = value; }
        }


        [CommandLineOption(Name = "s", Aliases = "startblock", Description = "  Specifies a starting string, eg: qwerty", GroupId = "options")]

        public bool Startblock
        {
            get { return mStartblock; }
            set { mStartblock = value; }
        }

        [CommandLineOption(Name = "e", Aliases = "end", Description = "Specifies a ending string, eg: god77xD", GroupId = "options")]

        public bool End
        {
            get { return mEnd; }
            set { mEnd = value; }
        }
        [CommandLineOption(Name = "u", Aliases = "disables", Description = "The -u option disables the print size . \n This should be the last option.", GroupId = "options")]

        public bool Disables
        {
            get { return mDisables; }
            set { mDisables = value; }
        }

        [CommandLineOption(Name = "z", Aliases = "zip", Description = "Not available", GroupId = "options")]

        public bool Zip
        {
            get { return mZip; }
            set { mZip = value; }
        }

        private bool mLine;
        private bool mDisables;
        private bool mEnd;
        private bool mFileName;
        private bool mInvert;
        private bool mByte;
        private bool mStartblock;
        private bool mZip;

        /*
        /////// Parameter
        */
        [CommandLineOption(Name = "f", Aliases = "charset-name", Description = "Specifies a character set from crisis, \n type --help-wordlist for more info", GroupId = "parameter")]

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

        private bool mLenght;
        private bool mDictionnary;

        public Command()
        {

        }
        


    }
}
