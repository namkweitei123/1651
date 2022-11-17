using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1651lab3
{
    public abstract class Shape
    {
        private string color;
        public string Color
        {
            get{return this.color;}
            set{this.color=value;}
        }
        public Shape(string color)
        {
          this.Color=color;
        }

        public Shape() 
        {
            this.color="red";
        }

        public abstract double GetArea();
        
        public override string ToString()
        {
            return "Color = "+Color;
        }
    }
}