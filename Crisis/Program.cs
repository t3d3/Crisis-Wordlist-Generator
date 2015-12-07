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
            } 
            else
            {
                Command run = new Command();

                run.HelpArg(args);
                run.OptionsArg(args);
                run.ParameterArgs(args);
                run.CombinationArg(args);
            }

        }
    }
}
