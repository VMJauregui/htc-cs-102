using System;
using System.Windows;

namespace CombatSystem
{
    public abstract class Enemy
    {
        public double EnemyLevel = 1;

        public double EnemyHealth = 1;

        public double EnemyMaxMana = 1;

        public double EnemyManaRegen = 1;

        public double EnemyMana = 1;

        public double EnemyAttack = 1;

        public Enemy() { }

    }
}