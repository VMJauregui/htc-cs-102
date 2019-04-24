using System;
using System.Windows;

namespace CombatSystem
{
    public class Wolf : Enemy
    {
        public string WolfName = "Wolf";
        public double WolfLevel = 1;
        public double WolfHealth = 1;
        public double WolfAttack = 1;

        public Wolf(double PlayerLevel)
        {
            EnemyName = WolfName;
            EnemyLevel = PlayerLevel;
            EnemyMaxHealth = 5 + (PlayerLevel * 2);
            EnemyHealth = EnemyMaxHealth;
            EnemyAttack = 1 + (PlayerLevel * 0.4);
        }
    }
}