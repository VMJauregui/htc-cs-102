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
    /// Interaction logic for Fight.xaml
    /// </summary>
    public partial class Fight : Window
    {
        Player player = new Player();
        Random RandomNumber = new Random();
        int MonsterSelector = 1;

        Enemy enemy = null;

        public Fight(double PlayerLevel, double PlayerExperience, double PlayerMaxHealth, double PlayerMaxMana, double PlayerManaRegen, double PlayerAttack)
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

            MonsterSelector = Convert.ToInt32(RandomNumber.Next(0,4));
            if ((player.Level > 0) & (MonsterSelector == 0))
            {
                enemy = new Goblin(player.Level);
            }
            else if ((player.Level > 1) & (MonsterSelector == 1))
            {
                enemy = new Wolf(player.Level);
            }
            else if ((player.Level > 5) & (MonsterSelector == 2))
            {
                MessageBox.Show("Golems do not exist yet.");
            }
            else if ((player.Level > 10) & (MonsterSelector == 3))
            {
                MessageBox.Show("Dragons do not exist yet.");
            }
            else if ((player.Level > 1) & (MonsterSelector == 3))
            {
                enemy = new Wolf(player.Level);
            }
            else
            {
                enemy = new Goblin(player.Level);
            }
            
        }

        private void CheckStats_Click(object sender, RoutedEventArgs e)
        {
            player.ShowStats();
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
            this.Close();
            NextMainWindow.ShowDialog();
        }

        private void CheckEnemyStats_Click(object sender, RoutedEventArgs e)
        {
            if (enemy != null)
            {
                enemy.ShowStats();
            }
            else
            {
                MessageBox.Show("There is nothing here.");
            }
        }

        private void FireBolt_Click(object sender, RoutedEventArgs e)
        {
            if (player.Mana > 3)
            {
                player.Mana = player.Mana - 3;
                enemy.EnemyHealth = enemy.EnemyHealth - Math.Floor(player.Attack);
                MessageBox.Show("You burn the " + enemy.EnemyName + " with a firey blast. \nThe " + enemy.EnemyName + " received " + Math.Floor(player.Attack) + " damage.");

                player.Health = player.Health - Math.Floor(enemy.EnemyAttack);
                if (enemy.EnemyName == "Goblin")
                {
                    MessageBox.Show("The Goblin stabs you with its knife. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Wolf")
                {
                    MessageBox.Show("The Wolf bites you with its fangs. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Golem")
                {
                    MessageBox.Show("The Golem throws a boulder at you. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Dragon")
                {
                    MessageBox.Show("The Dragon burns you with its fiery breath. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                
                player.Mana = player.Mana + Math.Floor(player.ManaRegen);
                if (player.Mana > player.MaxMana)
                {
                    player.Mana = player.MaxMana;
                }
            }
            else
            {
                MessageBox.Show("You do not have enough mana to cast this spell.");
            }
        }

        private void AirLash_Click(object sender, RoutedEventArgs e)
        {
            if (player.Mana > 3)
            {
                player.Mana = player.Mana - 3;
                enemy.EnemyHealth = enemy.EnemyHealth - Math.Floor(player.Attack);
                MessageBox.Show("You lash the " + enemy.EnemyName + " with blade of wind. \nThe " + enemy.EnemyName + " received " + Math.Floor(player.Attack) + " damage.");

                player.Health = player.Health - Math.Floor(enemy.EnemyAttack);
                if (enemy.EnemyName == "Goblin")
                {
                    MessageBox.Show("The Goblin stabs you with its knife. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Wolf")
                {
                    MessageBox.Show("The Wolf bites you with its fangs. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Golem")
                {
                    MessageBox.Show("The Golem throws a boulder at you. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Dragon")
                {
                    MessageBox.Show("The Dragon burns you with its fiery breath. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }

                player.Mana = player.Mana + Math.Floor(player.ManaRegen);
                if (player.Mana > player.MaxMana)
                {
                    player.Mana = player.MaxMana;
                }
            }
            else
            {
                MessageBox.Show("You do not have enough mana to cast this spell.");
            }
        }

        private void WaterWhip_Click(object sender, RoutedEventArgs e)
        {
            if (player.Mana > 3)
            {
                player.Mana = player.Mana - 3;
                enemy.EnemyHealth = enemy.EnemyHealth - Math.Floor(player.Attack);
                MessageBox.Show("You whip the " + enemy.EnemyName + " with stream of water. \nThe " + enemy.EnemyName + " received " + Math.Floor(player.Attack) + " damage.");

                player.Health = player.Health - Math.Floor(enemy.EnemyAttack);
                if (enemy.EnemyName == "Goblin")
                {
                    MessageBox.Show("The Goblin stabs you with its knife. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Wolf")
                {
                    MessageBox.Show("The Wolf bites you with its fangs. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Golem")
                {
                    MessageBox.Show("The Golem throws a boulder at you. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Dragon")
                {
                    MessageBox.Show("The Dragon burns you with its fiery breath. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }

                player.Mana = player.Mana + Math.Floor(player.ManaRegen);
                if (player.Mana > player.MaxMana)
                {
                    player.Mana = player.MaxMana;
                }
            }
            else
            {
                MessageBox.Show("You do not have enough mana to cast this spell.");
            }
        }

        private void RockSmash_Click(object sender, RoutedEventArgs e)
        {
            if (player.Mana > 3)
            {
                player.Mana = player.Mana - 3;
                enemy.EnemyHealth = enemy.EnemyHealth - Math.Floor(player.Attack);
                MessageBox.Show("You smash the " + enemy.EnemyName + " with giant of hunk of rock. \nThe " + enemy.EnemyName + " received " + Math.Floor(player.Attack) + " damage.");

                player.Health = player.Health - Math.Floor(enemy.EnemyAttack);
                if (enemy.EnemyName == "Goblin")
                {
                    MessageBox.Show("The Goblin stabs you with its knife. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Wolf")
                {
                    MessageBox.Show("The Wolf bites you with its fangs. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Golem")
                {
                    MessageBox.Show("The Golem throws a boulder at you. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Dragon")
                {
                    MessageBox.Show("The Dragon burns you with its fiery breath. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }

                player.Mana = player.Mana + Math.Floor(player.ManaRegen);
                if (player.Mana > player.MaxMana)
                {
                    player.Mana = player.MaxMana;
                }
            }
            else
            {
                MessageBox.Show("You do not have enough mana to cast this spell.");
            }
        }

        private void Heal_Click(object sender, RoutedEventArgs e)
        {
            if (player.Mana > 3)
            {
                player.Mana = player.Mana - 3;
                player.Health = player.Health + (Math.Floor(player.Attack) * 5);
                if (player.Health > player.MaxHealth)
                {
                    player.Health = player.MaxHealth;
                    MessageBox.Show("You recover all of your lost health");
                }
                else
                {
                    MessageBox.Show("You recover " + (Math.Floor(player.Attack) * 5) + " health from your injuries.");
                }
                
                player.Health = player.Health - Math.Floor(enemy.EnemyAttack);
                if (enemy.EnemyName == "Goblin")
                {
                    MessageBox.Show("The Goblin stabs you with its knife. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Wolf")
                {
                    MessageBox.Show("The Wolf bites you with its fangs. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Golem")
                {
                    MessageBox.Show("The Golem throws a boulder at you. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }
                else if (enemy.EnemyName == "Dragon")
                {
                    MessageBox.Show("The Dragon burns you with its fiery breath. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
                }

                player.Mana = player.Mana + Math.Floor(player.ManaRegen);
                if (player.Mana > player.MaxMana)
                {
                    player.Mana = player.MaxMana;
                }
            }
            else
            {
                MessageBox.Show("You do not have enough mana to cast this spell.");
            }
            
        }

        private void Recover_Click(object sender, RoutedEventArgs e)
        {
            player.Mana = player.Mana + (player.ManaRegen * 2);
            if (player.Mana > player.MaxMana)
            {
                player.Mana = player.MaxMana;
                MessageBox.Show("You recover all of your lost Mana");
            }
            else
            {
                MessageBox.Show("You recover " + (Math.Floor(player.ManaRegen) * 2) + " Mana.");
            }
            
            player.Health = player.Health - Math.Floor(enemy.EnemyAttack);
            if (enemy.EnemyName == "Goblin")
            {
                MessageBox.Show("The Goblin stabs you with its knife. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
            }
            else if (enemy.EnemyName == "Wolf")
            {
                MessageBox.Show("The Wolf bites you with its fangs. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
            }
            else if (enemy.EnemyName == "Golem")
            {
                MessageBox.Show("The Golem throws a boulder at you. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
            }
            else if (enemy.EnemyName == "Dragon")
            {
                MessageBox.Show("The Dragon burns you with its fiery breath. \nYou received " + Math.Floor(enemy.EnemyAttack) + " damage.");
            }
        }
    }
}
