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
        public const string DEF_NAME = "No Name";
        public const string DEF_EMAIL = "No Email";
        public const string DEF_PHONE_NO = "No phone number";

        //property assessors
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //Address
        public Address Address { get; set; }


        //constrcutors 

        //all arg
        /// <summary>
        /// All arg constructor for Persons class
        /// </summary>
        /// <param Name="name"></param>
        /// <param Name="Email"></param>
        /// <param Name="PhoneNumber"></param>
        /// <param Name="Address"></param>
        public Person(string name, string email, string phoneNumber, Address address)
        {
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
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
        /// returns Name, Email, and PhoneNumber
        /// </returns>
        public override string ToString()
        {
            return "Name: " + Name + ", Email: " + Email + ", Phone Number: " + PhoneNumber + "\nAddress: " + Address.ToString();
        }
    }
}
