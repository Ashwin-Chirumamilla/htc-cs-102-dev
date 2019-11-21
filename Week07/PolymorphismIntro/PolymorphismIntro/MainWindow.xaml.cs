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

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Animal> Animals;

        public MainWindow()
        {
            InitializeComponent();
            Animals = new List<Animal>();
            Frog frog = new PolymorphismIntro.Frog(4, "Kermit", false, 25);
            Dog dog = new PolymorphismIntro.Dog("Muppet", 20, "Rolf", 70);
            Duck duck = new Duck(9, "Donald", 35);
            Dog Clifford = new PolymorphismIntro.Dog("terrier", 200, "Clifford", 1000);
            Duck Daffy = new Duck(5, "Daffy", 60);
            Frog Jerimiah = new Frog(3, "Jerimiah", true, 15);

            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);
            Animals.Add(Clifford);
            Animals.Add(Daffy);
            Animals.Add(Jerimiah);
            lvAnimals.ItemsSource = Animals;

            foreach (Animal a in Animals)
            {
                a.SayName();
            }
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Speak();
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Speak();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Speak();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            // Define a new List of dogs
            List<Dog> dogs = new List<Dog>();
            
            // Instantiate some dog objects
            Dog dog1 = new Dog("Muppet", 20, "Rolf", 21);
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud", 21 );

            // Add the dogs to the list
            dogs.Add(dog1);
            dogs.Add(dog2);

            // Loop through the list and call a method on the objects
            foreach (Dog d in dogs)
            {
                d.SayName();
            }

            // Ducks and Frogs
            Duck duck1 = new Duck(9, "Donald", 22);
            duck1.SayName();

            Frog frog1 = new Frog(4, "Kermit", false);
            frog1.SayName();
        }

        private void lvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                selectedAnimal.Speak();
            }
        }
    }
}
