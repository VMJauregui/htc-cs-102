using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class WarElephant : Animal
    {
        public int KillSpeed; // (In Minutes)
        public void SpineCrush()
        {
            MessageBox.Show("*Screams and Snaps*");
        }

        public WarElephant()
        {

        }

        public WarElephant(int height, string name, int killSpeed)
        {
            Height = height;
            Name = name;
            KillSpeed = killSpeed;
        }
    }
}
