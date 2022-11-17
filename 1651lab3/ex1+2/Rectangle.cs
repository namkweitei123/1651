using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1651lab3
{
    public class Rectangle: Shape
    {
        private int length;
        private int width;
        public int Length
        {
            get {return this.length;}
            set {this.length=value;}
        }
        public int Width
        {
            get {return this.width;}
            set {this.width=value;}
        }

        public Rectangle()
        {
            Length=1;
            Width=1;
        }
        public Rectangle(int length,int width, string color):base(color)
        {
            this.Length=length;
            this.Width=width;
        }
        public override double GetArea()
        {
            return Length*Width;
        }
        public override string ToString()
        {
            return "Rectangle with length = "+Length+", width = "+Width;
        }
    }
} 