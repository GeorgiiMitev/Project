using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Comparator : IComparer<Members>
    {

        public int Compare(Members x, Members y)
        {
            int result = y.Age.CompareTo(x.Age);
            if (result == 0)
            {
                result = x.Age.CompareTo(y.Age);
            }
            return result;

        }

    }
}
