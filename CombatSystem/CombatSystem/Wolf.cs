using System;
using System.Windows;

namespace CombatSystem
{
    public class Wolf : Enemy
    {
        public Wolf(double WolfLevel, double WolfHealth, double WolfMaxMana, double WolfManaRegen, double WolfMana, double WolfAttack)
        {
            WolfLevel = EnemyLevel * 2;
            WolfHealth = WolfLevel;
            WolfMana = WolfLevel;
            WolfManaRegen = WolfLevel * 0.5;
            WolfMana = WolfLevel;
            WolfAttack = WolfLevel * 0.5;
        }
    }
}