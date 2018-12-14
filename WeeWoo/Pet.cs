using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeWoo
{
    class Pet
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public bool CanFly { get; set; }

        public string Show()
        {
            if (CanFly == true)
            {
                return String.Format("Name: {0}\nSound {1}\nType: {2} and can fly!!", Name, Sound, GetType());
            }
            else
            {
                return String.Format("Name: {0}\nSound {1}\nType: {2} ", Name, Sound, GetType());
            }
        }
    }

    class Dog : Pet
    {
        public Dog(String name)
        {
            Name = name;
            Sound = "WOWOF";
            CanFly = false;

        }
    }
    class Cat : Pet
    {
        public Cat(String name)
        {
            Name = name;
            Sound = "MU";
            CanFly = false;

        }
    }
    class Bird : Pet
    {
        public Bird(String name)
        {
            Name = name;
            Sound = "TWITTER";
            CanFly = true;

        }
    }
    class Fish : Pet
    {
        public Fish(String name)
        {
            Name = name;
            Sound = "BLUBBBBB";
            CanFly = true;

        }
    }
}