using System;
using System.Collections.Generic;

public class Player
{
    private String name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }

    public Player(string name="Player", float maxHp=100f) {
        
        if (maxHp > 0f) {
            this.maxHp = maxHp;
        }
        else {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
            
        }
        this.name = name;
        this.hp = this.maxHp;
    }

    public void PrintHealth() {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
