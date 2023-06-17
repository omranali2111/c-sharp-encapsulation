using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_encapsulation
{
    internal class Person
    {
        /*
     Question 1# Create a class called Person that with the following properties:
    name(string)
    age(int)
    address(string)
    Provide public methods to set and get the values of these properties.
        */

        private string name { get; set; }
        private int age { get; set; }
        private string address { get; set; }


        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void SetName(string newName)
        {
            name = newName;
        }
        public void SetAge(int SetAge)
        {
            age = SetAge;
        }
        public void SetAddress(string SetAddress)
        {
            address = SetAddress;
        }
        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetAddress()
        {
            return address;
        }



        public void PrintPersonDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
        }




    }
}
