using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameEngine
{
    static class Program
    {
        //6static FastLoop _fastLoop = new FastLoop(GameLoop);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        /* static void GameLoop(double elapsedTime)
        {
            //System.Console.WriteLine(elapsedTime); 
        }
         */
    }
}
