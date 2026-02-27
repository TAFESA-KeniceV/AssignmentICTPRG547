using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_enrollment_system.model
{
    internal class Address
    {
        //string for 13a and 13b on Something Street
        const string DEF_STREET_NUM = "No street number";
        const string DEF_STREET_NAME = "No street name";
        const string DEF_SUBURB = "No suburb";
        const int DEF_POSTCODE = -1;
        const string DEF_STATE = "No state";

        //property assessor 
        public string streetNumber {  get; set; }
        public string streetName { get; set; }
        public string suburb {  get; set; }
        public int postcode { get; set; }
        public string state { get; set; }



        //constructors

        //all arg
        /// <summary>
        /// all arg constructor for Address class
        /// </summary>
        /// <param name="streetNum"></param>
        /// <param name="streetName"></param>
        /// <param name="suburb"></param>
        /// <param name="postcode"></param>
        /// <param name="state"></param>
        public Address(string streetNum, string streetName, string suburb, int postcode,  string state)
        {
            this.streetNumber = streetNum;
            this.streetName = streetName;
            this.suburb = suburb;
            this.postcode = postcode;
            this.state = state;
        }

        //no arg
        /// <summary>
        /// no arg constructor for Address class
        /// </summary>
        public Address() : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE) { }

        //tostring
        /// <summary>
        /// tostring override for Address class
        /// </summary>
        /// <returns>
        /// returns street number, streetname, postcode, and state
        /// </returns>
        public override string ToString()
        {
            return "Street Number: " + streetNumber + "Street Name: " + streetName + "Suburb: " + suburb 
                + "Postcode: " + postcode + "State: " + state;
        }
    }
}
