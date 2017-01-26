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

using System;
using Crisis.Ionic.Zip;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

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

		/// <summary>
		/// Startblocks the pattern.
		/// </summary>
		/// <returns>The pattern.</returns>
		/// <param name="_s">S.</param>
		/// <param name="charsetSelecting">Charset selecting.</param>
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

		/// <summary>
		/// Ends the pattern.
		/// </summary>
		/// <returns>The pattern.</returns>
		/// <param name="_e">E.</param>
		/// <param name="numberOfChar">Number of char.</param>
		/// <param name="charsetSelecting">Charset selecting.</param>
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

		/// <summary>
		/// Hour this instance.
		/// </summary>
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
        /// Settings up file.
        /// </summary>
        /// <param name="pathBackUpFiles">Path back up files.</param>
        /// <param name="extension">Extension.</param>

	
        public void Setting_UpFile(string pathBackUpFiles, string extension)
        {

            bool b = true;


            while (b)
            {
                try
                {
                    if (!Directory.Exists(pathBackUpFiles))
                    {
                        pathBackUpFiles = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + root + "crisis";
                        System.IO.Directory.CreateDirectory(pathBackUpFiles);
                    }
                    else if (File.Exists(pathBackUpFiles + root + "wordlist_" + numberFile + ".txt") | File.Exists(pathBackUpFiles + root + "wordlist_" + numberFile + ".zip"))
                    {
                        numberFile++;
                    }
                    else if (!Directory.Exists(pathBackUpFiles + root + "wordlist_" + numberFile + ".txt"))
                    {
                        workFile = new StreamWriter(pathBackUpFiles + root + "wordlist_" + numberFile + ".txt");
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

		/// <summary>
		/// Removes the duplicate.
		/// </summary>
		/// <returns>The duplicate.</returns>
		/// <param name="charsetSelecting">Charset selecting.</param>
        internal static List<string> RemoveDuplicate(List<string> charsetSelecting)
        {
            // Get distinct elements and convert into a list again.
            try
            {
                List<string> distinct = charsetSelecting.Distinct().ToList();
                charsetSelecting.Clear();
                charsetSelecting = distinct.Distinct().ToList();

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
            }

            return charsetSelecting;
        }

		/// <summary>
		/// Zipper the specified zip and pathBackUpFiles.
		/// </summary>
		/// <param name="zip">If set to <c>true</c> zip.</param>
		/// <param name="pathBackUpFiles">Path back up files.</param>
        internal string Zipper(bool zip, string pathBackUpFiles)
        {
            try
            {
                if (zip)
                {
                    string[] compress = new string[] { pathBackUpFiles + root + "wordlist_" + numberFile + ".txt" };

                    using (ZipFile zipFile = new ZipFile())
                    {
                        zipFile.AddFiles(compress, pathBackUpFiles + root + "wordlist_" + numberFile);
                        zipFile.Save(pathBackUpFiles + root + "wordlist_" + numberFile + ".zip");
                    }

                    System.IO.File.Delete(pathBackUpFiles + root + "wordlist_" + numberFile + ".txt");

                    return ".zip";
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
            }


            return ".txt";
        }

        internal void GenerateOut(string pathBackUpFiles, string extension)
        {
            string[] locate = new string[] { " Generating output at" + Hour() + " : " + pathBackUpFiles + root + "wordlist_" + numberFile + extension };
            Console.WriteLine(locate[0].ToString());
        }

		/// <summary>
		/// Doubles the capacity list.
		/// </summary>
		/// <returns>The capacity list.</returns>
		/// <param name="charsetSelecting">Charset selecting.</param>
		/// <param name="numberOfChar">Number of char.</param>
        internal List<string> DoubleCapacityList(List<string> charsetSelecting, int numberOfChar)
        {
            try
            {
                if (numberOfChar > charsetSelecting.Count)
                {
                    while (numberOfChar > charsetSelecting.Count)
                    {
                        int x = charsetSelecting.Count;

                        for (int i = 0; i < x; i++)
                        {
                            charsetSelecting.Add(charsetSelecting[i]);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
            }

            return charsetSelecting;
        }

		/// <summary>
		/// Mixs the order list.
		/// </summary>
		/// <returns>The order list.</returns>
		/// <param name="charsetSelecting">Charset selecting.</param>
        internal static List<string> MixOrderList(List<string> charsetSelecting)
        {            
            List<string> shuffled_list = new List<string>();
            List<string> tmp = new List<string>();

            for (int i = 0; i < charsetSelecting.Count; i++)
            {
                tmp.Add(Combinatorics.Randomizer.Aleatory(charsetSelecting, 1));
                shuffled_list = tmp.Distinct().ToList();

                if (charsetSelecting.Count > shuffled_list.Count)
                {
                    i--;
                }
            }

            tmp = null;
            return shuffled_list;
        }
		/// <summary>
		/// This function read file txt.
		/// </summary>
		/// <returns>The file text.</returns>
		/// <param name="charsetName">Charset name.</param>
		/// <param name="charsetSelecting">Charset selecting.</param>

        public static List<string> ReadFileTxt(string charsetName, List<string> charsetSelecting)
        {
            try
            {
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.Write("\n");
				Console.Write(" [+] ");
				Console.ResetColor();
				Console.Write("Reading file text");
				Console.Write("\n");
				charsetSelecting.Add(System.IO.File.ReadAllText(charsetName.ToString()));
            }
            catch (OutOfMemoryException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n The file is too large to be stored in RAM !");
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
            }

            return charsetSelecting;
        }

    } //End class
}// End namespace

