using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    public class Parrot//class
    {
        private string name;
        private bool hunger = true;

        public bool Hunger { get; set; }//properties
        public string Name { get; set; }

        public Parrot(string name)//Constructor
        {
            Name = name;
            //hunger = Hunger; 
        }

        public void FeedMe()
        {
            hunger = false;
        }
    }
}
