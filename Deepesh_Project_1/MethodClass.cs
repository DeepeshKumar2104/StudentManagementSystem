using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Deepesh_Project_1
{
    internal class MethodClass
    {
        
        List<StudentClass> students = new List<StudentClass>();
        StudentClass studentClass = new StudentClass();
        public void AddStudent()
        {  
            try
            {

               


                Console.WriteLine("Enter a Student FirstName");
                string fristName = studentClass.Firstname = Console.ReadLine();
                Console.WriteLine("Enter a Student MiddleName");
                string middleName=studentClass.MiddleName = Console.ReadLine();
                Console.WriteLine("Enter a Student LastName");
                string lastName = studentClass.LastName = Console.ReadLine();

                //<----------- Age validDations--------------> 

                long age;
                bool isValid = false;
                int newAge;
                while (!isValid)
                {
                    Console.WriteLine("Enter a Student Age:");
                    age = long.Parse(Console.ReadLine());

                    if (age > 0 && age <= 25)
                    {
                        studentClass.Age = age;
                        isValid = true; 
                    }else if (typeof(int)==typeof(string))
                    {
                        Console.WriteLine("please provide valid Details");
                    }
                
                    else
                    {
                        Console.WriteLine("Please provide valid Age.");
                    }
                }

                //<----------- Age validDations Completed--------------> 
                // <------Enums implementations----------->

                Console.WriteLine("Choose Your Class from given bellow");
                Console.WriteLine("Class 1, Class 2, Class 3, Class 4 , Class 5, Class 6, Class 7, Class 8, Class 9, Class 10, Class 11, Class 12");
                foreach (var className in Enum.GetValues(typeof(Classes))) {
                    Console.WriteLine($"{(int)className} - {className}");

                }
                Classes classes = (Classes)int.Parse(Console.ReadLine());
                studentClass.Class = classes;

                // <------Enums implementations ended here ----------->

                // Roll no. validations 

                long rollNo;
                bool valid = false;
                
                while (!valid)
                {
                    Console.WriteLine("Enter a Student RollNo");
                    rollNo = int.Parse(Console.ReadLine());
                    if (rollNo > 0 && rollNo <= 1000)
                    {
                          studentClass.RollNo = rollNo;
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please provide valid RollNo.");
                    }
                }

                // Roll no. validation ends 

                Dictionary<string, int> Subjects = new Dictionary<string, int>();
                Console.WriteLine("Enter the subjects and marks in this order given Format ---------->>> Hindi,45 ");
                Console.WriteLine("Types {exit} if you have added all the subjects and want to exit from this sections");

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input.ToLower() == "exit") break;
                    var parts = input.Split(',') ;
                    Subjects.Add(parts[0],int.Parse(parts[1]));
                }
                studentClass.Subject = Subjects;
                // hobies
                Console.WriteLine("Please Enter your hobbies max upto only 7");
                Console.WriteLine("Please types -----><------Exit--------->if you have fill the hobbies");
                List<string> hobby = new List<string>();
                while (true) 
                {
                    string hobbies = Console.ReadLine() ;
                    if (hobby.Count >= 7)
                    {
                        Console.WriteLine("You can not add More then 7 hobbies");
                        hobby.Add(hobbies);
                        studentClass.Hobby = hobby;
                        break;
                    }
                    else if (hobbies.ToLower() == "exit") break;
                    hobby.Add(hobbies);
                }
                studentClass.Hobby = hobby;

                
                // Address
                Console.WriteLine("Enter Your Present Address");
                studentClass.Address = Console.ReadLine();
               
                // Add the new student to the list
                students.Add(studentClass);
                Console.WriteLine("Student added successfully.");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception Generates :" + ex.Message);
            }
        }
        public void FindallStudent() {

            int count = 1;
            foreach (var student in students) {
                try
                {
                    Console.WriteLine($"{count}. Student Name: {student.Firstname} {student.MiddleName} {student.LastName}");
                    Console.WriteLine($"   Age: {student.Age}, Class: {student.Class}, Roll No.: {student.RollNo}");
                    Console.WriteLine("   Subjects and Marks:");
                    foreach (var subject in student.Subject)
                    {
                        Console.WriteLine($"     {subject.Key}: {subject.Value}");
                    }
                    Console.WriteLine($"   Hobbies: {string.Join(", ", student.Hobby)}");
                    Console.WriteLine($"   Address: {student.Address}");
                 
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Generated: " + ex.Message);
                }
                count++;
            }
        }
        public void FilteredStudent() { }
        public void FilterbyAge()
        {
            int count = 0;  
            foreach (var student in students) 
            {
                if(student.Age>=15 && student.Age<=25)
                {
                    Console.WriteLine($"{count}. Student Name: {student.Firstname} {student.MiddleName} {student.LastName}");
                    Console.WriteLine($"Age: {student.Age}, Class: {student.Class}, Roll No.: {student.RollNo}");
                    Console.WriteLine("Subjects and Marks:");
                    foreach (var subject in student.Subject)
                    {
                        Console.WriteLine($"{subject.Key}: {subject.Value}");
                    }
                    Console.WriteLine($"Hobbies: {string.Join(", ", student.Hobby)}");
                    Console.WriteLine($"Address: {student.Address}");
                    count++;
                }
               
            }
            Console.WriteLine($"Total Student present in the list {count}");
        }
        
        public void TopperByClass() 
        {
            Console.WriteLine("Please select the Class From the Bellow List");
            foreach(var classes in Enum.GetValues(typeof(Classes))){
                Console.WriteLine($"{(int)classes}-{classes}");
            }
            Classes classss = (Classes)int.Parse(Console.ReadLine());
            var topper = students.OrderBy(s=>s.Subject.Values.Sum()).FirstOrDefault();
            Console.WriteLine(topper.Firstname);
            //studentClass.TopperClass = classss;

        }
        public void TopperByRollNo() { }
        public void PrintIn10Sec()
        {

            try
            {
                Thread th = new Thread(() =>
                {
                    Thread.Sleep(10000);
                    FindallStudent();
                });
                th.Start();
                th.Join();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Generated: " + ex.Message);
            }
        }

    }
}
