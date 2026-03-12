using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_enrollment_system.model
{
    internal class Subject
    {
        //constants
        const string DEF_SUBJECT_CODE = "No code";
        const string DEF_SUBJECT_NAME = "No Name";
        const double DEF_COST = -1.0;

        //property assesor methods
        public string SubjectCode {  get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        //constructors

        //all arg
        /// <summary>
        /// all arg constrcutor for Subject
        /// </summary>
        /// <param Name="SubjectCode"></param>
        /// <param Name="SubjectName"></param>
        /// <param Name="Cost"></param>
        public Subject(string subjectCode, string subjectName, double cost)
        {
            this.SubjectCode = subjectCode;
            this.SubjectName = subjectName;
            this.Cost = cost;
        }

        //no arg
        /// <summary>
        /// no arg constrictor for Subject
        /// </summary>
        public Subject() :this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST) { }

        //tostring
        /// <summary>
        /// tostring override for Subject
        /// </summary>
        /// <returns>
        /// returns SubjectCode, SubjectName, and Cost
        /// </returns>
        public override string ToString()
        {
            return "Subject Code: " + SubjectCode + ", Subject Name: "+ SubjectName + ", Cost: " + Cost;
        }
    }
}
