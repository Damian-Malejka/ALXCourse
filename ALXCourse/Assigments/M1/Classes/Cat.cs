using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Assigments.M1.Classes
{
    public class Cat
    {
        public string Name;
        public int Age; 
        public bool isFurious;

        public Cat(string name)
        {
            Name = name;
        }

        public Cat(string name, int age, bool isFurious)
        {
            Name = name;
            Age = age;
            this.isFurious = isFurious;
        }

        public void PleaseEat() 
        {
            Console.WriteLine("I'm dying, let me eat.");
        }

        public string TestEat(string typeEat)
        {
            if(typeEat == "meat")
            {
                return "You are the best";
            }
            else
            {
                return "I do not eat this shit";
            }
        }

        public void Present()
        {
            Console.WriteLine($"I am the best cat");
            Console.WriteLine($"My name is: {Name}");
            Console.WriteLine($"My age: {Age}");
            if(isFurious)
            {
                Console.WriteLine($"I am furious cat");
            }
            else
            {
                Console.WriteLine($"I am not furious cat");
            }

        }
    }
}
