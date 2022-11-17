using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1651lab3
{
    public class Triangle : Shape
    {
        private int @base;
        private int height;
        public int Base
        {
            get{return this.@base;}
            set{this.@base=value;}
        }
        public int Height
        {
            get{return this.height;}
            set{this.height=value;}
        }
        public Triangle(){
            Base=1;
            Height=1;
        }
        public Triangle(int @base,int height,string color):base(color)
        {
            this.Base=@base;
            this.Height=height;
        }
        public override double GetArea(){
            return (Height*Base)/2;
        }

        public override string ToString()
        {
            return "Triangle with Height = "+Height+", Base = "+Base;
        }
    }
}