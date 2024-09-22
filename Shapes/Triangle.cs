using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : ShapeBase
    {
        public int Base { get; set; }
        public int Height { get; set; }
        public Triangle(string name, int triangleBase, int height) : base(name)
        {
            this.Base = triangleBase;
            this.Height = height;
        }

        public override float CalculateSurfaceArea()
        {
            return (float)(Base * Height)/2;
        }
    }
}
