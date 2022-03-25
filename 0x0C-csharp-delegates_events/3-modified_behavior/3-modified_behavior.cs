using System;
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

    delegate void CalculateHealth(float demage);

    public void TakeDamage(float damage) {
        if (damage < 0f) {
            System.Console.WriteLine("{0} takes 0 damage!", this.name);
            damage = 0f;
        }
        else {
            System.Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        }
        this.hp -= damage;
        ValidateHP(this.hp);
        }

        public void HealDamage(float heal) {
            if (heal < 0f) {
                System.Console.WriteLine("{0} heals 0 HP!", this.name);
                heal = 0f;
        }
        else {
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        }
        this.hp += heal;
        ValidateHP(this.hp);
        }

        public void ValidateHP(float newHp) {
            if (newHp < 0f) {
                this.hp = 0f;
            }
            else if (newHp > this.maxHp) {
                this.hp = this.maxHp;
            }
            else {
                this.hp = newHp;
            }
        }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }
}

enum Modifier
{
    Weak,
    Base,
    Strong
}

delegate float CalculateModifier(float baseValue, Modifier modifier);
