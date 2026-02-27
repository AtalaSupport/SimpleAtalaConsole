using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Atalasoft.Imaging;
using System.IO;
using System.Drawing;
using Atalasoft.Imaging.Codec;

namespace SimpleAtalaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SimpleAtalaConsole Starting...");
            string imgPath = GetWorkingDir();
            string inFile = imgPath + "_CUSTFILES\\Tiger.jpg";
            Console.WriteLine("  inFile: " + inFile);
            string outFile = imgPath + "out.png";
            Console.WriteLine("  outFile: " + outFile);

            Console.WriteLine("BEGIN Processing");


            AtalaImage img = new AtalaImage(inFile);
            Console.WriteLine("  Hi, I have an AtalaImage...");
            Console.WriteLine("    Size: " + img.Size.ToString());
            Console.WriteLine("    PixelFormat: " + img.PixelFormat.ToString());
            img.Dispose();

            Console.WriteLine("END Processing");
            
            Console.WriteLine("SimpleAtalaConsole finished... press RETURN to exit");
            Console.ReadLine();
        }


        /// <summary>
        /// Convenience method to get the root directory of the project - really only useful for debugging
        /// </summary>
        /// <returns></returns>
        private static string GetWorkingDir()
        {
            string cwd = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("cwd is '{0}'", cwd);

            if (cwd.EndsWith("\\bin\\Debug"))
            {
                cwd = cwd.Replace("\\bin\\Debug", "\\..\\..\\");
                //cwd = cwd.Replace("\\bin\\Debug", "\\");
                //Console.WriteLine("updated cwd is '{0}'", cwd);
            }
            return cwd;
        }

    }
}
