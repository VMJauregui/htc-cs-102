using System;
using System.Windows;

namespace CombatSystem
{
    public class Player
    {
        public double Level = 1;

        public double Experience = 0;

        public double MaxHealth = 10;

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
            StatString += "\nExperience: " + this.Experience;
            StatString += "\nMax Health: " + this.MaxHealth;
            StatString += "\nCurrent Health: " + this.Health;
            StatString += "\nMaxMana: " + this.MaxMana;
            StatString += "\nCurrent Mana: " + this.Mana;
            StatString += "\nManaRegen: " + Math.Floor(this.ManaRegen);
            StatString += "\nAttack: " + Math.Floor(this.Attack);
            MessageBox.Show(StatString);
        }

        public void LevelUp(double PlayerLevel, double PlayerExperience, double PlayerMaxHealth, double PlayerMaxMana, double PlayerManaRegen, double PlayerAttack, double PlayerMaxHealthUp, double PlayerMaxManaUp, double PlayerManaRegenUp, double PlayerAttackUp)
        {
            Level = PlayerLevel + 1;
            Experience = PlayerExperience;
            MaxHealth = PlayerMaxHealth + 1 + PlayerMaxHealthUp;
            Health = MaxHealth;
            MaxMana = PlayerMaxMana + 1 + PlayerMaxManaUp;
            ManaRegen = PlayerManaRegen + 0.3 + PlayerManaRegenUp;
            Mana = MaxMana;
            Attack = PlayerAttack + 0.3 + PlayerAttackUp;
        }

    }
}
