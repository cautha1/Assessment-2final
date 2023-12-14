using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    internal class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        public Address(string street, string number, string suburb, string postcode, string state)
        {
            Street = street;
            Number = number;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        // Method to display address details
        public override string ToString()
        {
            return $"{Number} {Street}, {Suburb}, {State} {Postcode}";
        }
    }
}
