using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using crisis.CommandLine;

namespace crisis 
{
    class Run : Property
    {
                      
        
        public Run()
        {
            MainMenu.BooleanCategoryMenu = true;

            MainMenu runMenu = new MainMenu();
            runMenu.Start();
            runMenu.Menu();

            Statistical info = new Statistical();
            MenuParameter config = new MenuParameter();

            if (Property.TypesOfGeneration == 1)
            {
                CombinationPattern obj = new CombinationPattern();

                config.SizeOfWorld();
                config.ChangeStartblockPattern();
                config.ChangeEndblockPattern();
                config.ReversePaterne();

                info.CalculOfAllCombinaison(Repeat);
                config.SaveCharsetInFilesTxt(ref saveFile, ref zip);

                info.StatiscalInfoSize();

                obj.CombinationPrintF(SaveFile,Zip,Repeat);
                MenuParameter.TypesOfGeneration = 0;
            }
            if (Property.TypesOfGeneration == 2)
            {
               CombinationPattern obj = new CombinationPattern();

                config.SizeOfWorld();
                config.Repetition(ref repeat);
                config.ChangeStartblockPattern();
                config.ChangeEndblockPattern();
                config.ReversePaterne();
                
                
                info.CalculOfAllCombinaison(Repeat);
                config.SaveCharsetInFilesTxt(ref saveFile, ref zip);

                info.StatiscalInfoSize();

                obj.CombinationPrintF(SaveFile, Zip,Repeat);

                MenuParameter.TypesOfGeneration = 0;
            }
            else if (Property.TypesOfGeneration == 3 | Property.TypesOfGeneration == 6)
            {
                Randomizer obj = new Randomizer();

                if (Property.TypesOfGeneration == 3)
                {
                    config.SizeOfWorld();
                }

                info.CalculOfAllCombinaison(Repeat);
                config.SaveCharsetInFilesTxt(ref saveFile, ref zip);

                info.StatiscalInfoSize();

                obj.RamdonPrintF(SaveFile,Zip);

                MenuParameter.TypesOfGeneration = 0;
            }
            else if (Property.TypesOfGeneration == 4)
            {
                VariationnPattern obj = new VariationnPattern();

                config.SizeOfWorld();
                config.Repetition(ref repeat);
                config.ChangeStartblockPattern();
                config.ChangeEndblockPattern();
                config.ReversePaterne();

                info.CalculOfAllCombinaison(Repeat);
                config.SaveCharsetInFilesTxt(ref saveFile, ref zip);

                info.StatiscalInfoSize();

                obj.VariationPrintF(SaveFile,Zip,Repeat);

                MenuParameter.TypesOfGeneration = 0;
            }
            else if (Property.TypesOfGeneration == 5)
            {
                PermutationPattern obj = new PermutationPattern();

                config.SizeOfWorld();
                config.Repetition(ref repeat);
                config.ChangeStartblockPattern();
                config.ChangeEndblockPattern();
                config.ReversePaterne();

                
                info.CalculOfAllCombinaison(Repeat);
                config.SaveCharsetInFilesTxt(ref saveFile, ref zip);
                info.StatiscalInfoSize();

                obj.PermutationPrintF(SaveFile,Zip,Repeat);

                MenuParameter.TypesOfGeneration = 0;
            }
            else if (Property.TypesOfGeneration == 8)
            {
                LeetSpeak obj = new LeetSpeak();
                config.SaveCharsetInFilesTxt(ref saveFile, ref zip);

                obj.L33tSpeekPrintF();

                MenuParameter.TypesOfGeneration = 0;
            }
        }



