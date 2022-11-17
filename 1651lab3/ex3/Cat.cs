using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3;

public class Cat : Animal,Pet
{

    public string Name{get;set;}
    public Cat()
    {
        Name="";
    }
    public Cat(string name):base(4)
    {
        this.Name=name;
    }
    public void Play(){
        Console.WriteLine("Run around");
    }
    public override void Eat()
    {
        Console.WriteLine("Cat is Eating");
    }
    public override string ToString()
    {
        return "Cat has "+Legs+" legs";
    }
}
