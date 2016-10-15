using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crisis.Graphic.Menu;
using Crisis.Tools;
using Crisis.Graphic;
using System.Resources;

namespace Crisis
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.InputEncoding = System.Text.Encoding.UTF8;            
            Console.SetWindowSize(100, 25);

            Utility os = new Utility();
            os.Root();

            if (args.Length == 0)
            {
                Interface category = new Interface();
                ResourceManager lang = category.Lang_Text();
                new Run(lang);                
            }
            else
            {
                new Run(args);
            }
        }
    }
}
