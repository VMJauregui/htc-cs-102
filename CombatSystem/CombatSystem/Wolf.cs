using System;
using System.Windows;

namespace CombatSystem
{
    public class Wolf : Enemy
    {
        public double WolfLevel = 1;
        public double WolfHealth = 1;
        public double WolfMaxMana = 1;
        public double WolfManaRegen = 1;
        public double WolfMana = 1;
        public double WolfAttack = 1;

        public Wolf(double PlayerLevel)
        {
            WolfLevel = PlayerLevel * 2;
            WolfHealth = WolfLevel;
            WolfMana = WolfLevel;
            WolfManaRegen = WolfLevel * 0.5;
            WolfMana = WolfLevel;
            WolfAttack = WolfLevel * 0.5;
        }
    }
}