﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Saksham
 * date
 * Description
 * version 0.1
 * */
namespace Comp1223_2017_lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Superhuman superhuman = new Comp1223_2017_lesson8.Superhuman("superdude");
            superhuman.Powers.Add(new Power("Spider Climbing", 50));
        }
    }
}
