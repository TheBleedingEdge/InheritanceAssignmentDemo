using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : ShapeBase
    {
        public int Radius { get; set; }
        public Circle(string name, int radius) : base(name)
        {
            this.Radius = radius;
        }

        public override float CalculateSurfaceArea()
        {
            return (float)Math.PI * Radius * Radius;
        }
    }
}
