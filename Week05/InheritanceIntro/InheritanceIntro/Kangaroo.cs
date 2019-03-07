using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Kangaroo : Animal
    {
        public int JumpHeight;

        public void Meow()
        {
            MessageBox.Show("Meow");
        }
        public Kangaroo()
        {

        }
        public Kangaroo(int height, string name, int jumpHeight)
        {
            Height = height;
            Name = name;
            JumpHeight = jumpHeight;
        }
    }
}
