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

            string pathName;
            int count = 1;
            string searchText = "//";
            string[] lines = System.IO.File.ReadAllLines(pathName);

            Console.WriteLine("Enter path of file to open: ");
            pathName = Console.ReadLine();
            
            foreach (string line in lines)
            {
                string lineSearch = line;
                bool result = lineSearch.Contains(searchText);
                if(result)
                {
                    //int index = subLine.IndexOf(searchText);
                    //if(index >= 0)
                    Console.WriteLine(count);
                    count++; // counts number of commented lines successfully
                }                
            }

            Console.WriteLine(count);
            //opens notepad with given file name
            //Process.Start("notepad.exe", pathName);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
