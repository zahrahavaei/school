using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class Student: Istudentedit
    {
        private string firstname;
        private string lastname;
       
        private int grade;
        private string id;
       

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
       
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public Student(string firstname, string lastname, int grade, string id)
        {
            Firstname = firstname;
            Lastname = lastname;
            Grade = grade;
            Id = id;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name:{Firstname} {Lastname} Grade:{Grade} Id:{Id}");

        }
        public void Addstudent(List<Student> studentslist)
        {
            Console.WriteLine("enter st name");
            string stfirstname = Console.ReadLine();
            Console.WriteLine("enter last name");
            string stlastname = Console.ReadLine();
            Console.WriteLine("enter Grade");
            if (!int.TryParse(Console.ReadLine(), out int stgrade))
            {
                Console.WriteLine("invalid grade ");
                return;
            }
            Console.WriteLine("enter Id");
           string stid= Console.ReadLine();
            var newstudent = new Student(stfirstname, stlastname, stgrade, stid);
            studentslist.Add(newstudent);

        }
        //..............................................................................................
        public void Removestudent(List<Student> studentslist)
        {
            Console.WriteLine("Enter the first name of the student to remove:");
            string stfirstname = Console.ReadLine();
            Console.WriteLine("Enter the Id of the student to remove:");
            string stid = Console.ReadLine();
            var removestudent = studentslist.Find(st => st.Firstname==(stfirstname)&& st.Id==(stid));
            if (removestudent != null)
            {
                        studentslist.Remove(removestudent);
                        Console.WriteLine($"Student {stfirstname}  id:{stid} removed successfully.");
                    
            }
            else
            {
                Console.WriteLine($"Student {stfirstname} not found.");
            }
        }
        //.........................................................................
        public void Updatestudent(List<Student> studentslist)
        {
            Console.WriteLine("Enter the first name of the student to remove:");
            string stfirstname = Console.ReadLine();
            Console.WriteLine("Enter the Id of the student to remove:");
            string stid = Console.ReadLine();
            var studentupdate = studentslist.Find(st => st.Firstname==(stfirstname) && st.Id==(stid));
            if (studentupdate != null)
            {
                Console.WriteLine("enter new name");
                string newfirstname = Console.ReadLine();
                studentupdate.Firstname = newfirstname;
                Console.WriteLine("update was successful");
            }
            
        }
        //........................................................................
        public void Searchstudent(List<Student> studentslist)
        {
            Console.WriteLine("Enter the first name of the student to search:");
            string stfirstname = Console.ReadLine();

            var studentfind = studentslist.Where(s => s.Firstname==(stfirstname));
            if (studentfind != null )
            {
                foreach(var st in studentfind)
                {
                    Console.WriteLine("Student found:");
                    st.DisplayStudentInfo();
                }
                
               
            }
            else
            {
                Console.WriteLine($"Student {stfirstname} not found.");
            }
        }
        //.........................................................
        public void Showstudentlist(List<Student> studentsList)
        {
            if (studentsList.Count == 0)
            {
                Console.WriteLine("No students to display.");
                return;
            }

            Console.WriteLine("List of Students:");
            foreach (Student s in studentsList)
            {
                s.DisplayStudentInfo();
            }


        }
    }
}
