//  Author:
//       Teeknofil <teeknofil.dev@gmail.com>
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

using Crisis.Combinatorics;
using Crisis.CommandLine;
using Crisis.Graphic;
using Crisis.Graphic.Menu;
using Crisis.Tools;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Resources;

namespace Crisis
{
    public class Run : Parameter
    { 

        private string extension = ".txt";
        
        private Interface _option;
      

        private Wordlist commun;
        private Statistical tools = new Statistical();

        public Run(ResourceManager lang)
        {
            Interface option = new Interface(lang);
            _option = option;

            commun = new Wordlist(lang);

            Main principal = new Main(lang);
            principal.Menu();                               
                        
            bool b = true;

            while (b)
            {
                int i = option.SelectOption(4); 
                bool zip = false;


                if (i == 1)
                {
                    
                    int typesAtGenerate = commun.Wifi();
                    if (typesAtGenerate == 1)
                    {
                        Parameter.NumberOfChar = 20;
                    }
                    else
                    {
                        Parameter.NumberOfChar = 26;
                    }
                                        
                    Parameter.CharsetSelecting = option.InterfaceSelectCharset(lang);
                    Parameter.NumberOfAllCombination = tools.CalculOfAllCombinaison(Repeat, 3, Parameter.NumberOfChar, Parameter.CharsetSelecting);
                    BackupFileWordlist();
                    tools.StatiscalInfoSize(Parameter.NumberOfAllCombination, 3, Parameter.NumberOfChar);
                    b = GenerateWordlist(3);
                    
                }
                else if (i == 2)
                {
                    
                    commun.MainCharacter();
                    
                    Parameter.CharsetSelecting = option.InterfaceSelectCharset(lang);
                    int typesAtGenerate = option.TypesAtGenerate();

                    if (typesAtGenerate == 1)
                    {
                        Parameter.NumberOfChar = option.SizeOfWorld(Parameter.CharsetSelecting, Parameter.NumberOfChar, typesAtGenerate);

                        Parameter.CharsetSelecting = ChangeStartEndReverseMixPattern(Parameter.CharsetSelecting);
                        BackupFileWordlist();
                        Parameter.NumberOfAllCombination = tools.CalculOfAllCombinaison(false, typesAtGenerate, Parameter.NumberOfChar, Parameter.CharsetSelecting);
                        
                        tools.StatiscalInfoSize(Parameter.NumberOfAllCombination, typesAtGenerate, Parameter.NumberOfChar);
                        b = GenerateWordlist(1);                        

                    }
                    else if (typesAtGenerate == 2 | typesAtGenerate == 4 | typesAtGenerate == 5)
                    {
                        Parameter.NumberOfChar = option.SizeOfWorld(Parameter.CharsetSelecting, Parameter.NumberOfChar, typesAtGenerate);
                        Repeat = option.Repetition(Repeat);

                        Parameter.CharsetSelecting = ChangeStartEndReverseMixPattern(Parameter.CharsetSelecting);
                        Parameter.NumberOfAllCombination = tools.CalculOfAllCombinaison(Repeat, typesAtGenerate, Parameter.NumberOfChar, Parameter.CharsetSelecting);
                        BackupFileWordlist();
                        tools.StatiscalInfoSize(Parameter.NumberOfAllCombination, typesAtGenerate, Parameter.NumberOfChar);

                        b =  GenerateWordlist(typesAtGenerate);


                    }
                    else if (typesAtGenerate == 3)
                    {
                        Parameter.NumberOfChar = option.SizeOfWorld(Parameter.CharsetSelecting, Parameter.NumberOfChar, typesAtGenerate);
                        Parameter.NumberOfAllCombination = tools.CalculOfAllCombinaison(Repeat, typesAtGenerate, Parameter.NumberOfChar, Parameter.CharsetSelecting);
                        BackupFileWordlist();
                        tools.StatiscalInfoSize(Parameter.NumberOfAllCombination, typesAtGenerate, Parameter.NumberOfChar);
                        b = GenerateWordlist(3);
                    }                    

                    
                }
                else if (i == 3)
                {

                    principal.TransformWordlist();                   
                    int typesAtGenerate = option.SelectOption(4);

                    if (typesAtGenerate == 88) new Run(lang);
                    if (typesAtGenerate == 99) Environment.Exit(0);

                    
                    PathBackUpFiles = option.PathOfBuckupFiles();
                    zip = option.SaveCharsetInFilesZip();
                    string extension = Interface.ExtensionFileOutputPath(zip);

                    Parameter.CharsetSelecting = option.MenuReadFileTxt();
                    
                    TransformTextFiles toDoTransformFile = new TransformTextFiles();
                    if (typesAtGenerate == 1) toDoTransformFile.L33tSpeek(Parameter.CharsetSelecting,PathBackUpFiles,extension,zip);
                    if (typesAtGenerate == 2) toDoTransformFile.LowercaseToUppercas(Parameter.CharsetSelecting, PathBackUpFiles, extension,zip);          
                    if (typesAtGenerate == 3) toDoTransformFile.UppercaseToLowercase(Parameter.CharsetSelecting,PathBackUpFiles,extension,zip);
                    if (typesAtGenerate == 4) toDoTransformFile.AutoUppercaseLowercase(Parameter.CharsetSelecting, PathBackUpFiles, extension, zip);                    

                    b = false;
                }
                else if (i == 4)
                {
                    Parameter.CharsetSelecting = option.UserPasswordProfilerCharset(Parameter.CharsetSelecting);
                    int typesAtGenerate = option.TypesAtGenerate();

                    Parameter.NumberOfChar = option.SizeOfWorld(Parameter.CharsetSelecting, Parameter.NumberOfChar, typesAtGenerate);
                    Repeat = option.Repetition(Repeat);

                    Parameter.CharsetSelecting = ChangeStartEndReverseMixPattern(Parameter.CharsetSelecting);
                    Parameter.NumberOfAllCombination = tools.CalculOfAllCombinaison(Repeat, typesAtGenerate, Parameter.NumberOfChar, Parameter.CharsetSelecting);
                    BackupFileWordlist();
                    tools.StatiscalInfoSize(Parameter.NumberOfAllCombination, typesAtGenerate, Parameter.NumberOfChar);

                    b = GenerateWordlist(typesAtGenerate);
                }                
                else if (i == 99)
                {
                    Environment.Exit(0);
                }
                else
                {
                    b = true;
                }
            }
        }

