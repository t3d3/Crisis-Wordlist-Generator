using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public static partial class DisplayCharset
    {
        public static void SyllableCharacterLowercasePrint()
        {
            Console.WriteLine("\n #### Syllable Lowercase\n");
            //lsyllable
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //lsyllable-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" lsyllable-space\n");
            Console.ResetColor();
            //lalpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //lsyllable-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t0123456789\n");
            //lsyllable-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //usyllable-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\t0123456789t@#$%^&*()-_+=\n");
            //lsyllable-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //lsyllable-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lsyllable-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:\n\t\t\t\t\t;\"'<>,.?/\n");
        }

        public static void SyllableCharacteUppercasePrint()
        {
            Console.WriteLine("\n #### Syllable Uppercase \n");
            //usyllable
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" usyllable-space\n");
            Console.ResetColor();
            //ualpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t0123456789\n");
            //ulsyllable-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\t0123456789t@#$%^&*()-_+=\n");
            //usyllable-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...");
            //usyllable-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" usyllable-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:\n\t\t\t\t\t;\"'<>,.?/\n");
        }

        public static void SyllableCharacterUppercaseLowercasePrint()
        {
            Console.WriteLine("\n #### Syllable Mixcase \n");
            //mixsyllable
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n");
            //mixalpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n\t\t\t\t\t0123456789\n");
            //mixsyllable-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n\t\t\t\t\t0123456789t@#$%^&*()-_+=\n");
            //mixsyllable-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\tpa,zo,ki,sa,ou,ail,te,zi,ba, ...");
            //mixsyllable-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixsyllable-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\tPA,ZO,KI,SA,OU,AIL,TE,ZI,BA, ...\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:\n\t\t\t\t\t;\"'<>,.?/\n");
        }

    }
}
