using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Assigments.Classes
{
    public class Computer
    {
        public string Producent; 
        public string Model;
        public bool isMobile;
    

        public void Present()
        {
            Console.WriteLine($"I am the best computer");
            Console.WriteLine($"My producent is: {Producent}");
            Console.WriteLine($"My model: {Model}");
            if(isMobile)
            {
                Console.WriteLine($"I am mobile computer");
            }
            else
            {
                Console.WriteLine($"I am desktop computer");
            }
        
        }

        public string Error()
        {
            return "BLUE SCREEN!";
        }


    }
}
