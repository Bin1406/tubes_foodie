using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodieee
{
    class Cconfig
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Cconfig() { }
        public Cconfig(int width, int height)
        {
            Height = height;
            Width = width;
        }


    }
}