        public Run(string[] args)
        {
            CLI cmd = new CLI();
            CommandLineParser parser = new CommandLineParser(cmd);
            parser.Parse();
            

            try
            {
                if (cmd.Help || cmd.WordlistHelp)
                {
                    cmd.HelpPrint(args);
                }
                else
                {
                    cmd.SelectPattern(args);
                    cmd.FunctionLenght(args);

                    if (cmd.Invert)
                    {
                        CharsetSelecting.Reverse();
                    }

                    if (cmd.Startblock)
                    {
                        cmd.StartblockPattern(args);
                    }

                    if (cmd.EndBlock)
                    {
                        cmd.EndPattern(args);
                    }

                    if (cmd.Line)
                    {
                        cmd.FunctionLine(args);
                    }

                    if (cmd.Byte)
                    {
                        cmd.FunctionByte(args);
                    }

                    if (cmd.SaveFile)
                    {
                        cmd.FunctionSaveFiles(args);                                            
                    }

                    if (cmd.Crunch)
                    {
                        Parameter.TypesAtGenerate = 1;
                    }
                    else if (cmd.Combination)
                    {
                        Parameter.TypesAtGenerate = 2;
                    }
                    else if (cmd.Random)
                    {
                        Parameter.TypesAtGenerate = 3;
                    }
                    else if(cmd.Variation)
                    {
                        Parameter.TypesAtGenerate = 4;                        
                    }
                    else if(cmd.Permutation)
                    {
                        Parameter.TypesAtGenerate = 5;                        
                    }

                                        
                    Parameter.NumberOfAllCombination = tools.CalculOfAllCombinaison(cmd.Repeat, Parameter.TypesAtGenerate, Parameter.NumberOfChar, Parameter.CharsetSelecting);

                    if (cmd.Line == false & cmd.Byte == false)
                    {
                        Parameter.NumberLine = Parameter.NumberOfAllCombination;
                    }

                    if (cmd.Disables == false)
                    {
                        Main.Version();
                        tools.StatiscalInfoSize(Parameter.NumberOfAllCombination, Parameter.TypesAtGenerate, Parameter.NumberOfChar);
                    }

                    this.GenerateWordlist(cmd);
                    Console.ReadKey();

                }               

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /// Debug pause, must commenting for release
            Console.ReadKey();
        }
               
        private List<string> ChangeStartEndReverseMixPattern(List<string> charsetSelecting)
        {
            
            Parameter.CharsetSelecting = _option.ChangeStartblockPattern(Parameter.CharsetSelecting);
            Parameter.CharsetSelecting = _option.ChangeEndblockPattern(Parameter.CharsetSelecting, Parameter.NumberOfChar);
            Parameter.CharsetSelecting = _option.ReversePatern(Parameter.CharsetSelecting);
            Parameter.CharsetSelecting = _option.MixPatern(Parameter.CharsetSelecting, Parameter.NumberOfChar);

            return Parameter.CharsetSelecting;
        }

        private void BackupFileWordlist()
        {
            SaveFile = _option.SaveCharsetInFilesTxt();
            
            if (SaveFile)
            {
                PathBackUpFiles = _option.PathOfBuckupFiles();
                Parameter.NumberLine = _option.SizeFile(SaveFile, Parameter.NumberOfChar, TypesAtGenerate, Parameter.NumberOfAllCombination);
                Zip = _option.SaveCharsetInFilesZip();
            }
        }

        /// <summary>
        /// Generate Wordlist under choice user
        /// </summary>
        /// <param name="typesAtGenerate"></param>
        /// <returns>Return false for down loop</returns>

        private bool GenerateWordlist(int typesAtGenerate)
        {
            CombinationPattern obj2 = new CombinationPattern();

            if (typesAtGenerate == 1 )
            {               
                obj2.GenerateIncrementing(Parameter.CharsetSelecting, Parameter.NumberLine, saveFile, Zip, false, typesAtGenerate, Parameter.NumberOfChar, PathBackUpFiles, extension);
            }
            else if (typesAtGenerate == 2)
            {
                
                obj2.GenerateIncrementing(Parameter.CharsetSelecting, Parameter.NumberLine, saveFile, Zip, Repeat, typesAtGenerate, Parameter.NumberOfChar, PathBackUpFiles, extension);
            }
            else if (typesAtGenerate == 3)
            {
                Randomizer obj = new Randomizer();
                obj.GenerateRandomString(Parameter.CharsetSelecting, Parameter.NumberLine, saveFile, Parameter.NumberOfAllCombination, Zip, Parameter.NumberOfChar, PathBackUpFiles, extension);
            }
            else if (typesAtGenerate == 4 )
            {
                VariationnPattern obj = new VariationnPattern();
                obj.GenerateVariationString(Parameter.CharsetSelecting, Parameter.NumberOfAllCombination,Parameter.NumberLine, saveFile, Zip, Repeat, Parameter.NumberOfChar, PathBackUpFiles, extension);
            }
            else if (typesAtGenerate == 5)
            {
                PermutationPattern obj = new PermutationPattern();
                obj.GeneratePermutationString(Parameter.CharsetSelecting, Parameter.NumberOfAllCombination,Parameter.NumberLine, Parameter.NumberOfChar, saveFile, Zip, Repeat, typesAtGenerate,  PathBackUpFiles, extension);
            }

            return false;
        }


        private bool GenerateWordlist(CLI cmd)
        {
            CombinationPattern obj2 = new CombinationPattern();

            if (cmd.Crunch)
            {
                obj2.GenerateIncrementing(Parameter.CharsetSelecting, Parameter.NumberLine, cmd.SaveFile, cmd.Zip, false, 1, Parameter.NumberOfChar, PathBackUpFiles, extension);
            }
            else if (cmd.Combination)
            {
                obj2.GenerateIncrementing(Parameter.CharsetSelecting, Parameter.NumberLine, cmd.SaveFile, cmd.Zip, cmd.Repeat, 2, Parameter.NumberOfChar, PathBackUpFiles, extension);
            }
            else if (cmd.Random | cmd.Wifi)
            {
                Randomizer obj = new Randomizer();
                obj.GenerateRandomString(Parameter.CharsetSelecting, Parameter.NumberLine, cmd.SaveFile, Parameter.NumberOfAllCombination,  cmd.Zip, Parameter.NumberOfChar, PathBackUpFiles, extension);
            }
            else if (cmd.Variation)
            {
                VariationnPattern obj = new VariationnPattern();
                obj.GenerateVariationString(Parameter.CharsetSelecting,Parameter.NumberOfAllCombination, Parameter.NumberLine, cmd.SaveFile, cmd.Zip, cmd.Repeat, Parameter.NumberOfChar, PathBackUpFiles, extension);
            }
            else if (cmd.Permutation)
            {
                PermutationPattern obj = new PermutationPattern();
                obj.GeneratePermutationString(Parameter.CharsetSelecting, Parameter.NumberOfAllCombination,Parameter.NumberLine, Parameter.NumberOfChar,  cmd.SaveFile, cmd.Zip, cmd.Repeat, 5,  PathBackUpFiles, extension);
            }

            return false;
        }
    }
}
