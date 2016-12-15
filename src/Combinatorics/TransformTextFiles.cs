using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crisis.Tools;
using Crisis.Charset;
using Crisis.Graphic;

namespace Crisis.Combinatorics
{
    class TransformTextFiles
    {
        public TransformTextFiles()
        {
            
        }

        internal string ConverterInLeetSpeak(string _word)
        {
            string wordLeet = null;
            for (int i = 0; i < _word.Length; i++)
            {
                wordLeet += FoundLetterLeet(_word[i]);
            }

            return wordLeet;
        }

        private char FoundLetterLeet(char _letter)
        {
            char letterLeet = _letter;

            switch (Char.ToLower(letterLeet))
            {
                case 'a':
                    letterLeet = '4';
                    break;
                case 'b':
                    letterLeet = '8';
                    break;
                case 'e':
                    letterLeet = '3';
                    break;
                case 'l':
                    letterLeet = '1';
                    break;
                case 'o':
                    letterLeet = '0';
                    break;
                case 's':
                    letterLeet = '5';
                    break;
                case 't':
                    letterLeet = '7';
                    break;
                case 'g':
                    letterLeet = '6';
                    break;
                case 'z':
                    letterLeet = '2';
                    break;
            }

            return letterLeet;
        }



       



        private string ConverterInUppercaseLowercase(string _word)
        {
            string wordLeet = null;
            for (int i = 0; i < _word.Length; i++)
            {
                wordLeet += FoundLetterUppercaseLowercase(_word[i]);
            }

            return wordLeet;
        }

        private char FoundLetterUppercaseLowercase(char _letter)
        {                        
            Default charset = new Charset.Default();

            for (int i = 0; i < charset.Lalpha.Count; i++)
            {
                if (charset.Lalpha[i] == _letter.ToString())
                {
                    _letter = Convert.ToChar(charset.Ualpha[i]);
                }
                else if (charset.Ualpha[i] == _letter.ToString())
                {
                    _letter = Convert.ToChar(charset.Lalpha[i]);
                }
            }

            return _letter;
        }

        public void L33tSpeek(List<string> charsetSelecting, string pathBackupFiles, string extension, bool zip)
        {
            Interface.PleaseWait();
            Utility make = new Utility();

            make.Setting_UpFile(pathBackupFiles, extension);

            foreach (var item in charsetSelecting)
            {
                make.WorkFile.WriteLine(ConverterInLeetSpeak(item.ToString()));                
            }

            make.WorkFile.Close();

            extension = make.Zipper(zip, pathBackupFiles);
            make.GenerateOut(pathBackupFiles, extension);

        } // End Function 

        

        public void LowercaseToUppercas(List<string> charsetSelecting, string pathBackupFiles, string extension, bool zip)
        {
            Interface.PleaseWait();
            Utility make = new Utility();
            make.Setting_UpFile(pathBackupFiles, extension);

            foreach (var item in charsetSelecting)
            {
                make.WorkFile.WriteLine(item.ToString().ToUpper());                
            }

            make.WorkFile.Close();
            extension = make.Zipper(zip, pathBackupFiles);
            make.GenerateOut(pathBackupFiles, extension);
           
        } // End Function 

        public void UppercaseToLowercase(List<string> charsetSelecting, string pathBackupFiles, string extension, bool zip)
        {
            Interface.PleaseWait();
            Utility make = new Utility();
            make.Setting_UpFile(pathBackupFiles,extension);

            foreach (var item in charsetSelecting)
            {
                make.WorkFile.WriteLine(item.ToString().ToLower());
                
            }

            make.WorkFile.Close();

            extension = make.Zipper(zip, pathBackupFiles);
            make.GenerateOut(pathBackupFiles, extension);
            
        } // End Function

        public void AutoUppercaseLowercase(List<string> charsetSelecting, string pathBackupFiles, string extension, bool zip)
        {
            Interface.PleaseWait();
            Utility make = new Utility();

            make.Setting_UpFile(pathBackupFiles, extension);

            foreach (var item in charsetSelecting)
            {
                make.WorkFile.WriteLine(ConverterInUppercaseLowercase(item.ToString()));                
            }

            make.WorkFile.Close();
            extension = make.Zipper(zip, pathBackupFiles);
            make.GenerateOut(pathBackupFiles, extension);
           
        } // End Function 
    }
}
