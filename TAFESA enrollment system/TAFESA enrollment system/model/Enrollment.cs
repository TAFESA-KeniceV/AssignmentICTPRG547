using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_enrollment_system.model
{
    public class Enrollment
    {
        //constants
        const string DEF_DATE_ENROLLED = "No date";
        const string DEF_GRADE = "No Grade";
        const int DEF_SEMESTER = 0;

        //property assessor methods
        public string DateEnrolled {  get; set; }
        public string Grade { get; set; }
        public int Semester { get; set; }

        //private Subject Subject;
        public Subject Subject { get; set; }

        //constrcutors

        //all arg
        /// <summary>
        /// all arg constrcutor for Enrollment
        /// </summary>
        /// <param Name="dateEnrolled"></param>
        /// <param Name="grade"></param>
        /// <param Name="semester"></param>
        /// <param Name="subject"></param>
        public Enrollment(string dateEnrolled, string grade, int semester, Subject subject)
        {
            this.DateEnrolled = dateEnrolled;
            this.Grade = grade;
            this.Semester = semester;
            this.Subject = subject;
        }

        //no arg
        /// <summary>
        /// no srg constrcutor for enrollemnt
        /// </summary>
        public Enrollment() :this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER, new Subject()){ }

        //tostring
        /// <summary>
        /// tostring override for Enrollment
        /// </summary>
        /// <returns>
        /// retruns DateEnrolled, Grade, Semester, and Subject information; 
        /// SubjectCode, SubjectName, and Cost
        /// </returns>
        public override string ToString()
        {
            return "Date Enrolled: " + DateEnrolled + ", Grade: " + Grade + ", Semester: " 
                + Semester + "\nSubject: " + Subject.ToString();
        }
    }
}
