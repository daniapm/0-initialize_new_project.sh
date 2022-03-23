﻿using System;
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

interface IInteractive {

    void Interact();
}

interface IBreakable {

    int durability
    {
        get;
        set;
    }

    void Break();

}

interface ICollectable {
    bool isCollected {
        get;
        set;
    }

    void Collect();
}

class Door : Base, IInteractive {

    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }

    public Door(string name="Door") {
        this.name = name;
    }
}

class Decoration : Base, IInteractive, IBreakable {

    public void isQuestItem {
        get;
        set;
    }

    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false)
    {
        if (durability > 0)
            this.durability = durability;
            this.name = name;
            this.isQuestItem = isQuestItem;
        else
        {
            throw new Exception("Durability must be greater than 0");
        }
    }

    public void Interact()
    {
        if (durability <= 0) {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if(isQuestItem is true) {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else if (isQuestItem is false) {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
        
    }

    public void Break()
    {
        this.durability -= 1;
        if (this.durability > 0)
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        else
            Console.WriteLine($"The {this.name} is already broken.");
    }
}
