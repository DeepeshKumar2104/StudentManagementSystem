using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepesh_Project_1
{
    internal class MessageMethod
    {
        public void Mymessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" <--------------------Select Option from bellow Menu to performing desired operations---------------------> ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" 1. Add student in the Database");
            Console.WriteLine(" 2. Find all student from the Database");
            Console.WriteLine(" 3. Filter  student by field from the Database");
            Console.WriteLine(" 4. Find the student whoose age between 15 to 25 in Database");
            Console.WriteLine(" 5. Find the toper in the class");
            Console.WriteLine(" 6. Find the roll number of the student who is in Nth positions");
            Console.WriteLine(" 7. Find all the student with the timestamps to every 10 sec");
            Console.WriteLine();
          
            Console.WriteLine();
           
        }
    }
}
