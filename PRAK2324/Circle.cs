using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAK2324
{
    class Circle : Figures
    {
        private float Radius;
        public Circle()
        {

        }
        public Circle(float Radius)
        {
            this.Radius = Radius;
        }
        public override float Area()
        {
            return (float)Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
        public override float Perimeter()
        {
            return (float)Math.Round(2*Math.PI * Radius, 1);
        }
    }
}
