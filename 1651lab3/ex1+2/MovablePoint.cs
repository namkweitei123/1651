using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1651lab3
{
    public class MovablePoint: IMovable
    {
        private int x;
        private int y;
        public int X 
        {
            get{return this.x;}
            set{this.x=value;}
        }
        public int Y
        {
            get {return this.y;}
            set {this.y=value;}
        }
        public MovablePoint()
        {
            X=0;
            Y=0;
        }

        public MovablePoint(int x, int y)
        {
            this.X=x;
            this.Y=y;
        }
        public void MoveUp(){
            Y++;
        }
        public void MoveDown(){
            Y--;
        }
        public void MoveLeft(){
            X--;
        }
        public void MoveRight(){
            X++;
        }

        public override string ToString()
        {
            return "("+X+" , "+Y+")";
        }
    }
}