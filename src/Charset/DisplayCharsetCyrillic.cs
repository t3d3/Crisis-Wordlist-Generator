using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public static partial class  DisplayCharset
    {

        public static void CyrillicCharacterLowercasePrint()
        {
            Console.WriteLine("\n #### Cyrillic Mixcase \n");

            //lcyrillic
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic");
            Console.ResetColor();

            Console.WriteLine("\t\t\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //lcyrillic-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" lcyrillic-space\n");
            Console.ResetColor();

            //lcyrillic-numeric

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric");
            Console.ResetColor();

            Console.WriteLine("\t\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //lcyrillic-numeric-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric-space");
            Console.ResetColor();

            Console.WriteLine("\t\t0123456789\n");
            //lcyrillic-numeric-symbol14

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric-symbol14");
            Console.ResetColor();

            Console.WriteLine("\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //lcyrillic-numeric-symbol14-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric-symbol14-space");
            Console.ResetColor();

            Console.WriteLine(" \t0123456789@#$%^&*()-_+= [space]\n");
            //lcyrillic-numeric-all

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric-all");
            Console.ResetColor();

            Console.WriteLine("\t\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //lcyrillic-numeric-all-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" lcyrillic-numeric-all-space ");
            Console.ResetColor();

            Console.WriteLine("\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
        }


        public static void CyrillicCharacterUppercasePrint()
        {
            Console.WriteLine("\n #### Cyrillic Uppercase \n");
            //lcyrillic
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic");
            Console.ResetColor();

            Console.WriteLine("\t\t\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

            //lcyrillic-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ucyrillic-space\n");
            Console.ResetColor();

            //lcyrillic-numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric");
            Console.ResetColor();

            Console.WriteLine("\t\t\tаАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            //lcyrillic-numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric-space");
            Console.ResetColor();

            Console.WriteLine("\t\t0123456789\n");
            //lcyrillic-numeric-symbol14

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric-symbol14");
            Console.ResetColor();

            Console.WriteLine("\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

            //lcyrillic-numeric-symbol14-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric-symbol14-space");
            Console.ResetColor();

            Console.WriteLine(" \t0123456789@#$%^&*()-_+= [space]\n");
            //lcyrillic-numeric-all

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric-all");
            Console.ResetColor();

            Console.WriteLine("\t\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            //lcyrillic-numeric-all-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ucyrillic-numeric-all-space ");
            Console.ResetColor();

            Console.WriteLine("\t\t0123456789!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/\n");
        }


        public static void CyrillicCharacterUppercaseLowercasePrint()
        {
            Console.WriteLine("\n #### Cyrillic Mixcase \n");
            //mixcyrillic

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic");
            Console.ResetColor();

            Console.WriteLine("\t\t\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //mixcyrillic-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-space");
            Console.ResetColor();

            Console.WriteLine("\t\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n");
            //mixcyrillic-numeric

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-numeric");
            Console.ResetColor();

            Console.WriteLine("\t\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");

            //mixcyrillic-numeric-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-numeric-space");
            Console.ResetColor();

            Console.WriteLine("\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n\t\t\t\t\t0123456789\n");

            //mixcyrillic-numeric-symbol14

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mmixcyrillic-numeric-symbol14");
            Console.ResetColor();

            Console.WriteLine("\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");

            //mixcyrillic-numeric-symbol14-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-numeric-symbol14-space");
            Console.ResetColor();

            Console.WriteLine("\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=\n");
            //mixcyrillic-numeric-all

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-numeric-all");
            Console.ResetColor();

            Console.WriteLine("\t\tабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            //mixcyrillic-numeric-all-space

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" mixcyrillic-numeric-all-space");
            Console.ResetColor();

            Console.WriteLine("\t\tАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n\t\t\t\t\t0123456789!@#$%^&*()-_+=~`\n\t\t\t\t\t[]{}|\\:;\"'<>,.?/\n");
        }



    }
}
