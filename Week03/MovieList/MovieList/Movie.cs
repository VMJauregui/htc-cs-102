using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        private string movieName;
        private int releaseYear;
        private string director;
        private int length;
        private string genre;

        public Movie (string Name, int ReleaseYear, string Director, int Length, string Genre)
        {
            //this. is not needed.
            this.movieName = Name;
            this.releaseYear = ReleaseYear;
            this.director = Director;
            this.length = Length;
            this.genre = Genre;
        }

        public void ShowMovie()
        {
            MessageBox.Show(movieName + Environment.NewLine + releaseYear + Environment.NewLine + director + Environment.NewLine + length + Environment.NewLine + genre);
        }
    }
}
