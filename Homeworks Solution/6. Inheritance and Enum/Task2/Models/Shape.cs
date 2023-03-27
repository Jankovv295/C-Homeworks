using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int[] Position { get; set; }
        public Shape() { }
        public Shape(string name, string color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;
        } 
        public void getArea () 
        {
            Console.WriteLine("There is no special implementation for area");
        }
        public void getPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }
    }
}
