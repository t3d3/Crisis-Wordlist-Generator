using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public static partial class DisplayCharset
    {
        public static void SwddishCharacterLowercasePrint()
        {
            //////////////////////////////////////////////////////////////////////////////////////////
            //                 SWEDISH CHAR  SUPPORT                                                // 
            /////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////
            // Lowercase           //
            /////////////////////////

            Console.WriteLine("\n #### Swddish Lowercase \n");

            //lalpha-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //lalpha-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" sv-lalpha-space\n");
            Console.ResetColor();
            //lalpha-numeric-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyzåäö0");
            //lalpha-numeric-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t123456789\n");
            //lalpha-numeric-symbol14-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tabcdefghijklmnopqrstuvwxyzåäö0");
            //lalpha-numeric-symbol14-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\t123456789!@#$%^&*()-_+=\n");
            //lalpha-numeric-all-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyzåäö0");
            //lalpha-numeric-all-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-lalpha-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/ [space]\n");
        }

        public static void SwddishCharacterUppercasePrint()
        {

            /////////////////////////
            //       Uppercase     //
            /////////////////////////
            Console.WriteLine("\n #### Swddish Uppercase \n");
            //ualpha-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ");
            //ualpha-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" sv-ualpha-space\n");
            Console.ResetColor();
            //ualpha-numeric-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
            //ualpha-numeric-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" sv-ualpha-numeric-space\n");
            Console.ResetColor();
            //ualpha-numeric-symbol14-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
            //ualpha-numeric-symbol14-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine("\t@#$%^&*()-_+= [space]\n");
            //ualpha-numeric-all-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ0123456789");
            //ualpha-numeric-all-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-ualpha-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
        }



        public static void SwddishCharacterLowercaseUppercasePrint()
        {
            /////////////////////////
            // Mixcase             // 
            ////////////////////////
            Console.WriteLine("\n #### Swddish Mixcase \n");
            //mixalpha-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n");
            //mixalpha-numeric-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric");
            Console.ResetColor();
            Console.WriteLine("\t\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-numeric-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789\n");
            //mixalpha-numeric-symbol14-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric-symbol14");
            Console.ResetColor();
            Console.WriteLine("\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-numeric-symbol14-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric-symbol14-space");
            Console.ResetColor();
            Console.WriteLine(" \tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=\n");
            //mixalpha-numeric-all-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric-all");
            Console.ResetColor();
            Console.WriteLine("\t\tabcdefghijklmnopqrstuvwxyzåäö");
            //mixalpha-numeric-all-space-sv
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sv-mixalpha-numeric-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\tABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/\n");
        }
    }
}
