using System;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace crisis
{
    /// <summary>
    /// An ASCII progress bar
    /// </summary>
    public class ProgressBar
    {
        /// <summary>
        /// Draw a progress bar at the current cursor position.
        /// Be careful not to Console.WriteLine or anything whilst using this to show progress!
        /// </summary>
        /// <param name="progress">The position of the bar</param>
        /// <param name="total">The amount it counts</param>
        
       
        public static void drawTextProgressBar(int progress, int total)
        {
                      
           Console.WriteLine(" \nPlease wait \n\t\t");                       
            //draw empty progress bar
            float onechunk = 50.0f / total;

            //draw filled part
            int position = 1;
            for (int i = 0; i < onechunk * progress; i++)
            {               
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw unfilled part
            for (int i = position; i <= 51; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }           
             
            //draw totals
            Console.CursorLeft = 55;
            Console.BackgroundColor = ConsoleColor.Black;            
            Console.Write(progress.ToString() + " on " + total.ToString()+"    "); //blanks at the end remove any excess
            System.Threading.Thread.Sleep(1);
            Console.Clear();           
     
            
        }

    }
}