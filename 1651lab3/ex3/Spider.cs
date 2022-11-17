
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3;

public class Spider : Animal
{   

    public Spider(): base(8)
    {
    }
    public override void Eat(){
        Console.WriteLine("Spider is Eating");
    }
    public override string ToString()
    {
        return "Spider has "+Legs+" legs";
    }
}
