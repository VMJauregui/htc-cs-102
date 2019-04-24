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
                enemy = new Golem(player.Level);
            }
            else if ((player.Level > 10) & (MonsterSelector == 3))
            {
                enemy = new Dragon(player.Level);
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
                if (enemy.EnemyName == "Dragon")
                {
                    enemy.EnemyHealth = enemy.EnemyHealth - (Math.Floor(player.Attack / 2));
                    MessageBox.Show("The " + enemy.EnemyName + " was resistant to your fiery blast. \nThe " + enemy.EnemyName + " received " + (Math.Floor(player.Attack / 2)) + " damage.");

                }
                else
                {
                    enemy.EnemyHealth = enemy.EnemyHealth - Math.Floor(player.Attack);
                    MessageBox.Show("You burn the " + enemy.EnemyName + " with a fiery blast. \nThe " + enemy.EnemyName + " received " + Math.Floor(player.Attack) + " damage.");
                }
                if (enemy.EnemyHealth <= 0)
                {
                    MessageBox.Show("The " + enemy.EnemyName + " falls in combat. \n You have defeated your foe!");
                    player.Experience = player.Experience + (enemy.EnemyLevel * 2);
                    MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                    this.Close();
                    NextMainWindow.ShowDialog();
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

                if (player.Health <= 0)
                {
                    MessageBox.Show("You have been struck down in combat!");
                    MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                    this.Close();
                    NextMainWindow.ShowDialog();
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
                if (enemy.EnemyName == "Wolf")
                {
                    enemy.EnemyHealth = enemy.EnemyHealth - (Math.Floor(player.Attack / 2));
                    MessageBox.Show("The " + enemy.EnemyName + " was resistant to your blade of wind. \nThe " + enemy.EnemyName + " received " + (Math.Floor(player.Attack / 2)) + " damage.");
                }
                else
                {
                    player.Mana = player.Mana - 3;
                    enemy.EnemyHealth = enemy.EnemyHealth - Math.Floor(player.Attack);
                    MessageBox.Show("You lash the " + enemy.EnemyName + " with blade of wind. \nThe " + enemy.EnemyName + " received " + Math.Floor(player.Attack) + " damage.");
                }
                if (enemy.EnemyHealth <= 0)
                {
                    MessageBox.Show("The " + enemy.EnemyName + " falls in combat. \n You have defeated your foe!");
                    player.Experience = player.Experience + (enemy.EnemyLevel * 2);
                    MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                    this.Close();
                    NextMainWindow.ShowDialog();
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

                if (player.Health <= 0)
                {
                    MessageBox.Show("You have been struck down in combat!");
                    MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                    this.Close();
                    NextMainWindow.ShowDialog();
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
                if (enemy.EnemyName == "Goblin")
                {
                    enemy.EnemyHealth = enemy.EnemyHealth - (Math.Floor(player.Attack / 2));
                    MessageBox.Show("The " + enemy.EnemyName + " was resistant to your stream of water. \nThe " + enemy.EnemyName + " received " + (Math.Floor(player.Attack / 2)) + " damage.");
                }
                else
                {
                    player.Mana = player.Mana - 3;
                    enemy.EnemyHealth = enemy.EnemyHealth - Math.Floor(player.Attack);
                    MessageBox.Show("You whip the " + enemy.EnemyName + " with stream of water. \nThe " + enemy.EnemyName + " received " + Math.Floor(player.Attack) + " damage.");
                }
                if (enemy.EnemyHealth <= 0)
                {
                    MessageBox.Show("The " + enemy.EnemyName + " falls in combat. \n You have defeated your foe!");
                    player.Experience = player.Experience + (enemy.EnemyLevel * 2);
                    MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                    this.Close();
                    NextMainWindow.ShowDialog();
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

                if (player.Health <= 0)
                {
                    MessageBox.Show("You have been struck down in combat!");
                    MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                    this.Close();
                    NextMainWindow.ShowDialog();
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
                if (enemy.EnemyName == "Golem")
                {
                    enemy.EnemyHealth = enemy.EnemyHealth - (Math.Floor(player.Attack / 2));
                    MessageBox.Show("The " + enemy.EnemyName + " was resistant to your giant rock. \nThe " + enemy.EnemyName + " received " + (Math.Floor(player.Attack / 2)) + " damage.");
                }
                else
                {
                    player.Mana = player.Mana - 3;
                    enemy.EnemyHealth = enemy.EnemyHealth - Math.Floor(player.Attack);
                    MessageBox.Show("You smash the " + enemy.EnemyName + " with a giant rock. \nThe " + enemy.EnemyName + " received " + Math.Floor(player.Attack) + " damage.");
                }
                if (enemy.EnemyHealth <= 0)
                {
                    MessageBox.Show("The " + enemy.EnemyName + " falls in combat. \n You have defeated your foe!");
                    player.Experience = player.Experience + (enemy.EnemyLevel * 2);
                    MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                    this.Close();
                    NextMainWindow.ShowDialog();
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

                if (player.Health <= 0)
                {
                    MessageBox.Show("You have been struck down in combat!");
                    MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                    this.Close();
                    NextMainWindow.ShowDialog();
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
                player.Health = player.Health + (Math.Floor(player.Attack) * 4);
                if (player.Health > player.MaxHealth)
                {
                    player.Health = player.MaxHealth;
                    MessageBox.Show("You recover all of your lost health");
                }
                else
                {
                    MessageBox.Show("You recover " + (Math.Floor(player.Attack) * 4) + " health from your injuries.");
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

                if(player.Health <= 0)
                {
                    MessageBox.Show("You have been struck down in combat!");
                    MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                    this.Close();
                    NextMainWindow.ShowDialog();
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
            player.Mana = player.Mana + (Math.Floor(player.ManaRegen) * 2);
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

            if (player.Health <= 0)
            {
                MessageBox.Show("You have been struck down in combat!");
                MainWindow NextMainWindow = new MainWindow(player.Level, player.Experience, player.MaxHealth, player.MaxMana, player.ManaRegen, player.Attack);
                this.Close();
                NextMainWindow.ShowDialog();
            }
        }
    }
}
