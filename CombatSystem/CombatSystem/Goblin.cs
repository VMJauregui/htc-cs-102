using System;
using System.Windows;

namespace CombatSystem
{
    public class Goblin : Enemy
    {
        public Goblin(double PlayerLevel)
        {
            EnemyName = "Goblin";
            EnemyLevel = PlayerLevel * 2;
            EnemyMaxHealth = 5 + (PlayerLevel * 2);
            EnemyHealth = EnemyMaxHealth;
            EnemyAttack = 1 + (PlayerLevel * 0.3);
        }
        
    }
}