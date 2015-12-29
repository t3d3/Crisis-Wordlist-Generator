using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plossum.CommandLine;


namespace crisis
{
    public partial class Command
    {

        public int HelpPrint(string[] args)
        {
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Help)
            {
                Console.Write(parser.UsageInfo.ToString(80, false));               

            }
            else if (options.WordlistHelp)
            {

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

        
    } // End class

}// End namespace
