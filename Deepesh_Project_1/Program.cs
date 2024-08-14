using Deepesh_Project_1;
using System;
namespace Projects1
{
    
    class Program 
    {
        static void Main(string[] args) {

            MethodClass method = new MethodClass();
            MessageMethod messageMethod = new MessageMethod();
    
            while (true)
            {
                messageMethod.Mymessage();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                int userChoice = int.Parse(Console.ReadLine());
                Console.ResetColor();
                if (userChoice <= 7 || userChoice >= 1) {
                    switch (userChoice)
                    {
                        case 1: method.AddStudent(); break;
                        case 2: method.FindallStudent(); break;
                        case 3: method.FilteredStudent(); break;
                        case 4: method.FilterbyAge(); break;
                        case 5: method.TopperByClass(); break;
                        case 6: method.TopperByRollNo(); break;
                        case 7: method.PrintIn10Sec(); break;
                        default: return;
                    }
                }
                else
                {
                    Console.WriteLine("Please Choose valid Number from 1 to 7");
                }
                
            }

            Console.ReadLine();

        }
    }

}
