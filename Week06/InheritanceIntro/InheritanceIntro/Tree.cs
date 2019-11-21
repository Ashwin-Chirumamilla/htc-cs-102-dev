using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace InheritanceIntro
{
    class Tree : Organism
    {
        public int height;
        public string species;
        public bool hermaphroditic;
        public Tree(int height, string species, bool hermaphroditic)
        {
            this.height = height;
            this.species = species;
            this.hermaphroditic = hermaphroditic;
        }

        public void Reproduce()
        {
           if (hermaphroditic)
            {
                Random rnd = new Random();
                int seeds = rnd.Next(1, 11);
                MessageBox.Show("The tree produced " + seeds + " seeds"); 
            }
           else
            {
                MessageBox.Show("The tree was not able to produce the correct gamete to reproduce");
            }
        }
    }
}
