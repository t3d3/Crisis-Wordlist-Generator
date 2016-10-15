using System;
using System.Linq;
using System.Text;
using Crisis.Graphic.Menu;
using Crisis.Graphic;
using System.Collections.Generic;
using System.Resources;
using Crisis.Tools;
using Crisis.Combinatorics;
using System.Numerics;

namespace Crisis
{
    public class Run : Parameter
    { 

        public Run(ResourceManager lang)
        {
            Interface category = new Interface(lang);
            Main principal = new Main(lang);
            principal.Menu();                               
                        
            bool b = true;

            while (b)
            {
                int i = category.SelectOption();

                Wordlist commun = new Wordlist(lang);
                Interface option = new Interface(lang);
                Statistical tools = new Statistical();

                if (i == 1)
                {
                    int typesAtGenerate = commun.Wifi();

                    if (typesAtGenerate == 1)
                    {
                        numberOfChar = 20;
                    }
                    else
                    {
                        numberOfChar = 26;
                    }
                                        
                    charsetSelecting = option.InterfaceSelectCharset(lang);

                    BigInteger numberOfAllCombination = tools.CalculOfAllCombinaison(repeat, 3, numberOfChar, charsetSelecting);

                    SaveFile = option.SaveCharsetInFilesTxt(numberOfChar, 3, numberLine);
                    string extension = ".txt";

                    if (SaveFile)
                    {
                        numberLine = option.sizeFile(SaveFile, numberOfChar, 3, numberOfAllCombination);
                        Zip = option.SaveCharsetInFilesZip();
                        if (Zip)
                        {
                            extension = ".zip";
                        }

                    }

                    tools.StatiscalInfoSize(numberOfAllCombination, 3, numberOfChar);
                    Randomizer obj = new Randomizer();
                    obj.GenerateRandomString(charsetSelecting, numberLine, numberOfAllCombination, saveFile, Zip, numberOfChar, null, extension);
                }
                else if (i == 2)
                {
                    
                    commun.MainCharacter();
                    
                    charsetSelecting = option.InterfaceSelectCharset(lang);
                    int typesAtGenerate = option.TypesAtGenerate();

                    if (typesAtGenerate == 1)
                    {
                        numberOfChar = option.SizeOfWorld(charsetSelecting, numberOfChar, typesAtGenerate);
                        charsetSelecting = option.ChangeStartblockPattern(charsetSelecting);
                        charsetSelecting = option.ChangeEndblockPattern(charsetSelecting, numberOfChar);
                        charsetSelecting = option.ReversePatern(charsetSelecting);

                        SaveFile = option.SaveCharsetInFilesTxt(numberOfChar, typesAtGenerate, numberLine);

                        BigInteger numberOfAllCombination = tools.CalculOfAllCombinaison(false, typesAtGenerate, numberOfChar, charsetSelecting);


                        string extension = ".txt";

                        if (SaveFile)
                        {
                            numberLine = option.sizeFile(SaveFile, numberOfChar, typesAtGenerate, numberOfAllCombination);
                            Zip = option.SaveCharsetInFilesZip();
                            if (Zip)
                            {
                                extension = ".zip";
                            }

                        }

                        tools.StatiscalInfoSize(numberOfAllCombination, typesAtGenerate, numberOfChar);

                        CombinationPattern obj = new CombinationPattern();
                        obj.GenerateIncrementing(charsetSelecting, numberLine, saveFile, Zip, false, typesAtGenerate, numberOfChar, null, extension);

                    }
                    else if (typesAtGenerate == 2 | typesAtGenerate == 4 | typesAtGenerate == 5)
                    {
                        numberOfChar = option.SizeOfWorld(charsetSelecting, numberOfChar, typesAtGenerate);
                        repeat = option.Repetition(repeat);
                        charsetSelecting = option.ChangeStartblockPattern(charsetSelecting);
                        charsetSelecting = option.ChangeEndblockPattern(charsetSelecting, numberOfChar);
                        charsetSelecting = option.ReversePatern(charsetSelecting);

                        BigInteger numberOfAllCombination = tools.CalculOfAllCombinaison(repeat, typesAtGenerate, numberOfChar, charsetSelecting);

                        SaveFile = option.SaveCharsetInFilesTxt(numberOfChar, typesAtGenerate, numberLine);
                        string extension = ".txt";

                        if (SaveFile)
                        {
                            numberLine = option.sizeFile(SaveFile, numberOfChar, typesAtGenerate, numberOfAllCombination);
                            Zip = option.SaveCharsetInFilesZip();
                            if (Zip)
                            {
                                extension = ".zip";
                            }

                        }

                        tools.StatiscalInfoSize(numberOfAllCombination, typesAtGenerate, numberOfChar);

                        if (typesAtGenerate == 2)
                        {
                            CombinationPattern obj = new CombinationPattern();
                            obj.GenerateIncrementing(charsetSelecting, numberLine, saveFile, Zip, repeat, typesAtGenerate, numberOfChar, null, extension);
                        }
                        else if (typesAtGenerate == 4)
                        {
                            VariationnPattern obj = new VariationnPattern();
                            obj.GenerateVariationString(charsetSelecting, numberLine, saveFile, Zip, repeat, numberOfChar, null, extension);
                        }
                        else if (typesAtGenerate == 5)
                        {
                            PermutationPattern obj = new PermutationPattern();
                            obj.GeneratePermutationString(charsetSelecting, numberLine, numberOfAllCombination, saveFile, Zip, repeat, typesAtGenerate, numberOfChar, null, extension);
                        }

                    }
                    else if (typesAtGenerate == 3)
                    {
                        numberOfChar = option.SizeOfWorld(charsetSelecting, numberOfChar, typesAtGenerate);

                        BigInteger numberOfAllCombination = tools.CalculOfAllCombinaison(repeat, typesAtGenerate, numberOfChar, charsetSelecting);

                        SaveFile = option.SaveCharsetInFilesTxt(numberOfChar, typesAtGenerate, numberLine);
                        string extension = ".txt";

                        if (SaveFile)
                        {
                            numberLine = option.sizeFile(SaveFile, numberOfChar, typesAtGenerate, numberOfAllCombination);
                            Zip = option.SaveCharsetInFilesZip();
                            if (Zip)
                            {
                                extension = ".zip";
                            }

                        }

                        tools.StatiscalInfoSize(numberOfAllCombination, typesAtGenerate, numberOfChar);
                        Randomizer obj = new Randomizer();
                        obj.GenerateRandomString(charsetSelecting, numberLine, numberOfAllCombination, saveFile, Zip, numberOfChar, null, extension);
                    }
                    

                    b = false;
                }
                else if (i == 3)
                {
                    b = false;
                }
                else if (i == 4)
                {
                    b = false;
                }
                else if (i == 5)
                {
                    b = false;
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

        }
               

    }
}
