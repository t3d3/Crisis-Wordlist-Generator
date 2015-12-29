using System;
using System.Collections.Generic;
using System.Numerics;

namespace crisis
{
    public partial class Algorithme  
    { 
        private string[] locate;
        public string[] Locate
        {
            get { return locate; }
            set { locate = value; }
        }
                
        
        

        public void EnumerationPrint()
        {   
            BigInteger cpt = 0;
            Algorithme algoEnume = new Algorithme();
            make = new FilesNameDirectory(Parameter.TypesOfGeneration);

            int[] array = new int[Parameter.NumberOfChar - 1];
            for (int tmp = 0; tmp < Parameter.NumberOfChar - 1; tmp++)
            {
                array[tmp] = 0;
            }

            if (Parameter.SaveFile == 1)
            {
                make.Setting_UpFile();
                locate = new string[] { " Completed generating output : " + make.FilePath[Parameter.TypesOfGeneration].ToString() + make.FileName[Parameter.TypesOfGeneration] + make.NumberFile + ".txt" };
                Console.WriteLine(locate[0].ToString());
                BigInteger i =0;

                while (cpt + 20 < Statistical.NumberOfAllCombination)
                {

                    if (i > Parameter.NumberLine - 1 || cpt + 25 == Statistical.NumberOfAllCombination)
                    {
                        i = 0;
                        make.WorkFile.Close();
                        make.Setting_UpFile();                        
                        locate = new string[] { " Completed generating output : " + make.FilePath[Parameter.TypesOfGeneration].ToString() + make.FileName[Parameter.TypesOfGeneration] + make.NumberFile + ".txt" };
                        Console.WriteLine(locate[0].ToString());                        
                    }
                    else
                    {
                        if (Parameter.TypesOfGeneration == 1)
                        {
                            make.WorkFile.WriteLine("charset" + " = [" + algoEnume.Enumeration(array).ToString() + "]");
                        }
                        else
                        {
                            make.WorkFile.WriteLine(algoEnume.Enumeration(array).ToString());
                        }

                        i++;                                                                     
                    }

                    ++cpt; 
                }

                if (Parameter.TypesOfGeneration == 1)
                {
                    Console.WriteLine("\nCrunch commande example :\ncrunch " + Parameter.NumberOfChar + " " + Parameter.NumberOfChar + " -f charset_" + make.NumberFile + ".lst charset1 -i -s " + "abcdefgei");
                }
            }
            else
            {
                while (cpt < Statistical.NumberOfAllCombination)
                {
                    if (Parameter.TypesOfGeneration == 1)
                    {
                        Console.WriteLine("charset" + Parameter.NumberLine++ + " = [" + algoEnume.Enumeration(array).ToString() + "]");
                    }
                    else if (Parameter.TypesOfGeneration == 2)
                    {
                        Console.WriteLine(algoEnume.Enumeration(array));
                    }                    
                    cpt++;
                }
            }
        } // End Fonction

        public void RamdonPrint()
        {
            BigInteger cpt = 0;                     
            Algorithme algoRamdom = new Algorithme();
            make = new FilesNameDirectory(Parameter.TypesOfGeneration);

            if (Parameter.SaveFile == 1)
            {
                make.Setting_UpFile();
                locate = new string[] { " Completed generating output : " + make.FilePath[Parameter.TypesOfGeneration].ToString() + make.FileName[Parameter.TypesOfGeneration] + make.NumberFile + ".txt" };
                Console.WriteLine(locate[0].ToString());
                BigInteger i = 0;

                while (cpt + 20 < Statistical.NumberOfAllCombination)
                {

                    if (i > Parameter.NumberLine - 1 || cpt + 25 == Statistical.NumberOfAllCombination)
                    {
                        i = 0;
                        make.WorkFile.Close();
                        make.Setting_UpFile();                       
                        locate = new string[] { " Completed generating output : " + make.FilePath[Parameter.TypesOfGeneration].ToString() + make.FileName[Parameter.TypesOfGeneration] + make.NumberFile + ".txt" };
                        Console.WriteLine(locate[0].ToString());                       
                        
                    }
                    else
                    {
                        make.WorkFile.WriteLine(algoRamdom.CombinationRamdon());
                        ++i;                      
                    }

                    ++cpt;
                }
            }
            else
            {
                while (cpt < Statistical.NumberOfAllCombination)
                {
                    Console.WriteLine(algoRamdom.CombinationRamdon());
                    cpt++;
                }
            }                
        } // End Fonction
       
        public void L33tSpeek()
        {
            Algorithme algoLeetSpeak = new Algorithme();
            make = new FilesNameDirectory(Parameter.TypesOfGeneration);

            if (Parameter.SaveFile == 1)
            {
                make.Setting_UpFile();                

                foreach (var item in Charset.CharsetSelecting)
                {                   
                    make.WorkFile.WriteLine(algoLeetSpeak.ConverterInLeetSpeak(item.ToString()));
                }

                locate = new string[] { " Completed generating output : " + make.FilePath[Parameter.TypesOfGeneration].ToString() + make.FileName[Parameter.TypesOfGeneration] + make.NumberFile + ".txt" };
                Console.WriteLine(locate[0].ToString());
                make.WorkFile.Close();
            } 
            else
            {
                Charset.CharsetSelecting.ForEach(x => Console.WriteLine(algoLeetSpeak.ConverterInLeetSpeak(x.ToString())));
            }
        } // End Fonction 
     

    } //End Class
} // End Namespace
