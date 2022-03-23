using System;
using System.Collections.Generic;

abstract class Base
{
    public string name {
        get;
        set;
    }

    public override string ToString()
    {
        return ($"{this.name} is a {this.GetType()}");
    }
}
