using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Crisis_Wordlist_Generator
{
    public class Generate : Combination
    {

        StreamWriter file;
        internal int numberLine = 1;
        private char numberLineAsk;
       
        private string infoOnNumber;
        private string[] locate;

        private char typesOfGeneration;

        public char TypesOfGeneration
        {
            get { return typesOfGeneration; }
            set { typesOfGeneration = value; }
        }

        private char saveFile;

        public char SaveFile
        {
            get { return saveFile; }
            set { saveFile = value; }
        }


        private string saveCharset = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/output-dico/charset";
        private string saveWordlist= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/output-dico/wordlist";

        internal int numberFile = 1;       
       
        
        public Generate()
        {
			
		}
		
        public void PleaseWait()
        {
            Console.Clear();
            Console.WriteLine("\nPlease wait [|]" + "\n" + infoOnNumber);
            if (locate != null) Console.WriteLine(locate[0].ToString());
            System.Threading.Thread.Sleep(7);
            Console.Clear();
            Console.WriteLine("\nPlease wait [/]" + "\n" + infoOnNumber);
            if (locate != null) Console.WriteLine(locate[0].ToString());
            System.Threading.Thread.Sleep(7);
            Console.Clear();
            Console.WriteLine("\nPlease wait [+]" + "\n" + infoOnNumber);
            if (locate != null) Console.WriteLine(locate[0].ToString());
            System.Threading.Thread.Sleep(7);
            Console.Clear();
            Console.WriteLine("\nPlease wait [\\]" + "\n" + infoOnNumber);
            if (locate != null) Console.WriteLine(locate[0].ToString());
            System.Threading.Thread.Sleep(7);
        }

        private void setting_UpFile()
        {
            bool b = true;
            if (TypesOfGeneration == '1')
            {
                while (b)
                {
                    if (!Directory.Exists(saveCharset))
                    {
                        System.IO.Directory.CreateDirectory(saveCharset);
                    }
                    else if (File.Exists(saveCharset + @"/charset_" + numberFile + ".lst"))
                    {
                        numberFile++;
                    }
                    else if (!Directory.Exists(saveCharset + @"/charset_" + numberFile + ".lst"))
                    {
                        file = new StreamWriter(saveCharset + @"/charset_" + numberFile + ".lst");                        
                        b = false;
                    }
                   
                } //End while
            }
            else
            {
                while (b)
                {
                    if (!Directory.Exists(saveCharset))
                    {
                        System.IO.Directory.CreateDirectory(saveCharset);
                    }
                    else if (File.Exists(saveCharset + @"/wordlist_" + numberFile + ".lst"))
                    {
                        numberFile++;
                    }
                    else
                    {
                        file = new StreamWriter(saveCharset + @"/wordlist_" +""+ numberFile +"" +".lst");
                        b = false;
                    }

                }//End while
            }

        }//End Fonction




        public void Charset()
        {
            Console.Clear();
            Console.WriteLine("Please wait, this may take time (over 5 minutes)");

            if (SaveFile == '1')
            {
                var generate = CombinationCharset(CharsetSelecting, NumberOfChar, CharsetSelecting.Count - NumberOfChar);
                setting_UpFile();

                foreach (var item in generate)
                {
                    if (numberLine > 1000)
                    {
                        file.Flush();
                        file.Close();
                        locate = new string[] { "\nYour file has been saved => " + saveCharset.ToString() + @"/charset_" + numberFile + ".lst" };
                        setting_UpFile();
                        numberLine = 0;
                    }                   
                    else if (generate.Count == numberLine)
                    {
                        infoOnNumber = generate.Count + " combination will be generated with " + numberLine + " line in a file";
                        if (TypesOfGeneration == '1')
                        {
                            file.WriteLine("charset" +  numberLine++ +  " = [" + item.ToString() + "]");
                        }
                        else
                        {
                            file.WriteLine(item.ToString());
                        }

                        locate = new string[] { "\nYour file has been saved => " + saveCharset.ToString() + @"/charset_" + numberFile + ".lst" };
                        PleaseWait();
                        file.Close();
                    }
                    else if (generate.Count > numberLine)
                    {
                        infoOnNumber = generate.Count + " combination will be generated with " + numberLine + " line in a file";
                        if (TypesOfGeneration == '1')
                        {
                            file.WriteLine("charset" +  numberLine++ +  " = [" + item.ToString() + "]");
                        }
                        else
                        {
                            file.WriteLine(item.ToString());
                            numberLine++;
                        }
                        PleaseWait();
                    }
                    else
                    {
                        file.Close();
                    }

                } // End foreach
                
                if (TypesOfGeneration == '1')
                {
                    Console.WriteLine("\nCrunch commande example :\ncrunch " + NumberOfChar + " " + NumberOfChar + " -f charset_" + numberFile + ".lst charset1 -s " + generate[0]);
                }

            }
            else
            {
                var generate = CombinationCharset(CharsetSelecting, NumberOfChar, CharsetSelecting.Count - NumberOfChar);

                if (TypesOfGeneration == '1')
                {
                    generate.ForEach(x => Console.WriteLine("charset" + numberLine++ + " = [" + x.ToString() + "]"));
                }
                else if (TypesOfGeneration == '2')
                {
                    generate.ForEach(x => Console.WriteLine(x.ToString()));
                }

                numberLine = 0;
            }//End saveFile

        }  //End fonction

        public void Wordlist()
        {
            int cpt = 0;
            double numberCombination = Math.Pow(NumberOfChar, CharsetSelecting.Count);
            if (SaveFile == '1')
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
                            Console.Write("\nHow do you line : ");
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

                while (cpt < numberCombination)
                {
                    if (result.Count > numberLine - 1 || result.Count + cpt >= numberCombination)
                    {
                        setting_UpFile();

                        foreach (var item in result)
                        {

                            file.WriteLine(item);
                            locate = new string[] { "\nYour file has been saved => " + saveWordlist.ToString() + "/wordlist_" + numberFile + ".lst" };
                        }

                        file.Flush();
                        file.Close();

                        result.Clear();
                    }
                    else
                    {
                        PleaseWait();
                        result.Add(CombinationRamdon());
                        cpt++;

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


    } //End Class
} // End Namespace
