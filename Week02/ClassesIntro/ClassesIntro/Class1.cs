using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    class Class1
    {
        public class Restruant
        {
            public string Name;
            public int Restraunts;
            public int Rating;
            public int Profit;

            public void Report()
            {
                MessageBox.Show("Our name is " + Name);
                MessageBox.Show("Our number of restruants is" + Restraunts);
                MessageBox.Show("Our rating is" + Rating);
                MessageBox.Show("Our profit is" + Profit);

            }
         
        }
    }
}
