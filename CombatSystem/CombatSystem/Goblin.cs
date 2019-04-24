using System;
using System.Windows;

namespace CombatSystem
{
    public class Goblin : Enemy
    {
        public string GoblinName = "Goblin";
        public double GoblinLevel = 1;
        public double GoblinHealth = 1;
        public double GoblinAttack = 1;


        public Goblin(double PlayerLevel)
        {
            EnemyName = GoblinName;
            EnemyLevel = PlayerLevel * 2;
            EnemyMaxHealth = 5 + (PlayerLevel * 2);
            EnemyHealth = EnemyMaxHealth;
            EnemyAttack = 1 + (PlayerLevel * 0.2);
        }
        
    }
}