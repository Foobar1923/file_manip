using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_manip
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            In the console:
            1) Prompt a user for a file path to a text file (actually a .cs file, but we'll get to that in a moment)
            2) read the text file and remove all commented lines from it
            3) save the text file in the same location with a new name of "OLDNAME"-min.cs
            4) open the new file in Notepad
            5) end prog 
            
            */

            Console.WriteLine("Enter path of file to open: ");
            string pathName = Console.ReadLine(pathName);
            Console.WriteLine(pathName);



        }
    }
}
