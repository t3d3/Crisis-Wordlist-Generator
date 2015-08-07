using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Crisis_Wordlist_Generator
{
    public class MainConsole : Generate 
    {
        private int sizeCharset;
        private char typesOFProcedure;
        private  char saveFileAsk;

        public MainConsole()
        {
            
             
        }


        public void Parameter()
        {
            bool b = false;

            Console.WriteLine("\n 1)\t Charset Generator for Crunch without repetition");
            Console.WriteLine(" 2)\t Combination without repetition");
            Console.WriteLine(" 3)\t Random with repetition\n\n ");


            while (b == false)
            {
                try
                {
                    Console.Write(" Type the number corresponding to the menu : ");
                    b = char.TryParse(Console.ReadLine(), out typesOFProcedure);

                    if (typesOFProcedure == '1' | typesOFProcedure == '2' | typesOFProcedure == '3')
                    {
                        b = true;
                        TypesOfGeneration += typesOFProcedure;
                    }
                    else
                    {
                        b = false;
                    }

                }
                catch (FormatException)
                {
                    b = false;
                }
            }

            b = false;

            while (b == false)
            {
                Console.Write("\n What is the size of your charset : ");

                try
                {
                    b = int.TryParse(Console.ReadLine(), out sizeCharset);
                    NumberOfChar = +sizeCharset;

                    if (sizeCharset < 3 | sizeCharset > 128)
                    {
                        Console.WriteLine(" Type a number between 3 and 128 please !");
                        b = false;
                    }
                    else if (typesOFProcedure == '1' | typesOFProcedure == '2')
                    {
                        if (sizeCharset > CharsetSelecting.Count)
                        {
                            Console.WriteLine(" The number of character is too large to generate\n a caratère chain without rehearsal");
                            b = false;
                        }
                        else if (sizeCharset == CharsetSelecting.Count)
                        {

                            Console.WriteLine(" The number of characters must be smaller for combinations without repetition");
                            b = false;
                        }

                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine(" Type the size of your charset ");
                    b = false;
                }
            }

            Console.WriteLine("\n 1) Yes");
            Console.WriteLine(" 2) No\n");

            b = false;

            while (b == false)
            {
                try
                {
                    Console.Write(" Do you want to save the output to a file : ");

                    b = char.TryParse(Console.ReadLine(), out saveFileAsk);

                    if (saveFileAsk == '1' | saveFileAsk == '2')
                    {
                        b = true;
                        SaveFile += saveFileAsk;
                    }
                    else
                    {
                        b = false;
                    }

                }
                catch (FormatException)
                {
                    b = false;
                }
            }

        }// End Fonction

        public void Navigation ()
		{
			Display ();
			Parameter ();

			if (TypesOfGeneration == '1' || TypesOfGeneration == '2') {
				Charset ();
			} else {
				Wordlist ();
				Console.ReadKey ();
			}
            
        } // End Fonction

    } // End Class
} 
