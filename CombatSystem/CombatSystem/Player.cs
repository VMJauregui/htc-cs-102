using System;
using System.Windows;

namespace CombatSystem
{
    public class Player
    {
        public double Level = 1;

        public double Health = 1;

        public double MaxMana = 1;

        public double ManaRegen = 1;

        public double Mana = 1;

        public double Attack = 1;

        public Player() { }

        public Player(double PlayerLevel, double PlayerHealth, double PlayerMaxMana, double PlayerManaRegen, double PlayerMana, double PlayerAttack)
        {
            Level = PlayerLevel;
            Health = PlayerHealth;
            MaxMana = PlayerMaxMana;
            ManaRegen = PlayerManaRegen;
            Mana = PlayerMana;
            Attack = PlayerAttack;
        }

    }
}
