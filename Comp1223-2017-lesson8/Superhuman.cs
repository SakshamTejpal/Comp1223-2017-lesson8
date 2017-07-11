using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Saksham
 * date
 * Description
 * version 0.1
 * */
namespace Comp1223_2017_lesson8
{
    public class Superhuman : Human
    {
        //private instance variables
        private List<Power> _Powers;
        //public properties
        //constructors
        public Superhuman(string name):base(name)
        {
           
            initiallizes();

        }
        //private method
        private void initiallizes()
        {
            this._Powers =  new List <Power>();

        }
        //public methods

    }
}