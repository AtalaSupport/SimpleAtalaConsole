using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace SimpleAtalaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //// NOTE: to add support for PDF as an input file format, you need:
            //// - activate a license(paid or eval) for our PdfReader Addon if you don't already have one
            //// - reference Atalasoft.dotIamge.PdfReader.dll
            //// - uncomment the following line of code
            //RegisteredDecoders.Decoders.Add(New PdfDecoder() { Resolution = 200 });

            Console.WriteLine("SimpleAtalaConsole Starting...");
            string imgPath = DemoSetup();

            string inFile = imgPath + "_CUSTFILES\\Tiger.jpg";
            
            Console.WriteLine("  inFile: " + inFile);
            string outFile = imgPath + "out.png";
            Console.WriteLine("  outFile: " + outFile);

            Console.WriteLine("BEGIN Processing");


            AtalaImage img = new AtalaImage(inFile);
            Console.WriteLine("  Hi, I have an AtalaImage...");
            Console.WriteLine("    Size: " + img.Size.ToString());
            Console.WriteLine("    PixelFormat: " + img.PixelFormat.ToString());
            img.Save(outFile, new PngEncoder(), null);
            img.Dispose();

            Console.WriteLine("END Processing");
            
            Console.WriteLine("SimpleAtalaConsole finished... press RETURN to exit");
            Console.ReadLine();
        }




        #region Utility Methods
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

        /// <summary>
        /// This is only for setting up the sample app and doesn't actually have anything directly
        /// to do with DotImage - we just use it to put the sample Tiger.jpg in our standard 
        /// _CUSTFILES directory we use for repro
        /// </summary>
        /// <param name="imgPath"></param>
        private static string DemoSetup()
        {
            string setupDir = Path.Combine(GetWorkingDir(), "_CUSTFILES");
            if (!Directory.Exists(setupDir))
            {
                Directory.CreateDirectory(setupDir);
                File.Copy("images\\Tiger.jpg", Path.Combine(setupDir, "Tiger.jpg"));
            }
            return GetWorkingDir();
        }
        #endregion Utility Methods
    }
}
