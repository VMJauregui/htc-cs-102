using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Frog : Animal
    {
        public bool IsPoisonous;
        public void Ribbit()
        {
            MessageBox.Show("Ribbit");
        }

        public Frog()
        {

        }

        public Frog(int height, string name, bool isPoisonous)
        {
            Height = height;
            Name = name;
            IsPoisonous = isPoisonous;
        }
    }
}
