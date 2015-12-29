//
//  FilesNameDirectory.cs
//
//  Author:
//       root <${AuthorEmail}>
//
//  Copyright (c) 2015 root
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
using System.IO;

namespace crisis
{
    public class FilesNameDirectory
    {
        private string[] filePath = new string[10];

        public string[] FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }

        private string[] fileName = new string[10];

        public string[] FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }        

        private int? indiceOfProcess;
        
        StreamWriter workFile;
        public StreamWriter WorkFile
        {
            get { return workFile; }
            set { workFile = value; }
        }

        internal int numberFile = 1;

        public int NumberFile
        {
            get { return numberFile; }
            set { numberFile = value; }
        }

        public FilesNameDirectory()
        {                   
        }

        public FilesNameDirectory(int _indice)
        {
            this.indiceOfProcess = _indice;
        }

         //A function that determines whether it is a Windows(false) or Linux (true) system
        public bool OsDetect() 
        {
            bool system = true;

            OperatingSystem os = Environment.OSVersion;
            PlatformID pid = os.Platform;
            switch (pid)
            {
                case PlatformID.Win32NT:
                    case PlatformID.Win32S:
                    case PlatformID.Win32Windows:
                    case PlatformID.WinCE:

                    system = false;                   
                    break;

                    case PlatformID.Unix:

                    system = true;
                    break;
                    default:
                    Console.WriteLine("ERROR: This platform identifier is invalid.");
                    break;
            }
            return system;
        }

        public void FilesPathDirectory()
        {
            if (OsDetect() == true)
            {
                filePath[0] = null;
                filePath[1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/crunch";
                filePath [2] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/enumeration";
                filePath [3] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/random";
                filePath [4] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/leet_Speak";
                fileName [0] = null;
                fileName [1] = @"/charset_";
                fileName [2] = @"/wordlist_";
                fileName [3] = @"/wordlist_";
                fileName [4] = @"/dico1337_";
            } 
            else
            {
                filePath [0] = null;
                filePath [1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\charset";
                filePath[2] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\enumeration";
                filePath[3] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\random";
                filePath [4] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\leet_Speak";
                fileName [0] = null;
                fileName [1] = @"\charset_";
                fileName [2] = @"\wordlist_";
                fileName [3] = @"\wordlist_";
                fileName [4] = @"\dico1337_";
            }
        }

        public void Setting_UpFile()
        {
            FilesPathDirectory();
            bool b = true;
            while (b)
            {
                try
                {
                    if (!Directory.Exists(filePath[(int)indiceOfProcess]))
                    {
                        System.IO.Directory.CreateDirectory(filePath[(int)indiceOfProcess]);
                    }
                    else if (File.Exists(filePath[(int)indiceOfProcess] + fileName[(int)indiceOfProcess] + numberFile + ".txt"))
                    {
                        numberFile++;
                    }
                    else if (!Directory.Exists(filePath[(int)indiceOfProcess] + fileName[(int)indiceOfProcess] + numberFile + ".txt"))
                    {
                        workFile = new StreamWriter(filePath[(int)indiceOfProcess] + fileName[(int)indiceOfProcess] + numberFile + ".txt");
                        b = false;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;                    
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();
                }                

            } //End while
        }  //End Fonction



    }  //End class
} // End namespace;

