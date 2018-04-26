using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleWizard
{
    /* Class to hold informations about the person and perform basic
     * operations on them.
     */
    public class Person
    {
        public string name { get; set; }    = "";
        public string surname { get; set; } = "";
        public string address { get; set; } = "";
        public string phone { get; set; }   = "";

        /*Parameter constructor
         */
        public Person(string newName, string newSurname, string newAddress, string newPhone)
        {
            name    = newName;  surname = newSurname;
            address = newAddress; phone   = newPhone;
        }

        public bool areAllDataSpecified()
        {
            return !(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phone));
        }
    }
}