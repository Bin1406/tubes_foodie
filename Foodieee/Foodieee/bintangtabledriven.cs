using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodieee
{
    class bintangtabledriven
    {
        public enum pin { binbin };
        public static string[] password = { "Foodie" };

        public static string getPassword(pin pin)
        {
            return password[(int)pin];
        }
    }
}
