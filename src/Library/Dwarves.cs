using System;

namespace Library
{
    public class Dwarves
    {
        private string Name { get; set; }

        public int Damage { get; set; }     

        public int Defense { get; set; }

        public int Health { get; set; }

        public Items weapon { get; set; }

        public Items armour { get; set; }

        public bool Broken { get; set; }

        public int HealSkill { get; set; }


        public Dwarves(string name)
        {
            this.Name = name; 
            this.Damage = 25;
            this.Defense = 70;
            this.Health = 100;
            this.Broken = false;
            this.HealSkill = 20;
        }

        public int getAttack()
        {
            Console.WriteLine($"El daño de Julio es {this.Damage}");
            return this.Damage;
        }
 
        public int getDefense()
        {
            Console.WriteLine($"La defensa de Julio es {this.Defense}");
            return this.Defense;
        }

        public void EquipWeapons(Items item)
        {
            if(Broken == false)
            {
                this.Damage = this.Damage + item.Damage;
                this.Defense = this.Defense + item.Defense;
                this.Health = this.Health + this.Defense;
                
            }
        }

        public void AddSword(Items item)
        {
            if(Broken == false)
            {
                this.Damage = this.Damage + item.Damage;
                this.Defense = this.Defense + item.Defense;
                this.Health = this.Health + this.Defense;
                
            }
        }

        public void UnequipWeapons(Items item)
        {
            if(Broken == true)
            {
                this.Damage = this.Damage - item.Damage;
                this.Defense = this.Defense - item.Defense;
                this.Health = this.Health - this.Defense;
                
            }
        }

        public bool IfWeaponIsBroken(Items item){
            if(item.Duration == 0){
                item.Broken = true;
            }
            return item.Broken;
        } 
        
        public void Attack(Dwarves enemy){
            int i = 0;
                while(enemy.Health > 0 && i == 0){
                    enemy.Health = enemy.Health - this.Damage;
                    Console.WriteLine($"Al enemigo le queda {enemy.Health} de vida despues del ataque");
                    i = i + 1;
                } 
        }

        public void Heal(Dwarves ally){
            while(ally.Health > 0 && ally.Health < 100){
                    ally.Health = ally.Health + this.HealSkill;
                    if (ally.Health > 100){
                        ally.Health = 100;
                    }
                    Console.WriteLine($"La vida del aliado es {ally.Health} despues de curarlo");

            }  
        }
                         
    }
    
}