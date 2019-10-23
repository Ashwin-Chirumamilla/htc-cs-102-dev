using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace MovieList
{
    public class Movie 
    {
        public string Title;
        public DateTime releaseYear { get; set; }
        public string director;
        public int length;
        public string genre;
        public string poster;
        public double rottenTomatoesScore;
        public Movie(string title, DateTime release, string director, int length, string genre, string poster, double rottenScore)
        {
            Title = title;
            releaseYear = release;
            this.director = director;
            this.poster = poster;
            this.length = length;
            this.genre = genre;
            this.rottenTomatoesScore = rottenScore;

            
        }

        public void ShowDetails()
        {
            MessageBox.Show(Title + " was released in " + releaseYear + ", directed by " + director + ", is " + length + " hours long, is a " + genre + ", and has a rotten tomatoes of " + rottenTomatoesScore);
        }
    }
    
}
