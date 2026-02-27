using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_enrollment_system
{
    internal class Student : Person
    {
        //constants
        const string DEF_ID = "0";
        const string DEF_PROGRAM = "No program selected";
        const string DEF_DATE_REG = "No date registered";  

        //property assessor
        public string StudentID { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }

        //constrcutors
        //all arg
        public Student(string studentID, string program, string date, string name, string email, string phoneno) :base(name, email, phoneno)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = date;
        }
        //no arg 
        public Student() :this(DEF_ID, DEF_PROGRAM, DEF_DATE_REG,DEF_NAME, DEF_EMAIL, DEF_PHONE_NO) { }
        //tostring




    }
}
