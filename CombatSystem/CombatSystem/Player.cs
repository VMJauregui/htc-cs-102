using System;
using System.Windows;

namespace CombatSystem
{
    public class Player
    {
        public double Level = 1;

        public double Health = 10;

        public double MaxMana = 10;

        public double ManaRegen = 1;

        public double Mana = 10;

        public double Attack = 1;

        public bool FireBolt = true;
        public bool AirSlash= true;
        public bool Earth = true;
        public bool Water = true;
        public bool Heal = true;

        public Player() { }

        public void ShowStats()
        {
            string StatString = "Level: " + this.Level;
            StatString += "\nHealth: " + this.Health;
            StatString += "\nMaxMana: " + this.MaxMana;
            StatString += "\nManaRegen: " + Math.Floor(this.ManaRegen);
            StatString += "\nMana: " + this.Mana;
            StatString += "\nAttack: " + Math.Floor(this.Attack);
            MessageBox.Show(StatString);
        }

        public void LevelUp(double PlayerLevel, double PlayerHealth, double PlayerMaxMana, double PlayerManaRegen, double PlayerAttack, double PlayerHealthUp, double PlayerMaxManaUp, double PlayerManaRegenUp, double PlayerAttackUp)
        {
            Level = PlayerLevel + 1;
            Health = PlayerHealth + 1 + PlayerHealthUp;
            MaxMana = PlayerMaxMana + 1 + PlayerMaxManaUp;
            ManaRegen = PlayerManaRegen + 0.25 + PlayerManaRegenUp;
            Mana = MaxMana;
            Attack = PlayerAttack + 0.25 + PlayerAttackUp;
        }

    }
}
