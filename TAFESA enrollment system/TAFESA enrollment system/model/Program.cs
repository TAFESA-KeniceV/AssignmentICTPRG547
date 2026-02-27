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
            //address

            Console.WriteLine("\nAddress\n");
            //no arg
            Address add1 = new Address();
            Console.WriteLine(add1.ToString());
            //setting
            add1.streetNumber = "221b";
            add1.streetName = "Baker St";
            add1.suburb = "Frakenshire";
            add1.postcode = 1111;
            add1.state = "UK";
            //getting
            Console.WriteLine(add1.streetNumber);
            Console.WriteLine(add1.streetName);
            Console.WriteLine(add1.suburb);
            Console.WriteLine(add1.postcode);
            Console.WriteLine(add1.state);
            //all arg

            Address add2 = new Address("27", "Fletching St", "Bayswater", 2222, "Texas");
            Console.WriteLine(add2.ToString());


            //person

            Console.WriteLine("\nPerson\n");
            //no arg
            Person per1 = new Person();
            Console.WriteLine(per1.ToString());
            //setters
            per1.name = "John E";
            per1.email = "john@email.com";
            per1.phoneNumber = "1234567890";
            per1.address = add1;
            //getters
            Console.WriteLine(per1.name);
            Console.WriteLine(per1.email);
            Console.WriteLine(per1.phoneNumber);
            Console.WriteLine(per1.address);
            //all arg
            Person per2 = new Person("Bill B", "billb@email.com", "111111111", add1);
            Console.WriteLine(per2.ToString());


            //subject

            Console.WriteLine("\nSubject\n");
            //no arg
            Subject sub1 = new Subject();
            Console.WriteLine(sub1.ToString());
            //setter
            sub1.subjectCode = "ENG348LNP";
            sub1.subjectName = "English2";
            sub1.cost = 240.00;
            //getter
            Console.WriteLine(sub1.subjectCode);
            Console.WriteLine(sub1.subjectName);
            Console.WriteLine(sub1.cost);
            //all arg
            Subject sub2 = new Subject("MTHS487PN", "Maths1", 360.00);
            Console.WriteLine(sub2.ToString());


            //enrollemnt

            Console.WriteLine("\nEnrollment\n");
            //noarg
            Enrollment en1 = new Enrollment();
            Console.WriteLine(en1.ToString());
            //setters
            en1.dateEnrolled = "21/02/25";
            en1.grade = "C";
            en1.semester = 2;
            //getters
            Console.WriteLine(en1.dateEnrolled);
            Console.WriteLine(en1.grade);
            Console.WriteLine(en1.semester);
            //all arg
            Enrollment en2 = new Enrollment("28.03.24", "B", 1, sub1);
            Console.WriteLine(en2.ToString());


            //student

            Console.WriteLine("\nStudent\n");
            //no arg
            Student stu1 = new Student();
            Console.WriteLine(stu1.ToString());
            //setters
            stu1.studentID = "AA127845";
            stu1.program = "2E-English";
            stu1.dateRegistered = "02/02/25";
            stu1.enrollment = en1;
            stu1.address = add2;
            stu1.name = "Adam A";
            stu1.email = "aa@amail.com";
            stu1.phoneNumber = "1212121212";
            //getters
            Console.WriteLine(stu1.studentID);
            Console.WriteLine(stu1.program);
            Console.WriteLine(stu1.dateRegistered);
            Console.WriteLine(stu1.enrollment);
            Console.WriteLine(stu1.address);
            Console.WriteLine(stu1.name);
            Console.WriteLine(stu1.email);
            Console.WriteLine(stu1.phoneNumber);
            
            //all arg
            Student stu2 = new Student("JD123456", "E5maths", "28/01/025", en2, "Jane D", "janed@email.com", "15151515", add1);
            Console.WriteLine(stu2.ToString());

            //equals
            Student stu3 = new Student("JD123456", "E5maths", "28/01/025", en2, "Jane D", "janed@email.com", "15151515", add1);
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
