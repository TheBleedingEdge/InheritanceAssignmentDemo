using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class ShapeBase
    {
        public string Name { get; set; }

        public ShapeBase(string name)
        {
            this.Name = name;            
        }

        public void Fill(string color)
        {
            Console.WriteLine($"{Name} is now filled with {color}.");
        }

        public abstract float CalculateSurfaceArea();
    }
}
