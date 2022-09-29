using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARVingarna
{
    class Circle : IShape
    {
        private float radie;
        
        public Circle(float radie)
        {
            
        }
        public float Circumference()
            {
                return radie * 2 * ((float)Math.PI);
            }
        public float Area()
            {
                return radie * radie * ((float)Math.PI);
            }
    }
}