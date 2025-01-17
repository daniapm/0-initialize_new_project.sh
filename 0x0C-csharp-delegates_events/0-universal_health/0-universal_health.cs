﻿using System;
using System.Collections.Generic;

class Player
{
    private string name;
    private float maxHp;
    private float hp;

    public Player(string name="Player", float maxHp=100f) {
        
        if (maxHp <= 0f) {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else {
            this.maxHp = maxHp;
        }
        this.name = name;
        this.hp = this.maxHp;
    }

    public void PrintHealth() {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
}
