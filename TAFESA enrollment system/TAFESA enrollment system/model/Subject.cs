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
        const string DEF_SUBJECT_NAME = "No name";
        const double DEF_COST = -1.0;

        //property assesor methods
        public string subjectCode {  get; set; }
        public string subjectName { get; set; }
        public double cost { get; set; }

        //constructors

        //all arg
        /// <summary>
        /// all arg constrcutor for Subject
        /// </summary>
        /// <param name="subjectCode"></param>
        /// <param name="subjectName"></param>
        /// <param name="cost"></param>
        public Subject(string subjectCode, string subjectName, double cost)
        {
            this.subjectCode = subjectCode;
            this.subjectName = subjectName;
            this.cost = cost;
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
        /// returns subjectCode, subjectName, and cost
        /// </returns>
        public override string ToString()
        {
            return "Subject Code: " + subjectCode + "Subject Name: "+ subjectName + "Cost: " + cost;
        }
    }
}
