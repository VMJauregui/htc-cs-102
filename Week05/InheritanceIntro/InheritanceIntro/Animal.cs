using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Animal : Organism
    {
        public string Name;
        public int Height;

        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }
    }
}
