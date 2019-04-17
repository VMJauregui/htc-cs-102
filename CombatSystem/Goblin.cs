using System;
using System.Windows;

namespace CombatSystem
{
    public class Goblin : Enemy
    {
        public Goblin(double GoblinLevel, double GoblinHealth, double GoblinMaxMana, double GoblinManaRegen, double GoblinMana, double GoblinAttack)
        {
            GoblinLevel = EnemyLevel;
            GoblinHealth = GoblinLevel;
            GoblinMana = GoblinLevel;
            GoblinManaRegen = GoblinLevel * 0.5;
            GoblinMana = EnemyMana;
            GoblinAttack = EnemyAttack * 0.25;
        }
    }
}