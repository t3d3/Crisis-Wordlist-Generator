using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public static partial class  DisplayCharset
    {
        public static void LatinCharacterLowercasePrint()
        {
            Console.WriteLine("\n #### Latin Lowercase \n");
            //lalpha
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\tabcdefghijklmnopqrstuvwxyz");
            //lalpha-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" lalpha-space\n");
            Console.ResetColor();
            //lalpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tabcdefghijklmnopqrstuvwxyz");
            //lalpha-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t0123456789\n");
            //lalpha-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tabcdefghijklmnopqrstuvwxyz0123456789");
            //lalpha-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine(" \t\t@#$%^&*()-_+= [space]\n");
            //lalpha-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyz0123456789");
            //lalpha-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lalpha-numeric-all-space ");
            Console.ResetColor();
            Console.WriteLine("\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
        }

        public static void LatinCharacteUppercasePrint()
        {
            Console.WriteLine("\n #### Latin Uppercase \n");
            //ualpha
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ");
            //ualpha-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ualpha-space\n");
            Console.ResetColor();
            //ualpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ");
            //ualpha-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t0123456789\n");
            //ualpha-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
            //ualpha-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\t\t@#$%^&*()-_+=\n");
            //ualpha-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
            //ualpha-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ualpha-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
        }

        public static void LatinCharacterUppercaseLowercasePrint()
        {
            Console.WriteLine("\n #### Latin Uppercase \n");
            //mixalpha
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tabcdefghijklmnopqrstuvwxyz");
            //mixalpha-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ\n");
            //mixalpha-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyz");
            //mixalpha-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t\t0123456789\n");
            //mixalpha-numeric-symbol14
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mmixalpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tabcdefghijklmnopqrstuvwxyz");
            //mixalpha-numeric-symbol14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\tABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=\n");
            //mixalpha-numeric-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyz");
            //mixalpha-numeric-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixalpha-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\tABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/\n");
        }
    }
}
