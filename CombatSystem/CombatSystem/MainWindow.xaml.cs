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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CombatSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Player player = new Player();

        public MainWindow()
        {
            InitializeComponent();

            textBlock.FontSize = 20;
            textBlock.Text = "\n \n \n Have fun playing this trial combat system!";
        }

        public MainWindow(double PlayerLevel, double PlayerExperience, double PlayerMaxHealth, double PlayerMaxMana, double PlayerManaRegen, double PlayerAttack)
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

        private void FindNewEnemy_Click(object sender, RoutedEventArgs e)
        {
            Fight NextFight = new Fight(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
            this.Close();
            NextFight.ShowDialog();
        }

        private void Stats_Click(object sender, RoutedEventArgs e)
        {
            player.ShowStats();
        }

        private void LevelUp_Click(object sender, RoutedEventArgs e)
        {
            if (player.Experience >= (player.Level * 10))
            {
                LevelUp NextLevel = new LevelUp(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                this.Close();
                NextLevel.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have enough Experience to level up.");
            }
        }

        private void ExperienceUp_Click(object sender, RoutedEventArgs e)
        {
            player.Experience = player.Experience + 12;
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for playing!");
            this.Close();
        }
    }
}
