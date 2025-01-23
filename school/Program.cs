// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Globalization;
using school;

class program
{
    static void Main()
    {
       
        List<Student> studentslist = new List<Student>();
        Istudentedit student = new Student("","",0,"");
        while (true)
        {
            Console.WriteLine("What do you want to do?! ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1: Add a new student ");
            Console.WriteLine("2: Remove a student ");
            Console.WriteLine("3:Search a student ");
            Console.WriteLine("4: update a student ");
            Console.WriteLine("5: show list of student ");
            Console.WriteLine("6: Exit ");
            Console.ResetColor();
            if (!int.TryParse(Console.ReadLine(), out int num) || (num < 1 || num > 6))
            {
                Console.WriteLine("invalid number,try again");
                continue;
            }

            switch (num)
            {
                case 1:
                    student.Addstudent(studentslist);
                    break;

                case 2:
                    student.Removestudent(studentslist);
                    break;
                case 3:
                    student.Searchstudent(studentslist);
                    break;
                case 4:
                    student.Updatestudent(studentslist);
                    break;
                case 5:
                    student.Showstudentlist(studentslist);
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    return;

            }
            
            
        }
    }
   
    
}










