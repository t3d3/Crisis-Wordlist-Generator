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

using System;
using crisis.CommandLine;
using System.Text.RegularExpressions;

namespace crisis
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.White;
            FilesNameDirectory os = new FilesNameDirectory();
            os.FilesPathDirectory();
            Console.SetWindowSize(100, 25);

            if (args.Length == 0)
            {

                MainMenu obj = new MainMenu();

            }
            else
            {
                Command run = new Command();
                Statistical info = new Statistical();               

                Command options = new Command();
                CommandLineParser parser = new CommandLineParser(options);
                parser.Parse();

                //Help must be first
                run.HelpPrint(args);
                run.FunctionPattern(args);

                if (options.Crunch)
                {
                    Parameter.TypesOfGeneration = 1;
                    CombinationPattern obj = new CombinationPattern();

                    run.FunctionLenght(args);                    
                    run.FunctionInverts(args);

                    run.FunctionStartblock(args);
                    run.FunctionEndblock(args);
                    //run.FunctionByte(args);
                    //run.FunctionLine(args);

                    Parameter.NumberLine = info.CalculOfAllCombinaison();
                    run.FunctionSaveFiles(args);

                    info.CalculOfAllCombinaison();
                    if (options.Disables == false)
                    {
                        MainMenu.Start();
                        info.StatiscalInfoSize();
                    }


                    obj.CombinationPrintF();
                }
                else if (options.Combination)
                {
                    Parameter.TypesOfGeneration = 2;
                    CombinationPattern obj = new CombinationPattern();

                    run.FunctionLenght(args);
                    run.FunctionRepeat(args);
                    run.FunctionInverts(args);
                    
                    run.FunctionStartblock(args);
                    run.FunctionEndblock(args);
                    //run.FunctionByte(args);
                    //run.FunctionLine(args);

                    Parameter.NumberLine = info.CalculOfAllCombinaison();
                    run.FunctionSaveFiles(args);

                    info.CalculOfAllCombinaison();
                    if (options.Disables == false)
                    {
                        MainMenu.Start();
                        info.StatiscalInfoSize();
                    }

                    
                    obj.CombinationPrintF();
                }
                else if (options.Random || options.Wifi)
                {
                    Parameter.TypesOfGeneration = 6;
                    Randomizer obj = new Randomizer();

                    if (options.Random)
                    {
                        Parameter.TypesOfGeneration = 3;
                        run.FunctionLenght(args);
                    }
                    
                    //run.FunctionByte(args);
                    //run.FunctionLine(args);
                    
                    Parameter.NumberLine = info.CalculOfAllCombinaison();
                    run.FunctionSaveFiles(args);                    

                    info.CalculOfAllCombinaison();

                    if (options.Disables == false)
                    {
                        MainMenu.Start();
                        info.StatiscalInfoSize();
                    }

                    
                    obj.RamdonPrintF();
                }
                else if (options.Variation )
                {
                    Parameter.TypesOfGeneration = 4;
                    VariationnPattern obj = new VariationnPattern();

                    run.FunctionLenght(args);
                    run.FunctionRepeat(args);
                    run.FunctionInverts(args);
                    
                    run.FunctionStartblock(args);
                    run.FunctionEndblock(args);
                    //run.FunctionByte(args);
                    //run.FunctionLine(args);

                    Parameter.NumberLine = info.CalculOfAllCombinaison();
                    run.FunctionSaveFiles(args);

                   info.CalculOfAllCombinaison();
                    if (options.Disables == false)
                    {
                        MainMenu.Start();
                        info.StatiscalInfoSize();
                    }

                    obj.VariationPrintF();
                }
                else if (options.Permutation)
                {
                    Parameter.TypesOfGeneration = 5;
                    PermutationPattern obj = new PermutationPattern();

                    run.FunctionLenght(args);
                    run.FunctionRepeat(args);
                    run.FunctionInverts(args);

                    run.FunctionStartblock(args);
                    run.FunctionEndblock(args);
                    //run.FunctionByte(args);
                    //run.FunctionLine(args);
                              
                    info.CalculOfAllCombinaison();
                    run.FunctionSaveFiles(args);

                    if (options.Disables == false)
                    {
                        MainMenu.Start();
                        info.StatiscalInfoSize();
                    }

                    obj.PermutationPrintF();
                }
                else if (options.LeetSpeak)
                {
                    LeetSpeak obj = new LeetSpeak();
                    Parameter.TypesOfGeneration = 8;

                    for (int i = 0; i < args.Length; i++)
                    {
                        if (args[i].ToString().ToLower() == "-8" | args[i].ToString().ToLower() == "--leetspeak")
                        {
                            Charset.CharsetName = args[i + 1].ToString();
                        }
                    }

                    if (options.Disables == false)
                    {
                        MainMenu.Start();
                    }
                    Charset.ReadFileTxt();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n This work, please wait\n");
                    Console.ResetColor();

                    obj.L33tSpeekPrintF();
                }
                else if (parser.HasErrors)
                {
                    Console.WriteLine(parser.UsageInfo.ToString(78, true));
                }                        

            }

            Console.ReadKey();
        }


    }
}
