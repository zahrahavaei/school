using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public interface Istudentedit
    {
        void Addstudent(List<Student> studentlist);
        void Removestudent(List <Student>studentlist);

        void Updatestudent(List<Student> studentlist);
        void Searchstudent(List<Student> studentlist);
        void Showstudentlist(List<Student> studentlist);

    }
}
