using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESA_enrollment_system.model;

namespace TAFESA_enrollment_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Address

            Console.WriteLine("\nAddress\n");
            //no arg
            Address add1 = new Address();
            Console.WriteLine(add1.ToString());
            //setting
            add1.StreetNumber = "221b";
            add1.StreetName = "Baker St";
            add1.Suburb = "Frakenshire";
            add1.Postcode = 1111;
            add1.State = "UK";
            //getting
            Console.WriteLine(add1.StreetNumber);
            Console.WriteLine(add1.StreetName);
            Console.WriteLine(add1.Suburb);
            Console.WriteLine(add1.Postcode);
            Console.WriteLine(add1.State);
            //all arg

            Address add2 = new Address("27", "Fletching St", "Bayswater", 2222, "Texas");
            Console.WriteLine(add2.ToString());


            //person

            Console.WriteLine("\nPerson\n");
            //no arg
            Person per1 = new Person();
            Console.WriteLine(per1.ToString());
            //setters
            per1.Name = "John E";
            per1.Email = "john@Email.com";
            per1.PhoneNumber = "1234567890";
            per1.Address = add1;
            //getters
            Console.WriteLine(per1.Name);
            Console.WriteLine(per1.Email);
            Console.WriteLine(per1.PhoneNumber);
            Console.WriteLine(per1.Address);
            //all arg
            Person per2 = new Person("Bill B", "billb@Email.com", "111111111", add1);
            Console.WriteLine(per2.ToString());


            //Subject

            Console.WriteLine("\nSubject\n");
            //no arg
            Subject sub1 = new Subject();
            Console.WriteLine(sub1.ToString());
            //setter
            sub1.SubjectCode = "ENG348LNP";
            sub1.SubjectName = "English2";
            sub1.Cost = 240.00;
            //getter
            Console.WriteLine(sub1.SubjectCode);
            Console.WriteLine(sub1.SubjectName);
            Console.WriteLine(sub1.Cost);
            //all arg
            Subject sub2 = new Subject("MTHS487PN", "Maths1", 360.00);
            Console.WriteLine(sub2.ToString());


            //enrollemnt

            Console.WriteLine("\nEnrollment\n");
            //noarg
            Enrollment en1 = new Enrollment();
            Console.WriteLine(en1.ToString());
            //setters
            en1.DateEnrolled = "21/02/25";
            en1.Grade = "C";
            en1.Semester = 2;
            //getters
            Console.WriteLine(en1.DateEnrolled);
            Console.WriteLine(en1.Grade);
            Console.WriteLine(en1.Semester);
            //all arg
            Enrollment en2 = new Enrollment("28.03.24", "B", 1, sub1);
            Console.WriteLine(en2.ToString());


            //student

            Console.WriteLine("\nStudent\n");
            //no arg
            Student stu1 = new Student();
            
            Console.WriteLine(stu1.ToString());
            //setters
            stu1.StudentID = "AA127845";
            stu1.Program = "2E-English";
            stu1.DateRegistered = "02/02/25";
            stu1.Enrollment = en1;
            stu1.Address = add2;
            stu1.Name = "Adam A";
            stu1.Email = "aa@amail.com";
            stu1.PhoneNumber = "1212121212";
            //getters
            Console.WriteLine(stu1.StudentID);
            Console.WriteLine(stu1.Program);
            Console.WriteLine(stu1.DateRegistered);
            Console.WriteLine(stu1.Enrollment);
            Console.WriteLine(stu1.Address);
            Console.WriteLine(stu1.Name);
            Console.WriteLine(stu1.Email);
            Console.WriteLine(stu1.PhoneNumber);
            
            //all arg
            Student stu2 = new Student("JD123456", "E5maths", "28/01/025", en2, "Jane D", "janed@Email.com", "15151515", add1);
            Console.WriteLine(stu2.ToString());

            //equals
            Student stu3 = new Student("JD123456", "E5maths", "28/01/025", en2, "Jane D", "janed@Email.com", "15151515", add1);
            Console.WriteLine("\nEquals\n");
            Console.WriteLine("Expected False: stu2.Equals(stu1)");
            Console.WriteLine(stu2.Equals(stu1));
            Console.WriteLine("Expected True: stu2.Equals(stu3)");
            Console.WriteLine(stu2.Equals(stu3));

            //==
            Console.WriteLine("\n==\n");
            Console.WriteLine("Expected False: stu2 == stu1");
            Console.WriteLine(stu2==stu1);
            Console.WriteLine("Expected True: stu2 == stu3");
            Console.WriteLine(stu2 == stu3);

            //!=
            Console.WriteLine("\n!=\n");
            Console.WriteLine("Expected True: stu2 != stu1");
            Console.WriteLine(stu2 != stu1);
            Console.WriteLine("Expected False: stu2 != stu3");
            Console.WriteLine(stu2 != stu3);

            //gethash
            Console.WriteLine("\ngethash\n");
            Console.WriteLine("stu1");
            Console.WriteLine(stu1.GetHashCode());
            Console.WriteLine("stu2");
            Console.WriteLine(stu2.GetHashCode());
            Console.WriteLine("stu3");
            Console.WriteLine(stu3.GetHashCode());
        }
        
    }
}
