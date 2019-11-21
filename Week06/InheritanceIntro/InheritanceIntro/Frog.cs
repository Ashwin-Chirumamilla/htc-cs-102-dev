using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Frog : Animal
    {
        public bool isPoisonous;
        public Frog(int height, string name, bool isPoisonous)
        {
            this.height = height;
            this.name = name;
            this.isPoisonous = isPoisonous;
        }
        public void Ribbit()
        {
            MessageBox.Show(this.name + " says Ribbit");
        }

    }
}
