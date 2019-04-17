using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    class AnimatedMovie : Movie
    {
        public string AnimationStudio
        {
            get;
            set;
        }

        public string AnimationType
        {
            get;
            set;
        }

        public AnimatedMovie(string myTitle, int myReleaseYear, string myAnimationStudio, string myAnimationType)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
            this.AnimationStudio = myAnimationStudio;
            this.AnimationType = myAnimationType;
        }

        public override void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            infoString += "\nAnimation Studio: " + this.AnimationStudio;
            infoString += "\nAnimation Type: " + this.AnimationType;
            MessageBox.Show(infoString);
        }

    }
}
