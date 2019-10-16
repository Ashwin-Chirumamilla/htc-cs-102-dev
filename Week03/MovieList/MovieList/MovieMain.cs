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
        public int releaseYear;
        public string director;
        public int length;
        public string genre;
        public string poster;
        public Movie(string title, int release, string director, int length, string genre, string poster)
        {
            Title = title;
            releaseYear = release;
            this.director = director;
            this.length = length;
            this.genre = genre;
        }

        public void ShowDetails()
        {
            MessageBox.Show(Title + " was released in " + releaseYear + ", directed by " + director + ", is " + length + " hours long, and is a " + genre);
        }
    }
    
}
