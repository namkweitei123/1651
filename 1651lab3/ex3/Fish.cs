
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3;

public class Fish:Animal,Pet
{
    public string Name{get;set;}
    public Fish():base(0)
    {
    }
    public void Play()
    {
        Console.WriteLine("Swimming around");
    }
    public override void Eat()
    {
        Console.WriteLine("Eat food on the water");
    }
    public override void Walk()
    {
        Console.WriteLine("Fish is swimming");
    }

}
