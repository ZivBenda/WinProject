﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Employee
    {
        public enum Education { Diploma, Bsc, Msc, Phd, Student }
        public string _first_name { get; set; }
        public string _last_name { get; set; }
        public int  _id { get; set; }
        public Education education { get; set; }

    }
}
