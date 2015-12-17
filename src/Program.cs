namespace crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Parameter run = new Parameter();
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
