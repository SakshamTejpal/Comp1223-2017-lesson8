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
    public abstract class Human
    {
        // private instance variable (Feilds)
        private string _name;
        //public properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }


       
        //constructor
        public Human(string name)
        {
            this.Name = name;
        }
        
    }
}