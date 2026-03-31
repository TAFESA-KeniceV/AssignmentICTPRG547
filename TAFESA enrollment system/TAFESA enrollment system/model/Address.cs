using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_enrollment_system.model
{
    public class Address
    {
        //string for 13a and 13b on Something Street
        const string DEF_STREET_NUM = "No street number";
        const string DEF_STREET_NAME = "No street Name";
        const string DEF_SUBURB = "No Suburb";
        const int DEF_POSTCODE = -1;
        const string DEF_STATE = "No State";

        //property assessor 
        public string StreetNumber {  get; set; }
        public string StreetName { get; set; }
        public string Suburb {  get; set; }
        public int Postcode { get; set; }
        public string State { get; set; }



        //constructors

        //all arg
        /// <summary>
        /// all arg constructor for Address class
        /// </summary>
        /// <param Name="streetNum"></param>
        /// <param Name="streetName"></param>
        /// <param Name="suburb"></param>
        /// <param Name="postcode"></param>
        /// <param Name="state"></param>
        public Address(string streetNum, string streetName, string suburb, int postcode,  string state)
        {
            this.StreetNumber = streetNum;
            this.StreetName = streetName;
            this.Suburb = suburb;
            this.Postcode = postcode;
            this.State = state;
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
        /// returns street number, streetname, Postcode, and State
        /// </returns>
        public override string ToString()
        {
            return "Street Number: " + StreetNumber + ", Street Name: " + StreetName + ", Suburb: " + Suburb 
                + ", Postcode: " + Postcode + ", State: " + State;
        }
    }
}
