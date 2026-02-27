using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_enrollment_system
{
    internal class Person
    {
        //constants
        public const string DEF_NAME = "No Name";
        public const string DEF_EMAIL = "No Email";
        public const string DEF_PHONE_NO = "No phone number";

        //property assessors
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //public Address address { get; set; }

        //constrcutors 
        //all arg
        public Person(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        //no arg
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NO) { }

        //tostring
        public override string ToString()
        {
            return "Name: " + Name + " Email: " + Email + " Phone Number: " + PhoneNumber;
        }
    }
}
