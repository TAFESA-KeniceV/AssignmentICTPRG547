using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TAFESA_enrollment_system.model;

namespace TAFESA_enrollment_system
{
    internal class Person
    {
        //constants
        public const string DEF_NAME = "No name";
        public const string DEF_EMAIL = "No email";
        public const string DEF_PHONE_NO = "No phone number";

        //property assessors
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

        //address
        public Address address { get; set; }


        //constrcutors 

        //all arg
        /// <summary>
        /// All arg constructor for Persons class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        public Person(string name, string email, string phoneNumber, Address address)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        //no arg
        /// <summary>
        /// No arg constructor for persons class
        /// </summary>
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NO, new Address()) { }

        //tostring
        /// <summary>
        /// tostring override for persons class
        /// </summary>
        /// <returns>
        /// returns name, email, and phoneNumber
        /// </returns>
        public override string ToString()
        {
            return "name: " + name + ", email: " + email + ", Phone Number: " + phoneNumber + "\nAddress: " + address.ToString();
        }
    }
}
