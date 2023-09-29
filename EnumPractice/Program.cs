using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFile file1 = new MyFile("picture.txt", @"C:\users\cseguin\" /* @ signifies no escape character */
                , Rights.READABLE, null);

            // how do we know which permissions were set on file 1?

                //what happens if we target the return of the enum in general
                Console.WriteLine(file1.FileRights);
                // casting
                Console.WriteLine((Rights)file1.FileRights);
                Console.WriteLine((int)file1.FileRights);

            // how do we add to an entity's enum

            file1.FileRights |= Rights.EXECUTABLE;
            Console.WriteLine(file1.FileRights);
        }
    }
}
