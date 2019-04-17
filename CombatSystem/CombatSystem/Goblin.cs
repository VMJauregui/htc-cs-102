using System;
using System.Windows;

namespace CombatSystem
{
    public class Goblin : Enemy
    {
        public double GoblinLevel = 1;
        public double GoblinHealth = 1;
        public double GoblinMaxMana = 1;
        public double GoblinManaRegen = 1;
        public double GoblinMana = 1;
        public double GoblinAttack = 1;


        public Goblin(double PlayerLevel)
        {
            GoblinLevel = PlayerLevel * 2;
            GoblinHealth = GoblinLevel * 10;
            GoblinMaxMana = GoblinLevel * 10;
            GoblinManaRegen = GoblinLevel * 10;
            GoblinMana = GoblinMaxMana;
            GoblinAttack = GoblinLevel * 0.25;
        }
    }
}