        public Run(string[] args)
        {
            Command run = new Command();
            Statistical info = new Statistical();

            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            //Help must be first
            if (options.Help)
            {
                run.HelpPrint(args);
            }

            run.FunctionPattern(args);

            if (options.Crunch)
            {
                MenuParameter.TypesOfGeneration = 1;
                CombinationPattern obj = new CombinationPattern();

                run.FunctionLenght(args);

                if (options.Invert)
                {
                    run.FunctionInverts(args);
                }

                if (options.Startblock)
                {
                    run.FunctionStartblock(args);
                }

                if (options.EndBlock)
                {
                    run.FunctionEndblock(args);
                } 
                
                run.FunctionByte(args);

                info.CalculOfAllCombinaison(options.Repeat);

                run.FunctionLine(args);
                if (options.Line == false)
                {
                    run.FunctionByte(args);
                }

                run.FunctionSaveFiles(args);

                if (options.SaveFile)
                {
                    run.FunctionZip(args);
                }

                if (options.Disables == false)
                {
                    MainMenu runMenu = new MainMenu();
                    runMenu.Start();
                    info.StatiscalInfoSize();
                }

                obj.CombinationPrintF(options.SaveFile, options.Zip, options.Repeat);
            }
            else if (options.Combination)
            {
                MenuParameter.TypesOfGeneration = 2;
                CombinationPattern obj = new CombinationPattern();

                run.FunctionLenght(args);
                
                if (options.Invert)
                {
                    run.FunctionInverts(args);
                }

                if (options.Startblock)
                {
                    run.FunctionStartblock(args);
                }

                if (options.EndBlock)
                {
                    run.FunctionEndblock(args);
                }
                

                info.CalculOfAllCombinaison(options.Repeat);

                if (options.Line)
                {
                    run.FunctionLine(args);
                }

                if (options.Line == false)
                {
                    run.FunctionByte(args);
                }

                

                if (options.SaveFile)
                {
                    run.FunctionSaveFiles(args);
                    run.FunctionZip(args);
                }

                if (options.Disables == false)
                {
                    MainMenu runMenu = new MainMenu();
                    runMenu.Start();
                    info.StatiscalInfoSize();
                }


                obj.CombinationPrintF(options.SaveFile,options.Zip,options.Repeat);
            }
            else if (options.Random || options.Wifi)
            {
                MenuParameter.TypesOfGeneration = 6;
                Randomizer obj = new Randomizer();

                if (options.Random)
                {
                    MenuParameter.TypesOfGeneration = 3;
                    run.FunctionLenght(args);
                }

                info.CalculOfAllCombinaison(options.Repeat);
                run.FunctionLine(args);
                if (options.Line == false)
                {
                    run.FunctionByte(args);
                }

                if (options.SaveFile)
                {
                  run.FunctionSaveFiles(args);  
                }
                

                if (options.SaveFile)
                {
                    run.FunctionZip(args);
                }

                if (options.Disables == false)
                {
                    MainMenu runMenu = new MainMenu();
                    runMenu.Start();
                    info.StatiscalInfoSize();
                }

                obj.RamdonPrintF(options.SaveFile,options.Zip);
            }
            else if (options.Variation)
            {
                MenuParameter.TypesOfGeneration = 4;
                VariationnPattern obj = new VariationnPattern();

                run.FunctionLenght(args);

                if (options.Invert)
                {
                    run.FunctionInverts(args);
                }

                if (options.Startblock)
                {
                    run.FunctionStartblock(args);
                }

                if (options.EndBlock)
                {
                    run.FunctionEndblock(args);
                }                

                info.CalculOfAllCombinaison(options.Repeat);
                run.FunctionLine(args);
                if (options.Line == false)
                {
                    run.FunctionByte(args);
                }                        

                if (options.SaveFile)
                {
                    run.FunctionSaveFiles(args);
                    run.FunctionZip(args);
                }

                if (options.Disables == false)
                {
                    MainMenu runMenu = new MainMenu();
                    runMenu.Start();
                    info.StatiscalInfoSize();
                }

                obj.VariationPrintF(options.SaveFile,options.Zip, options.Repeat);
            }
            else if (options.Permutation)
            {
                MenuParameter.TypesOfGeneration = 5;
                PermutationPattern obj = new PermutationPattern();

                run.FunctionLenght(args);
                
                if (options.Invert)
                {
                    run.FunctionInverts(args);
                }

                if (options.Startblock)
                {
                    run.FunctionStartblock(args);
                }

                if (options.EndBlock)
                {
                    run.FunctionEndblock(args);
                }

                info.CalculOfAllCombinaison(options.Repeat);
                run.FunctionLine(args);
                if (options.Line == false)
                {
                    run.FunctionByte(args);
                }

                run.FunctionSaveFiles(args);

                if (options.SaveFile)
                {
                    run.FunctionZip(args);
                }

                if (options.Disables == false)
                {
                    MainMenu runMenu = new MainMenu();
                    runMenu.Start();
                    info.StatiscalInfoSize();
                }

                obj.PermutationPrintF(options.SaveFile,options.Zip,options.Repeat);
            }
            else if (options.LeetSpeak)
            {
                LeetSpeak obj = new LeetSpeak();
                MenuParameter.TypesOfGeneration = 8;

                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToString().ToLower() == "-8" | args[i].ToString().ToLower() == "--leetspeak")
                    {
                        Charset.CharsetName = args[i + 1].ToString();
                    }
                }

                if (options.Disables == false)
                {
                    MainMenu runMenu = new MainMenu();
                    runMenu.Start();
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

            Console.ReadKey();
        }




    }
}
