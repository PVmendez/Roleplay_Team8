using System;

namespace Library
{
    public class Items
    {
        ///private int damage {get; set;}

        public string Name { get; private set; }

        public int Damage { get; private set; }

        public int Defense { get; private set; }

        public int Duration { get; private set; }

        public bool Broken { get; set; }

        public Items (int damage, int defense, string name)
        {
            this.Name = name;
            this.Damage = damage;
            this.Defense = defense;
            this.Duration = 100;
            this.Broken = false;
        }

        public int GetDamage()
        {
            return this.Damage;
        }
        public string GetName()
        {
            return this.Name;
        }

        public bool IfWeaponIsBroken(){
            if(this.Duration == 0){
                this.Broken = true;
            }
            return this.Broken;
        }   
    }
} 