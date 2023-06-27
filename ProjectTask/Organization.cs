using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public abstract class Organization
    {
        protected string name;
        protected string address;

        public Organization(string name, string address)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be null");
                }
                this.name = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The address cannot be null");
                }
                this.address = value;
            }
        }
        public virtual void Information()
        {
            Console.Write($"{this.name}, {this.address}");
        }
    }
}
