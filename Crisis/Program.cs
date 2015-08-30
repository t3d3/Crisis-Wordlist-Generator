using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Menu run = new Menu();
                run.Navigation();                
            } else
            {
                Command run = new Command();

                if (args[1] == "-h" | args[1] == "--help")
                {
                    run.HelpArg(args);
                }
                if (args[1] == "-i" | args[1] == "--interactive")
                {
                    run.InteractiveArg(args);
                }
                if (args[1] =="--wl" | args[1] == "--wordlist-list")
                {
                    run.WordlistHelpArg(args);
                }

                for (int i = 0; i <args.Length; i++)
                {


                    if (args[1] == "e" | args[1] =="enumeration")
                    {
                        run.EnumerationArg(args);
                    }

                    if (args[i] == "-l" | args[i] == "--lenght")
                    {
                        run.LenghtArg(args);
                    }
                    if (args[i] == "-r" | args[i] =="--random")
                    {
                        run.RandomArg(args);
                    }


                    if (args[i] == "-w" | args[i] == "--wordlist")
                    {
                        run.WordlistArg(args);
                    }

                    if (args[i] =="-f" | args[i] == "file")
                    {
                        run.FilesArg(args);
                    }

                }
            }


			
        }
    }
}
