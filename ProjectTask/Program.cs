using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of members in the organization:");
            int count = int.Parse(Console.ReadLine());
            List<string> members = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < count; i++)
            {

            }
            
            
        }
    }
}
