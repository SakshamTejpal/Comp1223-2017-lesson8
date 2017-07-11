using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Saksham
 * date
 * Description
 * version 0.1
 **/

namespace Comp1223_2017_lesson8
{
    /// <summary>
    /// Power Class which will be used
    /// </summary>
    public class Power
    {
        //public properties
        public string Name { get; set; }
        public int rank { get; set; }
        //constructor
        public Power(string name, int rank)
        {
            name = Name;
            this.rank = rank;
        }
    }
}