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
using Crisis.Ionic.Zip;
using System.IO;
using System.Collections.Generic;
using System.Numerics;





namespace Crisis.Tools
{
    public class Utility
    {

        private static BigInteger numberFile;
        private static string root;


        StreamWriter workFile;

        public StreamWriter WorkFile
        {
            get { return workFile; }
            set { workFile = value; }
        }

        public Utility()
        {

        }

        internal List<string> StartblockPattern(string _s, List<string> charsetSelecting)
        {
            try
            {
                for (int i = 0; i < charsetSelecting.Count; i++)
                {
                    for (int x = 0; x < _s.Length; x++)
                    {
                        if (charsetSelecting[i] == _s[x].ToString())
                        {
                            charsetSelecting.RemoveAt(i);
                        }
                    }                    
                }
                
                for (int i = 0; i < _s.Length; i++)
                {
                    charsetSelecting.Insert(i, _s[i].ToString());
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n {0} \n", e.Message);
                Console.ResetColor();
            }

            return charsetSelecting;
        }

        internal List<string> EndPattern(string _e, byte numberOfChar, List<string> charsetSelecting)
        {
            try
            {
                for (int i = 0; i < charsetSelecting.Count; i++)
                {
                    for (int x = 0; x < _e.Length; x++)
                    {
                        if (charsetSelecting[i] == _e[x].ToString())
                        {
                            charsetSelecting.RemoveAt(i);
                        }
                    }
                }

                for (int i = 0; i < _e.Length; i++)
                {
                    charsetSelecting.Insert((numberOfChar - _e.Length) + i, _e[i].ToString());
                }

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n {0} \n", e.Message);
                Console.ResetColor();
            }
            return charsetSelecting;
        }

        internal string Hour()
        {
            DateTime obj = DateTime.Now;
            string input = obj.ToString().Substring(10);

            return input;
        }

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

        public void Root() // rename  function in root
        {
            if (OsDetect() == true)
            {
                root = "/";
            }
            else
            {
                root = @"\";
            }                     
        }

        /// <summary>
        /// Create the files on computer
        /// </summary>
        /// <param name="extension"></param>

        public void Setting_UpFile( string filePath,string extension)
        {

            bool b = true;
            

            while (b)
            {
                try
                {
                    if (!Directory.Exists(filePath))
                    {
                        filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + root + "crisis";
                        System.IO.Directory.CreateDirectory(filePath);
                    }
                    else if (File.Exists(filePath + root + "wordlist_" + numberFile + extension))
                    {
                        numberFile++;
                    }
                    else if (!Directory.Exists( filePath + root + "wordlist_" + numberFile + ".txt"))
                    {
                        workFile = new StreamWriter(filePath + root + "wordlist_" + numberFile + ".txt");
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

        internal void Zipper(bool _Zip)
        {
            if (_Zip)
            {
                string[] compress = new string[] { Environment.SpecialFolder.DesktopDirectory + root + "crisis" + root + "wordlist_" + numberFile  +".txt" };

                using (ZipFile zipFile = new ZipFile())
                {
                    zipFile.AddFiles(compress, Environment.SpecialFolder.DesktopDirectory + root + "crisis" + root + "wordlist_" + numberFile);
                    zipFile.Save(Environment.SpecialFolder.DesktopDirectory + root + "crisis" + root + "wordlist_" + numberFile + ".zip");
                }

                System.IO.File.Delete(Environment.SpecialFolder.DesktopDirectory + root + "crisis" + root + "wordlist_" + numberFile + ".txt");
            }
        }

        internal void GenerateOut( string extension)
        {
            string[] locate = new string[] { " Generating output at" + Hour() + " : " + Environment.SpecialFolder.DesktopDirectory + root + "crisis" + root + "wordlist_" + numberFile + extension };
            Console.WriteLine(locate[0].ToString());
        }



    } //End class
}// End namespace

