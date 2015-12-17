using System;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
namespace crisis
{
    public class Generate : Combination
    {
        internal int numberLine = 1;
        private char numberLineAsk;
        private string infoOnNumber;
        private string[] locate;
        internal int typesOfGeneration;
        private FilesNameDirectory make = null;
        
        private int saveFile;

        public int SaveFile
        {
            get { return saveFile; }
            set { saveFile = value; }
        }

        public Generate(int _saveFile)
        {
            this.SaveFile += _saveFile;              
        }
        
        public Generate( )
        {
              
        }
        
        public void PleaseWait()
        {
            Console.WriteLine(infoOnNumber);
            if (locate != null)
                Console.WriteLine(locate [0].ToString());
        }

        public void CharsetCrunch()
        {
            Console.Clear();
            Console.WriteLine("Please wait, this may take time (over 5 minutes)");
            make = new FilesNameDirectory(typesOfGeneration);            
            var generate = CombinationCharset(Charset.CharsetSelecting, NumberOfChar, Charset.CharsetSelecting.Count - NumberOfChar);
            int i = 0;
            
            if (saveFile == 1)
            {
                make.Setting_UpFile();

                foreach (var item in generate)
                {
                    if (numberLine > 1000)
                    { 
                        locate = new string[] { "\nYour file has been saved => " + make.FilePath.ToString() + @"/charset_" + make.NumberFile + ".txt" };
                        make.Setting_UpFile();
                        numberLine = 0;
                    } else if (generate.Count == numberLine)
                    {
                        infoOnNumber = generate.Count + " combination will be generated with " + numberLine + " line in a file";
                        if (typesOfGeneration == 0)
                        {
                            make.WorkFile.WriteLine("charset" + numberLine++ + " = [" + item.ToString() + "]");
                        } else
                        {
                            make.WorkFile.WriteLine(item.ToString());
                        }

                       locate = new string[] { "\nYour file has been saved => " + make.FilePath[typesOfGeneration].ToString() + @"/charset_" + make.NumberFile + ".txt" };
                        PleaseWait();                        
                        ProgressBar.drawTextProgressBar(i++, generate.Count);
                        Console.Clear();
                        make.WorkFile.Close();
                    } else if (generate.Count > numberLine)
                    {
                        infoOnNumber = generate.Count + " combination will be generated with " + numberLine + " line in a file";
                        if (typesOfGeneration == 0)
                        {
                            make.WorkFile.WriteLine("charset" + numberLine++ + " = [" + item.ToString() + "]");
                        } else
                        {
                            make.WorkFile.WriteLine(item.ToString());
                            numberLine++;
                        }
                         Console.Clear();
                        ProgressBar.drawTextProgressBar(i++, generate.Count);
                    } 
                    else
                    {
                        make.WorkFile.Close();
                    }

                } // End foreach

                if (typesOfGeneration == 0)
                {
                    Console.WriteLine("\nCrunch commande example :\ncrunch " + NumberOfChar + " " + NumberOfChar + " -f charset_" + make.NumberFile + ".lst charset1 -i -s " + generate [0]);
                }

            } else 
            {

                if (typesOfGeneration == 0)
                {
                    generate.ForEach(x => Console.WriteLine("charset" + numberLine++ + " = [" + x.ToString() + "]"));
                } else if (typesOfGeneration == 1)
                {
                    generate.ForEach(x => Console.WriteLine(x.ToString()));
                }

                numberLine = 0;
            }//End saveFile
        }
        //End fonction
        public void Wordlist()
        {
            int cpt = 0;
            double numberCombination = Math.Pow(NumberOfChar, Charset.CharsetSelecting.Count);

            make = new FilesNameDirectory(typesOfGeneration);

            if (saveFile == 1)
            {                                
                List<string> result = new List<string> { };
                bool b = false;
                bool b1 = false;

                while (b == false)
                {
                    Console.Write(" Want to choose the number of line in a file (Default 10000) ?  [ y / n ] : ");
                    try
                    {
                        b = char.TryParse(Console.ReadLine(), out numberLineAsk);

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(" Error in saissis of information ");
                        b = false;
                    }
                }

                while (b1 == false)
                {
                    try
                    {
                        if (numberLineAsk == 'y')
                        {
                            Console.Write("\n How do you line : ");
                            b1 = int.TryParse(Console.ReadLine(), out numberLine);

                            if (numberLine < 128)
                            {
                                Console.WriteLine(" Type a number greater than 128 please !");
                                b1 = false;
                            }
                        }
                        else
                        {
                            numberLine = 10000;
                            b1 = true;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(" Error in saissis of information ");
                        b = false;
                    }
                }

                while (b)
                {
                    if (numberLine > numberCombination)
                    {
                        numberLine /= 2;
                        b = true;
                    }
                    else
                    {
                        b = false;
                    }
                }

                infoOnNumber = numberCombination + " combination will be generated with " + numberLine + " line in a file\n";
                int cptProgressBar = 0;
                
                while (cpt < numberCombination)
                {                  
                    
                    if (result.Count > numberLine - 1 || result.Count + cpt >= numberCombination)
                    {
                        make.Setting_UpFile();                       
                        cptProgressBar = 0;
                        foreach (var item in result)
                        {
                            make.WorkFile.WriteLine(item);
                            locate = new string[] { "\nYour file has been saved => " + make.FilePath[typesOfGeneration].ToString() + "/wordlist_" + make.NumberFile + ".txt\n" };                          
                                                                                        
                        }

                        make.WorkFile.Flush();
                        make.WorkFile.Close();
                        result.Clear();
                    }
                    else
                    {   
                        PleaseWait(); 
                        ProgressBar.drawTextProgressBar(cptProgressBar,numberLine);                                           
                        result.Add(CombinationRamdon());                         
                        cpt++;
                        cptProgressBar++;                      
                    }
                }
            }
            else
            {
                while (cpt < numberCombination)
                {
                    Console.WriteLine(CombinationRamdon());
                    cpt++;
                }
            }                
        } // End Fonction
       
        public void L33tSpeek()
        {
            if (saveFile == 1)
            {
                make.Setting_UpFile();
                locate = new string[] { "\nYour file has been saved => " + make.FilePath.ToString() + @"/dico1337_" + make.NumberFile + ".lst" };

                foreach (var item in Charset.CharsetSelecting)
                {
                    PleaseWait();
                    make.WorkFile.WriteLine(ConverterInLeetSpeak(item.ToString()));
                }

                PleaseWait();
                make.WorkFile.Close();
            } 
            else
            {
                Charset.CharsetSelecting.ForEach(x => Console.WriteLine(ConverterInLeetSpeak(x.ToString())));
            }
        } // End Fonction      

    } //End Class
} // End Namespace
