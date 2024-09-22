using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : ShapeBase
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(string name, int width, int height) : base(name)
        {
            this.Width = width;
            this.Height = height;
        }

        public override float CalculateSurfaceArea()
        {
            return Width * Height;
        }
    }
}
