using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Numerics;
using crisis.CommandLine;

namespace crisis
{

    [CommandLineManager(ApplicationName = "\n\n Crisis Wordlist Generator by Teeknofil,", Version = ": 1.1.3 Beta\n\n", Copyright = "SYNOPSIS\n\n crisis [method] -l [len] -f [charset string] [options] \n\nDESCRIPTION \n\n  Crisis can create a wordlist based on criteria you specify. The output  from crisis can be sent to the screen, file, or  to  another  program.  The required parameters are: ", EnabledOptionStyles = OptionStyles.Group | OptionStyles.LongUnix)]

    [CommandLineOptionGroup("method", Name = "Method", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("parameter", Name = "Parameter", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("help", Name = "Help", Require = OptionGroupRequirement.None)]

    [CommandLineOptionGroup("options", Name = "Options", Require = OptionGroupRequirement.None)]

    public class Property
    {  

        private static int typesOfGeneration;

        public static int TypesOfGeneration
        {
            get { return Property.typesOfGeneration; }
            set { Property.typesOfGeneration = value; }
        }

        private static int typesOfTransforming;

        public static int TypesOfTransforming
        {
            get { return Property.typesOfTransforming; }
            set { Property.typesOfTransforming = value; }
        }

        private static byte typeOfProcess;

        public static byte TypeOfProcess
        {
            get { return Property.typeOfProcess; }
            set { Property.typeOfProcess = value; }
        }

        private static BigInteger numberLine;

        public static BigInteger NumberLine
        {
            get { return Property.numberLine; }
            set { Property.numberLine = value; }
        }      

        

        private static byte iExtension;

        public static byte IExtension
        {
            get { return Property.iExtension; }
            set { Property.iExtension = value; }
        }

        private static byte numberOfChar;
        public static byte NumberOfChar
        {
            get { return Property.numberOfChar; }
            set { Property.numberOfChar = value; }
        }

        private static string lhost;

        public static string Lhost
        {
            get { return Property.lhost; }
            set { Property.lhost = value; }
        }

        private static int lport;

        public static int Lport
        {
            get { return Property.lport; }
            set { Property.lport = value; }
        }

        /*
        /////// Help
        */

        private bool mHelp;
        private bool mWordlistHelp;

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

        

        /*
        /////// Method
        */

        private bool mCrunch;
        private bool mCombination;
        private bool mVariation;
        private bool mPermutation;        
        private bool mRandom;        
        private bool mWifi;


        [CommandLineOption(Name = "1", Aliases = "crunch", Description = "Charset list customized to crunch wordlist generator.\n Example : crisis -1 -l 10 -f ualpha -u", GroupId = "method")]
        public bool Crunch
        {
            get { return mCrunch; }
            set { mCrunch = value; }
        }
          

        [CommandLineOption(Name = "2", Aliases = "combination",
                           Description = "Generate a character list combination.\n Example : crisis -2 -l 5 -f MyWord -u", GroupId = "method")]

        public bool Combination
        {
            get { return mCombination; }
            set { mCombination = value; }
        }
        [CommandLineOption(Name = "3", Aliases = "random",
                           Description = "Generate random character. \n Example : crisis -3 -l 15 -f mixalpha -u", GroupId = "method")]
        public bool Random
        {
            get { return mRandom; }
            set { mRandom = value; }
        }

        [CommandLineOption(Name = "4", Aliases = "variation", Description = " Generate a character list variation.\n Example : crisis -4 -l 10 -f lalpha  ", GroupId = "method")]
        public bool Variation
        {
            get { return mVariation; }
            set { mVariation = value; }
        }

        [CommandLineOption(Name = "5", Aliases = "permutation", Description = " Generate a character list permutation.\n Example : crisis -5 -l 10 -f lalpha  ", GroupId = "method")]
        public bool Permutation
        {
            get { return mPermutation; }
            set { mPermutation = value; }
        }

        [CommandLineOption(Name = "6", Aliases = "wifi",
                           Description = "Generer des caractere specialement pour un routeur ou une box \n Exemple :\n crisis -6 -f livebox-sagem  \n crisis -6 -f sfr -u | aircrack-ng -e SFR_???? -w- out-01.cap", GroupId = "method")]
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
                           Description = "Specifies the size of the output file,  only works if -o is used,  i.e.:  60 mib. \n For example  is 500 mib correct 500mb  is NOT correct. \n The three types are based on 1024. \n Example : crisis -2 -l 10 -f JohnDoe0123456789 -b 50 mib -o will generate 1 \n files  valid values for type  are   kib, mib, and gib. \n NOTE  There is  space between the number and type.", GroupId = "options")]
        public bool Byte
        {
            get { return mByte; }
            set { mByte = value; }
        }


        [CommandLineOption(Name = "c", Aliases = "line",
                           Description = "Specifies the number of lines to  write  to  output \n file,  only works if -o is used.\n Example : crisis -4 -l 10 -f mixalpha -r -o -c 10000 -z", GroupId = "options")]
        public bool Line
        {
            get { return mLine; }
            set { mLine = value; }
        }

        [CommandLineOption(Name = "e", Aliases = "endblock", Description = "Specifies a ending string, eg: god77xD. \n  Example : crisis -2 -l 16 -f  sv-mixalpha  -e \"Do a barrel roll\"", GroupId = "options")]

        public bool EndBlock
        {
            get { return mEndBlock; }
            set { mEndBlock = value; }
        }

        [CommandLineOption(Name = "o", Aliases = "output", Description = "Specify the save file in the crisis folder on the desktop", GroupId = "options")]

        public bool SaveFile
        {
            get { return saveFile; }
            set { saveFile = value; }
        }
       

        [CommandLineOption(Name = "i", Aliases = "invert", Description = "Inverts  the  output  so  instead  of  aaa,aab,aac,aad, \n etc you get aaa,baa,caa,daa,aba,bba, etc", GroupId = "options")]

        public bool Invert
        {
            get { return mInvert; }
            set { mInvert = value; }
        }

        [CommandLineOption(Name = "r", Aliases = "repeat", Description = " Specify if you want a repetition of characters.  \n  Example : crisis -5 -l 10 -f  sv-mixalpha  -r", GroupId = "options")]

        public bool Repeat
        {
            get { return repeat; }
            set { repeat = value; }
        }

        [CommandLineOption(Name = "s", Aliases = "startblock", Description = "  Specifies a starting string, eg: qwerty. \n  Example : crisis -2 -l 15 -f  sv-mixalpha  -s \"Hello World\"", GroupId = "options")]
        public bool Startblock
        {
            get { return mStartblock; }
            set { mStartblock = value; }
        }


        [CommandLineOption(Name = "u", Aliases = "disables", Description = "The -u option disables the print size . \n This should be the last option.", GroupId = "options")]

        public bool Disables
        {
            get { return mDisables; }
            set { mDisables = value; }
        }

        [CommandLineOption(Name = "z", Aliases = "zip", Description = "Compresses  the output from the -o option. \n  Example : crisis -2 -l 10 -f ualpha -r  -o  -b 1024 mib -z", GroupId = "options")]

        
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
            get { return lenght; }
            set { lenght = value; }
        }    

    }
}
