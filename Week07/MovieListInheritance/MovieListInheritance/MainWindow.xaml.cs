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

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Movie> MovieList;

        public MainWindow()
        {
            InitializeComponent();

            MovieList = new ObservableCollection<Movie>();
            lvMovies.ItemsSource = MovieList;
        }

        private void AddMovieButton_Click(object sender, RoutedEventArgs e)
        {
            int releaseYear = 2003;

            try
            {
                releaseYear = int.Parse(releaseYearInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter in an int value for ReleaseYear.");
            }

            Movie movieToAdd = new Movie(titleInput.Text, int.Parse(releaseYearInput.Text));

            MovieList.Add(movieToAdd);

            titleInput.Clear();
            releaseYearInput.Clear();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie m in MovieList)
            {
                m.ShowDetails();
            }
        }

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                selectedMovie.ShowDetails();
            }
        }

        private void AddAnimatedMovieButton_Click(object sender, RoutedEventArgs e)
        {
            int releaseYear = 2003;
                
            try
            {
                releaseYear = int.Parse(releaseYearInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter in an int value for ReleaseYear.");
            }

            Movie movieToAdd = new AnimatedMovie(titleInput.Text, releaseYear, animationStudio.Text, animationType.Text);

            MovieList.Add(movieToAdd);

            titleInput.Clear();
            releaseYearInput.Clear();
            animationStudio.Clear();
            animationType.Clear();
        }
    }
}
