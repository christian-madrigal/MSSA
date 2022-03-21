using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4_Part_2
{
    class Student
    {
        private int Studentid;
        private string StudentFname;
        private string StudentLname;
        private char StudentGrade;

        

        public int Id
        {
            get
            {
                return this.Studentid;
            }
            set
            {
                this.Studentid = value;
            }
        }

        public string studentFname
        {
            get
            {
                return this.StudentFname;
            }
            set
            {
                this.StudentFname = value;
            }
        }
        public string studentLname
        {
            get
            {
                return this.StudentLname;
            }
            set
            {
                this.StudentLname = value;
            }
        }
        public char studentGrade
        {
            get
            {
                return this.StudentGrade;
            }
            set
            {
                this.StudentGrade=value;
            }
        }
        public Student()
        {

        }



    }
}
