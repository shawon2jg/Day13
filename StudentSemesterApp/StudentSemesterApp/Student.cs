using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSemesterApp
{
    class Student
    {
        public string id { set; get; }
        public string name { set; get; }
        public string email { set; get; }

        public Semester studentSemester { set; get; }

        public Student(string id,string name,string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }
    }
}
