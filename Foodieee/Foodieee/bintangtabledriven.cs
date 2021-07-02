using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodieee
{
    class bintangtabledriven
    {
        public enum id { binbin };
        public static string[] password = { "Foodie" };

        public static string getPassword(id id)
        {
            return password[(int)id];
        }
    }
}
