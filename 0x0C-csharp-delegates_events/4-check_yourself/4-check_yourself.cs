using System;
using System.Collections.Generic;
using System.Dynamic;

class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    private void CheckStatus(object sender, CurrentHPArgs e) {
        if (e.currentHp == this.maxHp) {
            this.status = $"{this.name} is in perfect health!";
        }
        else if (e.currentHp >= (this.maxHp * 0.5f) && e.currentHp < this.maxHp) {
            this.status = $"{this.name} is doing well!";
        }
        else if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp * 0.5f)) {
            this.status = $"{this.name} isn't doing too great...";
        }
        else if (e.currentHp > 0f && e.currentHp < (this.maxHp * 0.5f)) {
            this.status = $"{this.name} needs help!";
        }
        else {
           this.status = $"{this.name} is knocked out!";
        }
        Console.WriteLine(this.status);
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
            HPCheck(this, new CurrentHPArgs(this.hp));
        }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak) {
            return baseValue * 0.5f;
        }
        else if (modifier == Modifier.Base) {
            return baseValue;
        }
        else {
            return baseValue * 1.5f;
        }    
    }

    public event EventHandler<CurrentHPArgs> HPCheck;
}

enum Modifier
{
    Weak,
    Base,
    Strong
}

delegate float CalculateModifier(float baseValue, Modifier modifier);

class CurrentHPArgs : EventArgs {

    public readonly float currentHp;

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
