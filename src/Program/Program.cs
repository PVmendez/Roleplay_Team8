using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarves D1 = new Dwarves("Julio");
            Dwarves D2 = new Dwarves("Julio");
            Items Martillo = new Items(10, 40, "Goloso");
            D1.getAttack();
            D1.getDefense();
            D1.Attack(D2);
            D1.Heal(D2);
            D1.EquipWeapons(Martillo);
            D1.UnequipWeapons(Martillo);
        }
    }
}
