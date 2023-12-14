using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNum { get; set; }
        public List<Address> Addresses { get; set; }

        public Person(string name, string email, string telNum)
        {
            Name = name;
            Email = email;
            TelNum = telNum;
            Addresses = new List<Address>();
        }

        // Method to add an address to the person
        public void AddAddress(Address address)
        {
            Addresses.Add(address);
        }

        // Method to display person details
        public override string ToString()
        {
            string addressDetails = Addresses.Any() ? $"Address: {Addresses[0]}" : "No address available";
            return $"Name: {Name}\nEmail: {Email}\nTelNum: {TelNum}\n{addressDetails}";
        }
    }
}
