using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Cow : Animal
    {
        public int milkProduced;

        public Cow(int height, string name, int milkProduced)
        {
            this.name = name;
            this.height = height;
            this.milkProduced = milkProduced;
        }
        public void Moo()
        {
            MessageBox.Show(this.name + "produced " + this.milkProduced + " gallons of milk.");
        }

    }
}
