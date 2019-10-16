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

        public MainWindow()
        {
            InitializeComponent();

        }

        private void addMovie_Click(object sender, RoutedEventArgs e)
        {
            movies.Add(new Movie(movieTitle.Text, Convert.ToInt32(releaseYear.Text), directorName.Text, Convert.ToInt32(movieLength.Text), movieGenre.Text, posterFile.Text));
            movieTitle.Text = "";
            releaseYear.Text = "";
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
            
            BitmapImage poster = new BitmapImage();
            poster.BeginInit();
            poster.UriSource = new Uri(posterFile.Text);
            poster.EndInit();
            moviePoster.Source = poster;


        }
    }
}
