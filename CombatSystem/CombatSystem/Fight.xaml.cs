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
        public Fight()
        {
            InitializeComponent();
        }

        private void CheckStats_Click(object sender, RoutedEventArgs e)
        {
            player.ShowStats();
        }
    }
}
