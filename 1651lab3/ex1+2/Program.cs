using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shape s= new Triangle(2,3,"blue");
            Console.WriteLine(s);

            IMovable i;
            i=new MovablePoint(2,3);
            Console.WriteLine(i);
            i.MoveUp();
            Console.WriteLine(i);
            i.MoveRight();
            Console.WriteLine(i);
        }
        
    }
    
}