
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3{

public abstract class Animal
{
    public int Legs{get;}
    
    public Animal(){
        Legs=0;
    }
    protected Animal(int legs){
        this.Legs=legs;
    }
    public virtual void Walk(){
        Console.WriteLine("Go to straight");
    }
    public abstract void Eat();
}
}