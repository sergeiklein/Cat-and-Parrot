using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    public class Cat
    {
        public Cat(string name, string furColor, int age, int lives)//Constructor
        {
            Name = name;
            FurColor = furColor;
            Age = age;
            Lives = lives;
        }
            private string name; // These are set to private so they are cant be accesed or changed
            private string furColor;
            private int age;
            private int lives;

        //Lets create a propertiers that lets us access
        public string Name //These can be changed and accesed 
        {
            get { return this.name; } // this will return value
            set { this.name = value; } //sets the value
        }
        public string FurColor
        {
            get { return this.furColor;}
            set { this.furColor = value;}
        }
        public int Age
        {
            get { return this.age; }    
            set { this.age = value;}    
        }
        public int Lives
        {
            get { return this.lives;}   
            set { this.lives = value; }
        }
        
         
    }
}
