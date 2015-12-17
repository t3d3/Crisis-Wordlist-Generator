using System;
using System.Collections.Generic;
namespace crisis
{
    public class Generate  
    {        
        
        private string infoOnNumber;
        private string[] locate;
                
        private FilesNameDirectory make = null;         

        public Generate()
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
            Algorithme algoEnume = new Algorithme();
            Console.Clear();
            Console.WriteLine("Please wait, this may take time (over 5 minutes)");
            make = new FilesNameDirectory(Parameter.TypesOfGeneration);
            var generate = algoEnume.CombinationCharset(Charset.CharsetSelecting, Parameter.NumberOfChar, Charset.CharsetSelecting.Count - Parameter.NumberOfChar);
            int i = 0;
            
            if (Parameter.SaveFile == 1)
            {
                make.Setting_UpFile();

                foreach (var item in generate)
                {
                    if (Parameter.NumberLine > 1000)
                    {
                        locate = new string[] { "\nYour file has been saved => " + make.FilePath.ToString() + @"/charset_" + make.NumberFile + ".txt" };

                        make.Setting_UpFile();
                        Parameter.NumberLine = 0;
                    }
                    else if (generate.Count == Parameter.NumberLine)
                    {
                        infoOnNumber = generate.Count + " combination will be generated with " + Parameter.NumberLine + " line in a file";
                        if (Parameter.TypesOfGeneration == 0)
                        {
                            make.WorkFile.WriteLine("charset" + Parameter.NumberLine++ + " = [" + item.ToString() + "]");
                        } else
                        {
                            make.WorkFile.WriteLine(item.ToString());
                        }

                        locate = new string[] { "\nYour file has been saved => " + make.FilePath[Parameter.TypesOfGeneration].ToString() + @"/charset_" + make.NumberFile + ".txt" };
                        PleaseWait();                        
                        ProgressBar.drawTextProgressBar(i++, generate.Count);
                        Console.Clear();
                        make.WorkFile.Close();
                    }
                    else if (generate.Count > Parameter.NumberLine)
                    {
                        infoOnNumber = generate.Count + " combination will be generated with " + Parameter.NumberLine + " line in a file";
                        if (Parameter.TypesOfGeneration == 0)
                        {
                            make.WorkFile.WriteLine("charset" + Parameter.NumberLine++ + " = [" + item.ToString() + "]");
                        } else
                        {
                            make.WorkFile.WriteLine(item.ToString());
                            Parameter.NumberLine++;
                        }
                         Console.Clear();
                        ProgressBar.drawTextProgressBar(i++, generate.Count);
                    } 
                    else
                    {
                        make.WorkFile.Close();
                    }

                } // End foreach

                if (Parameter.TypesOfGeneration == 0)
                {
                    Console.WriteLine("\nCrunch commande example :\ncrunch " + Parameter.NumberOfChar + " " + Parameter.NumberOfChar + " -f charset_" + make.NumberFile + ".lst charset1 -i -s " + generate[0]);
                }

            } else 
            {

                if (Parameter.TypesOfGeneration == 0)
                {
                    generate.ForEach(x => Console.WriteLine("charset" + Parameter.NumberLine++ + " = [" + x.ToString() + "]"));
                }
                else if (Parameter.TypesOfGeneration == 1)
                {
                    generate.ForEach(x => Console.WriteLine(x.ToString()));
                }

                Parameter.NumberLine = 0;
            }//End saveFile
        }
        //End fonction
        public void Wordlist()
        {            
            Algorithme algoRamdom = new Algorithme();
            
            int cpt = 0;

            make = new FilesNameDirectory(Parameter.TypesOfGeneration);

            if (Parameter.SaveFile == 1)
            {                                
                List<string> result = new List<string> { };
                

                infoOnNumber = Parameter.NumberCombination + " combination will be generated with " + Parameter.NumberLine + " line in a file\n";
                int cptProgressBar = 0;

                while (cpt < Parameter.NumberCombination)
                {                  
                    
                    if (result.Count > Parameter.NumberLine - 1 || result.Count + cpt >= Parameter.NumberCombination)
                    {
                        make.Setting_UpFile();                       
                        cptProgressBar = 0;
                        foreach (var item in result)
                        {
                            make.WorkFile.WriteLine(item);
                            locate = new string[] { "\nYour file has been saved => " + make.FilePath[Parameter.TypesOfGeneration].ToString() + make.FileName[Parameter.TypesOfGeneration] + make.NumberFile + ".txt\n" };                          
                                                                                        
                        }

                        make.WorkFile.Flush();
                        make.WorkFile.Close();
                        result.Clear();
                    }
                    else
                    {   
                        PleaseWait(); 
                        ProgressBar.drawTextProgressBar(cptProgressBar,Parameter.NumberLine);
                        result.Add(algoRamdom.CombinationRamdon());                         
                        cpt++;
                        cptProgressBar++;                      
                    }
                }
            }
            else
            {
                while (cpt < Parameter.NumberCombination)
                {
                    Console.WriteLine(algoRamdom.CombinationRamdon());
                    cpt++;
                }
            }                
        } // End Fonction
       
        public void L33tSpeek()
        {
            Algorithme algoLeetSpeak = new Algorithme();
            if (Parameter.SaveFile == 1)
            {
                make.Setting_UpFile();

                locate = new string[] { "\nYour file has been saved => " + make.FilePath[Parameter.TypesOfGeneration].ToString() + make.FileName[Parameter.TypesOfGeneration] + make.NumberFile + ".txt\n" };                          


                foreach (var item in Charset.CharsetSelecting)
                {
                    PleaseWait();
                    make.WorkFile.WriteLine(algoLeetSpeak.ConverterInLeetSpeak(item.ToString()));
                }

                PleaseWait();
                make.WorkFile.Close();
            } 
            else
            {
                Charset.CharsetSelecting.ForEach(x => Console.WriteLine(algoLeetSpeak.ConverterInLeetSpeak(x.ToString())));
            }
        } // End Fonction 
     

    } //End Class
} // End Namespace
