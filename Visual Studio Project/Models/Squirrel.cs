using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bindingJSON
{
    public class Squirrel
    {
        public string Name { get; set; }
        public int? Age { get; set; }	// squirrels aren't required tell us their age
        public int Acorns { get; set; }
        public char Gender { get; set; }
        public string Hobby { get; set; }
    }
}