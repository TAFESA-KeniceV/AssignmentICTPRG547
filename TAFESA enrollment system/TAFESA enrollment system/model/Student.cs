using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESA_enrollment_system.model;

namespace TAFESA_enrollment_system
{
    internal class Student : Person, IComparable, IComparable<Student>
    {
        //constants
        const string DEF_ID = "0";
        const string DEF_PROGRAM = "No Program selected";
        const string DEF_DATE_REG = "No date registered";  

        //property assessor
        public string StudentID { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }

        //Enrollment
        public Enrollment Enrollment { get; set; }

        //constrcutors

        //all arg
        /// <summary>
        /// All arg constrcutor to Student class
        /// </summary>
        /// <param Name="studentID"></param>
        /// <param Name="program"></param>
        /// <param Name="date"></param>
        /// <param Name="enrollment"></param>
        /// <param Name="name"></param>
        /// <param Name="Email"></param>
        /// <param Name="phoneno"></param>
        /// <param Name="Address"></param>
        public Student(string studentID, string program, string date, Enrollment enrollment, string name, string email, string phoneno, Address address) :base(name, email, phoneno, address)
        {
            this.StudentID = studentID;
            this.Program = program;
            this.DateRegistered = date;
            this.Enrollment = enrollment;
        }
        
        //ID only
        /// <summary>
        /// ID only constructor for student class
        /// </summary>
        /// <param Name="studentID"></param>
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
        /// Returns StudentID, Program, Dateregistered, enrollemnt, and inherited attributes 
        /// from Person class Name, Email, and phone no
        /// </returns>
        public override string ToString()
        {
            return "StudentID: " + StudentID + ", Program: " + Program + ", Date Registered: " 
                + DateRegistered + "\nEnrollemnt: " + Enrollment.ToString() + "\n" +base.ToString();
        }

        //equals
        /// <summary>
        /// equals(object) override for Student that checks object type is student and 
        /// compares StudentID
        /// </summary>
        /// <param Name="obj"></param>
        /// <returns>
        /// returns a bool of a comparision of StudentID between objects
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
            return f1.StudentID == this.StudentID;
        }

        //gethashcode
        /// <summary>
        /// overrides gethashcode to hash StudentID
        /// </summary>
        /// <returns>
        /// returned hashed StudentID
        /// </returns>
        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode();
        }
        /// <summary>
        /// uses studentid to compareto to compare another student object's studentid
        /// </summary>
        /// <param Name="other"></param>
        /// <returns>
        /// returns result of string compareto called by studentid
        /// </returns>
        public int CompareTo(Student other)
        {
            return this.StudentID.CompareTo(other.StudentID);
        }
        /// <summary>
        /// checks that obj isn't null and is of type student and throws suittable exceptions
        /// then calls student compareto student and places obj in if it has been identified
        /// as a student object.
        /// </summary>
        /// <param Name="obj"></param>
        /// <returns>
        /// returns result of student compareto student
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (!(obj is Student))
                throw new ArgumentException("Expected Student Instance", "obj");
            return CompareTo((Student)obj);
        }

        //== overload
        /// <summary>
        /// overloaded == to compare two student objects using equals method
        /// </summary>
        /// <param Name="stu1"></param>
        /// <param Name="stu2"></param>
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
        /// <param Name="stu1"></param>
        /// <param Name="stu2"></param>
        /// <returns>
        /// returns bool from calling the not equals method
        /// </returns>
        public static bool operator !=(Student stu1, Student stu2)
        {
            return !object.Equals(stu1, stu2);
        }
        /// <summary>
        /// uses gethashcode to see if stu1 is less than stu2
        /// </summary>
        /// <param Name="stu1"></param>
        /// <param Name="stu2"></param>
        /// <returns>
        /// returns if stu1 hashcode is less than stu2 hashcode
        /// </returns>
        public static bool operator <(Student stu1, Student stu2)
        {
            return stu1.GetHashCode() < stu2.GetHashCode();
        }
        /// <summary>
        /// uses gethashcode to see if stu1 is greater than stu2
        /// </summary>
        /// <param Name="stu1"></param>
        /// <param Name="stu2"></param>
        /// <returns>
        /// returns if stu1 hashcode is greater than stu2 hashcode
        /// </returns>
        public static bool operator >(Student stu1, Student stu2)
        {
            return stu1.GetHashCode() > stu2.GetHashCode();
        }
        /// <summary>
        /// uses gethashcode to see if stu1 is less or equal to than stu2
        /// </summary>
        /// <param Name="stu1"></param>
        /// <param Name="stu2"></param>
        /// <returns>
        /// returns if stu1 hashcode is less than or equal to stu2 hashcode
        /// </returns>
        public static bool operator <=(Student stu1, Student stu2)
        {
            return stu1.GetHashCode() <= stu2.GetHashCode();
        }
        /// <summary>
        /// uses gethashcode to see if stu1 is greater than or equal to than stu2
        /// </summary>
        /// <param Name="stu1"></param>
        /// <param Name="stu2"></param>
        /// <returns>
        /// returns if stu1 hashcode is greater than or equal to stu2 hashcode
        /// </returns>
        public static bool operator >=(Student stu1, Student stu2)
        {
            return stu1.GetHashCode() >= stu2.GetHashCode();
        }
    }
}
