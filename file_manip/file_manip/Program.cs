using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace file_manip
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            
             *            
            In the console:
            1) Prompt a user for a file path to a text file (actually a .cs file, but we'll get to that in a moment)
            2) read the text file and remove all commented lines from it
            3) save the text file in the same location with a new name of "OLDNAME"-min.cs
            4) open the new file in Notepad
            5) end program    
            
            */

            string pathName = null;
            pathName = filePath(pathName);
            string[] lines = System.IO.File.ReadAllLines(pathName);
            pathName = changeFileName(pathName);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathName))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("//"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            //opens notepad with given file name
            Process.Start("notepad.exe", pathName);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static string changeFileName(string filePath)
        {
            int index = filePath.IndexOf(".");
            if (index > 0)
                filePath = filePath.Substring(0, index);
            filePath = filePath + ".txt";
            return filePath;
        }

        static string filePath(string name)
        {
            Console.WriteLine("Enter path of file to open: ");
            name = Console.ReadLine();
            return name;
        }
    }
}
