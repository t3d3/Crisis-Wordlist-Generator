using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plossum.CommandLine;
using System.IO;

namespace crisis
{
    public partial class Command
    {
        public int FunctionInverts(string[] args)
        {
           
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Invert)
            {
                Charset.CharsetSelecting.Reverse();
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

        public int FunctionOnNumberChar(string[] args)
        {
           
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

             for (int i = 0; i < args.Length; i++)
                {
                    if (options.Lenght)
                    {
                        if (args[i].ToLower() == "-l" | args[i].ToLower() == "--lenght")
                        {
                            int l;

                            bool bb = int.TryParse(args[i + 1], out l);

                            if (l.Equals(null) | bb == false)
                            {
                                Console.WriteLine("\nThe value entered with the -l option is incorrect\n");
                                Environment.Exit(0);
                            }
                            else
                            {
                                Parameter.NumberOfChar = l;
                            }
                        }
                    }
                    else if (parser.HasErrors)
                    {
                        Console.WriteLine(parser.UsageInfo.ToString(78, true));
                        return -1;
                    }
                } // End For

           

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }


        public int FunctionSizeFilesTxt(string[] args)
        {
            
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            for (int i = 0; i < args.Length; i++)
                {
                    if (options.Byte)
                    {
                        if (args[i].ToLower() == "-b" | args[i].ToLower() == "--byte")
                        {
                            int b;

                            bool booleanByte = int.TryParse(args[i + 1], out b);

                            if (booleanByte == false)
                            {
                                Console.WriteLine("\nThe value entered with the -b option is incorrect\n");
                                Environment.Exit(0);
                            }
                            else
                            {
                                if (args[i + 2].ToLower() == "kib")
                                {
                                    b *= 1024;
                                }
                                else if (args[i + 2].ToLower() == "mib")
                                {
                                    b *= 1048576;
                                    
                                }
                                else if (args[i + 2].ToLower() == "gib")
                                {
                                    b *= 1073741824;
                                }
                                
                                Statistical.DefaultSizeFileInOctet = b;
                                Console.WriteLine("\n\n\n" + Statistical.DefaultSizeFileInOctet);
                            }
                        }
                    }
                    else if (parser.HasErrors)
                    {
                        Console.WriteLine(parser.UsageInfo.ToString(78, true));
                        return -1;
                    }
                }
            

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }

        public int FunctionSaveFiles(string[] args)
        {
            Statistical obj1 = new Statistical();
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.FileName)
            {
                Parameter.SaveFile = 1;
                if (options.Line == false)
                {
                    obj1.CalculSizeFile();
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

        public int FunctionNbLine(string[] args)
        {            
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            for (int i = 0; i < args.Length; i++)
                {
                    if (options.Line)
                    {
                        if (args[i].ToLower() == "-c" | args[i].ToLower() == "--line")
                        {
                            int c;

                            bool booleanLine = int.TryParse(args[i + 1], out c);

                            if ( booleanLine == false)
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
                    else if (parser.HasErrors)
                    {
                        Console.WriteLine(parser.UsageInfo.ToString(78, true));
                        return -1;
                    }
                }
            

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }

        public int FunctionTypeOfProcedur(string[] args)
        {
            Algorithme Function = new Algorithme();
            Statistical obj1 = new Statistical();
            Command options = new Command();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Crunch)
            {
                Parameter.TypesOfGeneration = 1;
                obj1.CalculOfAllCombinaison();

                if (options.Disables == false)
                {
                    Statistical info = new Statistical();
                    info.StatiscalInfoSize();
                }
                Function.EnumerationPrint();
            }
            else if (options.Enumeration)
            {
                Parameter.TypesOfGeneration = 2;
                obj1.CalculOfAllCombinaison();

                if (options.Disables == false)
                {
                    Statistical info = new Statistical();
                    info.StatiscalInfoSize();
                }
                Function.EnumerationPrint();
            }
            else if (options.Random)
            {
                Parameter.TypesOfGeneration = 3;
                obj1.CalculOfAllCombinaison();

                if (options.Disables == false)
                {
                    Statistical info = new Statistical();
                    info.StatiscalInfoSize();
                }
                Function.RamdonPrint();
            } 
            else if (options.LeetSpeak)
            {
                Parameter.TypesOfGeneration = 4;

                for (int i = 0; i < args.Length-1 ; i++)
                {
                    if (args[i].ToLower() == "-4" | args[i].ToLower() == "--leetpeack")
                    {
                        Charset.CharsetName = args[i+1];
                    }                    
                }

                Charset.ReadFileTxt();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n This work, please wait\n");
                Console.ResetColor();

                Function.L33tSpeek();
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
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
}// End namaspace
