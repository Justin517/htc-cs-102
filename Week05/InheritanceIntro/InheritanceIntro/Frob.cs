using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Frob : Animal
    {
        public bool Poisonous;
       
        public void Ribbit()
        {
            MessageBox.Show("Ribbit");
        }
        public Frob()
        {

        }
        public Frob(int height, string name, bool poisonous)
        {
            Height = height;
            Name = name;
            Poisonous = poisonous;

        }
    }
}
