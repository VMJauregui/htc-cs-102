using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CombatSystem
{
    /// <summary>
    /// Interaction logic for LevelUp.xaml
    /// </summary>
    public partial class LevelUp : Window
    {
        Player player = new Player();
        string choice = "None";
        double MaxHealthUp = 0;
        double MaxManaUp = 0;
        double ManaRegenUp = 0;
        double AttackUp = 0;

        public LevelUp(double PlayerLevel, double PlayerExperience, double PlayerMaxHealth, double PlayerMaxMana, double PlayerManaRegen, double PlayerAttack)
        {
            InitializeComponent();
            player.Level = PlayerLevel;
            player.Experience = PlayerExperience;
            player.MaxHealth = PlayerMaxHealth;
            player.Health = player.MaxHealth;
            player.MaxMana = PlayerMaxMana;
            player.ManaRegen = PlayerManaRegen;
            player.Mana = player.MaxMana;
            player.Attack = PlayerAttack;
        }

        private void LevelUp_Click(object sender, RoutedEventArgs e)
        {
            if (choice == "MaxHealth")
            { MaxHealthUp = 1; }
            else if (choice == "MaxMana")
            { MaxManaUp = 1; }
            else if (choice == "ManaRegen")
            { ManaRegenUp = 0.25; }
            else if (choice == "Attack")
            { AttackUp = 0.25; }

            if (choice == "None")
            {
                MessageBox.Show("You need to choice a stat to improve!");
            }
            else
            {
                player.Experience = player.Experience - (player.Level * 10);

                player.LevelUp(player.Level, player.Experience, player.Health, player.MaxMana, player.ManaRegen, player.Attack, MaxHealthUp, MaxManaUp, ManaRegenUp, AttackUp);

                MaxHealthUp = 0;
                MaxManaUp = 0;
                ManaRegenUp = 0;
                AttackUp = 0;

                MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                this.Close();
                NextMainWindow.ShowDialog();
            }
        }

        private void Stats_Click(object sender, RoutedEventArgs e)
        {
            player.ShowStats();
        }

        private void Health_Click(object sender, RoutedEventArgs e)
        {
            choice = "MaxHealth";
        }

        private void MaxMana_Click(object sender, RoutedEventArgs e)
        {
            choice = "MaxMana";
        }

        private void ManaRegen_Click(object sender, RoutedEventArgs e)
        {
            choice = "ManaRegen";
        }

        private void Attack_Click(object sender, RoutedEventArgs e)
        {
            choice = "Attack";
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.Health, player.MaxMana, player.ManaRegen, player.Attack);
            this.Close();
            NextMainWindow.ShowDialog();
        }
    }
}
