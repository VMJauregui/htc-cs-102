using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    class Class1
    {
    }
}



namespace ClassesIntro
{
    public class Restaurant
    {
        public string restaurantName;
        public int restaurantNumber;
        public int employeeCount;
        public double profits;
        public double expenses;

        public void Report()
        {
            MessageBox.Show("Our restaurant name is " + restaurantName);
            MessageBox.Show("We are restaurant number " + restaurantNumber);
            MessageBox.Show("We have " + employeeCount + " employees");
            MessageBox.Show("Our profits were " + profits);
            MessageBox.Show("Our expenses were " + expenses);
        }

    }
}