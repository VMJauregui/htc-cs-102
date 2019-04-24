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
        string choice = "Hello World";
        double HealthUp = 0;
        double MaxManaUp = 0;
        double ManaRegenUp = 0;
        double AttackUp = 0;

        public LevelUp()
        {
            InitializeComponent();
        }

        private void LevelUp_Click(object sender, RoutedEventArgs e)
        {
            if (choice == "Health")
            { HealthUp = 1; }
            else if (choice == "MaxMana")
            { MaxManaUp = 1; }
            else if (choice == "ManaRegen")
            { ManaRegenUp = 0.25; }
            else if (choice == "Attack")
            { AttackUp = 0.25; }

            player.LevelUp(player.Level, player.Health, player.MaxMana, player.ManaRegen, player.Attack, HealthUp, MaxManaUp, ManaRegenUp, AttackUp);

        }

        private void Stats_Click(object sender, RoutedEventArgs e)
        {
            player.ShowStats();
        }

        private void Health_Click(object sender, RoutedEventArgs e)
        {
            choice = "Health";
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
    }
}
