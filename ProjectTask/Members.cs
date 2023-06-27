using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Members : Organization, IComparable<Members>
    {
        private string birthdate;
        private int age;

        public Members(string name, string address, string birthdate, int age) : base(name, address)
        {
            this.Birthdate = birthdate;
            this.Age = age;
        }
        public string Birthdate
        {
            get { return birthdate; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The birthdate cannot be null");
                }
                birthdate = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid age");
                }
                age = value;
            }
        }

        public override void Information()
        {
            Console.WriteLine($"Student is in the {this.name} organization, Age{this.age}, Address: {this.address}, Birthdate: {this.birthdate}");
        }
        public int CompareTo(Members other)
        {
            throw new NotImplementedException();
        }
    }
}
