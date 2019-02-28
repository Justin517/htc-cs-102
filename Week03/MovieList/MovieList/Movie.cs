using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        private string movieName;
        private int releaseYear;
        private string Director;
        private int Length;
        private string Genre;

        public Movie (string Name, int ReleaseYear, string director, int length, string genre)
        {
            this.movieName = Name;
            this.releaseYear = ReleaseYear;
            this.Director = director;
            this.Length = length;
            this.Genre = genre;

        }
        public void ShowMovie()
        {
            MessageBox.Show(movieName + Environment.NewLine + releaseYear + Environment.NewLine + Director + Environment.NewLine + Length + Environment.NewLine + Genre );
        }
        
    }
}
