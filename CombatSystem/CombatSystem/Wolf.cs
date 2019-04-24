using System;
using System.Windows;

namespace CombatSystem
{
    public class Wolf : Enemy
    {
        public Wolf(double PlayerLevel)
        {
            EnemyName = "Wolf";
            EnemyLevel = PlayerLevel * 3;
            EnemyMaxHealth = 5 + (PlayerLevel * 3);
            EnemyHealth = EnemyMaxHealth;
            EnemyAttack = 1 + (PlayerLevel * 0.3);
        }
    }
}