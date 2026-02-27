using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESA_enrollment_system.model;

namespace TAFESA_enrollment_system
{
    internal class Student : Person
    {
        //constants
        const string DEF_ID = "0";
        const string DEF_PROGRAM = "No program selected";
        const string DEF_DATE_REG = "No date registered";  

        //property assessor
        public string studentID { get; set; }
        public string program { get; set; }
        public string dateRegistered { get; set; }

        //enrollment
        public Enrollment enrollment { get; set; }

        //constrcutors

        //all arg
        /// <summary>
        /// All arg constrcutor to Student class
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="program"></param>
        /// <param name="date"></param>
        /// <param name="enrollment"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phoneno"></param>
        /// <param name="address"></param>
        public Student(string studentID, string program, string date, Enrollment enrollment, string name, string email, string phoneno, Address address) :base(name, email, phoneno, address)
        {
            this.studentID = studentID;
            this.program = program;
            this.dateRegistered = date;
            this.enrollment = enrollment;
        }
        
        //ID only
        /// <summary>
        /// ID only constructor for student class
        /// </summary>
        /// <param name="studentID"></param>
        public Student(string studentID) : this(studentID, DEF_PROGRAM, DEF_DATE_REG, new Enrollment(), DEF_NAME, DEF_EMAIL, DEF_PHONE_NO, new Address()) { }
        
        //no arg 
        /// <summary>
        /// No arg constructor for Student class
        /// </summary>
        public Student() :this(DEF_ID, DEF_PROGRAM, DEF_DATE_REG, new Enrollment(), DEF_NAME, DEF_EMAIL, DEF_PHONE_NO, new Address()) { }
        
        //tostring
        /// <summary>
        /// ToString override for student class
        /// </summary>
        /// <returns>
        /// Returns studentID, program, Dateregistered, enrollemnt, and inherited attributes 
        /// from Person class name, email, and phone no
        /// </returns>
        public override string ToString()
        {
            return "studentID: " + studentID + ", program: " + program + ", Date Registered: " 
                + dateRegistered + "\nEnrollemnt: " + enrollment.ToString() + "\n" +base.ToString();
        }

        //equals
        /// <summary>
        /// equals(object) override for Student that checks object type is student and 
        /// compares studentID
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// returns a bool of a comparision of studentID between objects
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            Student f1 = (Student)obj;
            return f1.studentID == this.studentID;
        }

        //gethashcode
        /// <summary>
        /// overrides gethashcode to hash studentID
        /// </summary>
        /// <returns>
        /// returned hashed studentID
        /// </returns>
        public override int GetHashCode()
        {
            return this.studentID.GetHashCode();
        }

        //== overload
        /// <summary>
        /// overloaded == to compare two student objects using equals method
        /// </summary>
        /// <param name="stu1"></param>
        /// <param name="stu2"></param>
        /// <returns>
        /// returns bool from calling the equals method
        /// </returns>
        public static bool operator ==(Student stu1, Student stu2)
        {
            return object.Equals(stu1, stu2);
        }
        //!= overload
        /// <summary>
        ///  overloaded != to compare two student objects using equals method
        /// </summary>
        /// <param name="stu1"></param>
        /// <param name="stu2"></param>
        /// <returns>
        /// returns bool from calling the not equals method
        /// </returns>
        public static bool operator !=(Student stu1, Student stu2)
        {
            return !object.Equals(stu1, stu2);
        }
    }
}
