using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physucal_One
{
    public class Person
    {
        public bool Head { get; set; }
        public bool Shoulders { get; set; }
        public bool Foot { get; set; }

        public Person()
        {
            Head = true;
            Shoulders = true;
            Foot = true;
        }
    }
}
