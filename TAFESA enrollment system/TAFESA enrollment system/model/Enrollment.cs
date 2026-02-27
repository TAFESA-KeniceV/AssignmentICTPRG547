using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_enrollment_system.model
{
    internal class Enrollment
    {
        //constants
        const string DEF_DATE_ENROLLED = "No date";
        const string DEF_GRADE = "No grade";
        const int DEF_SEMESTER = 0;

        //property assessor methods
        public string dateEnrolled {  get; set; }
        public string grade { get; set; }
        public int semester { get; set; }

        //private Subject subject;
        public Subject subject { get; set; }

        //constrcutors

        //all arg
        /// <summary>
        /// all arg constrcutor for enrollment
        /// </summary>
        /// <param name="dateEnrolled"></param>
        /// <param name="grade"></param>
        /// <param name="semester"></param>
        /// <param name="subject"></param>
        public Enrollment(string dateEnrolled, string grade, int semester, Subject subject)
        {
            this.dateEnrolled = dateEnrolled;
            this.grade = grade;
            this.semester = semester;
            this.subject = subject;
        }

        //no arg
        /// <summary>
        /// no srg constrcutor for enrollemnt
        /// </summary>
        public Enrollment() :this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER, new Subject()){ }

        //tostring
        /// <summary>
        /// tostring override for enrollment
        /// </summary>
        /// <returns>
        /// retruns dateEnrolled, grade, semester, and subject information; subjectCode, subjectName, and cost
        /// </returns>
        public override string ToString()
        {
            return "Date Enrolled: " + dateEnrolled + "Grade: " + grade + "Semester: " 
                + semester + "\nSubject: " + subject.ToString();
        }
    }
}
