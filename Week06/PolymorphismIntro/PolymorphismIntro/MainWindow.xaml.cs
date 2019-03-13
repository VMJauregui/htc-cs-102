using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;

        public MainWindow()
        {
            InitializeComponent();

            Animals = new ObservableCollection<Animal>();
            
            Frog frog = new Frog(3, "Kermit", false, 1);
            Dog dog = new Dog("Rapper", 6, "Snoop", 150);
            Duck duck = new Duck(5, "Donald", 120);
            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);

            Frog jeremiah = new Frog(3, "Jeremiah", false, 2);
            Dog clifford = new Dog("Big Red Dog", 25, "Clifford", 174000);
            Duck daffy = new Duck(4, "Daffy", 150);
            Animals.Add(jeremiah);
            Animals.Add(daffy);
            Animals.Add(clifford);

            lvAnimals.ItemsSource = Animals;
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Ribbit();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(Animal animal in Animals)
            {
                animal.SayName();
            }

        }

        private void lvAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (object selectedItem in lvAnimals.SelectedItems)
            {
                Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
                if (selectedAnimal != null)
                {
                    selectedAnimal.Speak();
                }
            }
        }
    }
}
