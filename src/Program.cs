using System;
using Plossum.CommandLine;

namespace crisis
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                MainMenu.Navigation();                  
            } 
            else
            {
                MainMenu obj1 = new MainMenu();
                obj1.start();
                Command run = new Command();
                
                //Help must be first
                run.HelpPrint(args);

                //Any options that work with a string must be the First to start
                //Toute les options qui travaille avec une string doit être les premieres à démarrer
                run.FunctionPattern(args);
                run.FunctionInverts(args);

                // All functions that work with values to change the strings to begin in second
                //Toutes les fonctions qui travaillent avec des valeurs pour modifier  les strings doivent commencer en deuxième

                run.FunctionOnNumberChar(args);
                run.FunctionSizeFilesTxt(args);                

                //The backup of the file and launch the calculations must always be last.
                //La sauvegarde du fichier et lancement des calculs doit toujours être en dernier.
                run.FunctionSaveFiles(args);
                run.FunctionNbLine(args);
                run.FunctionTypeOfProcedur(args);


               
            }

            Console.ReadKey();

        }
    }
}
