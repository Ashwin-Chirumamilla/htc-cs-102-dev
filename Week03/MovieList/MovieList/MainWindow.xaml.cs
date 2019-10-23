using System;
using System.Collections.Generic;
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
        List<Movie> movies = new List<Movie>();
        int movieCycle = 0;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void addMovie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                movies.Add(new Movie(movieTitle.Text, releaseYear.SelectedDate, directorName.Text, Convert.ToInt32(movieLength.Text), movieGenre.Text, posterFile.Text, Convert.ToDouble(rottenTomatoes.Text)));
                MessageBox.Show("The movie was successfully added to your list.");
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an error in your Movie Data.");
     
            }
            for(int i =0; i < movies.Count - 1; i++)
            {
                Movie listMovie = movies[i];
                Movie currentMovie = movies[movies.Count - 1];
                if (currentMovie.Title == listMovie.Title)
                {
                    movies.RemoveAt(movies.Count - 1);
                    MessageBox.Show("You already added a movie with that title");
                    break;
                }
            }
            movieTitle.Text = "";
            releaseYear.Text = "";
            directorName.Text = "";
            movieLength.Text = "";
            movieGenre.Text = "";
            posterFile.Text = "";
            rottenTomatoes.Text = "";

            
        }

        private void showMovies_Click(object sender, RoutedEventArgs e)
        {
            
            for(int i =0; i < movies.Count; i++)
            {
                Movie currentMovie = movies[i];
                currentMovie.ShowDetails();
            }
        }

        private void rotatePosters_Click(object sender, RoutedEventArgs e)
        {
                
               Movie currentMovie = movies[movieCycle];
                BitmapImage poster = new BitmapImage();
                poster.BeginInit();
                poster.UriSource = new Uri(currentMovie.poster);
                poster.EndInit();
                moviePoster.Source = poster;
            if (movieCycle < movies.Count - 1)
            {
                movieCycle++;
            }
            else
            {
                movieCycle = 0;
            }
        }
    }
}
