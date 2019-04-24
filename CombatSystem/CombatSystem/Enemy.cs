using System;
using System.Windows;

namespace CombatSystem
{
    public abstract class Enemy
    {
        public string EnemyName = "Monster";

        public double EnemyLevel = 1;

        public double EnemyMaxHealth = 1;

        public double EnemyHealth = 1;
        
        public double EnemyAttack = 1;

        public Enemy() { }

        public void ShowStats()
        {
            string StatString = "Name: " + this.EnemyName;
            StatString += "\nLevel: " + this.EnemyLevel;
            StatString += "\nMax Health: " + this.EnemyMaxHealth;
            StatString += "\nCurrent Health: " + this.EnemyHealth;
            StatString += "\nAttack: " + Math.Floor(this.EnemyAttack);
            MessageBox.Show(StatString);
        }

    }
}